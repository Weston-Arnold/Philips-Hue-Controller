using Q42.HueApi.Models.Groups;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController.Helpers
{
    public static class HueGroupHelpers
    {
        public async static Task<IEnumerable<Group>> GetAllGroups()
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetGroupsAsync();
        }

        public async static Task<Group> GetGroupById(string id)
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetGroupAsync(id);
        }

        public async static Task RenameGroupById(string id, string newName)
        {
            var group = await GetGroupById(id);
            var hueClient = HueConnectionHelpers.GetLocalHueClient();
            var lightsInGroup = await HueLightHelpers.GetAllLightsByGroupId(id);

            await hueClient.UpdateGroupAsync(group.Id, lightsInGroup, newName);
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
