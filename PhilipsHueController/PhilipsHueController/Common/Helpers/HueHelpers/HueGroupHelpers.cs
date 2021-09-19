using PhilipsHueController.Forms;
using Q42.HueApi.Models.Groups;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController.Helpers
{
    public static class HueGroupHelpers
    {
        public async static Task<IEnumerable<Group>> GetAllGroups(GroupType? groupType = null)
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            var groups = await localHueClient.GetGroupsAsync();

            return groups.ToList().Where(x => groupType == null || x.Type == groupType);
        }

        public async static Task<Group> GetGroupById(string id)
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetGroupAsync(id);
        }

        public async static Task<bool> UpdateGroupById(string id, List<string> lightIds, string name)
        {
            var group = await GetGroupById(id);
            var hueClient = HueConnectionHelpers.GetLocalHueClient();

            var result = await hueClient.UpdateGroupAsync(group.Id, lightIds, name);
            var error = result.FirstOrDefault(x => x.Error != null)?.Error;

            if(error != null)
            {
                var errorMessageWindow = new ErrorMessage(error.Description);
                errorMessageWindow.ShowDialog();

                return false;
            }
            return true;
        }

        public async static Task<List<string>> GetAllGroupNamesForLight(string lightId)
        {
            var allGroups = await GetAllGroups();

            return allGroups
                .Where(x => x.Lights.Contains(lightId))
                .Select(x => x.Name)
                .ToList();
        }
    }
}
