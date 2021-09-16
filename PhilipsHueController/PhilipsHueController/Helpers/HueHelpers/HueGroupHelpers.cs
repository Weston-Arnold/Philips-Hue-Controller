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
