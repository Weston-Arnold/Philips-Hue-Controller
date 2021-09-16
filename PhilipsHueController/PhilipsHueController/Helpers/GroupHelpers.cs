using Q42.HueApi.Models.Groups;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhilipsHueController.Helpers
{
    public static class GroupHelpers
    {
        public async static Task<IEnumerable<Group>> GetAllGroups()
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetGroupsAsync();
        }
    }
}
