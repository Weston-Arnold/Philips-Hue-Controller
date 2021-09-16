using Q42.HueApi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhilipsHueController.Helpers
{
    public static class HueLightHelpers
    {
        public async static Task<IEnumerable<Light>> GetAllLights()
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetLightsAsync();
        }
    }
}
