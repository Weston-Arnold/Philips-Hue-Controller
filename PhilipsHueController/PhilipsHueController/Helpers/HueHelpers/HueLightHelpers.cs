using PhilipsHueController.Extensions;
using Q42.HueApi;
using System;
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

        public async static Task<Light> GetLightById(string id)
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetLightAsync(id);
        }

        public async static Task<string> GetSelectedLightInformation(object selectedLight)
        {
            var id = selectedLight.GetObjectPropertyByName("Id");
            var light = await GetLightById(id);

            return
                $"Id: {light.Id}\n" +
                $"Name: {light.Name}\n" +
                $"Ver: {light.SoftwareVersion}\n" +
                $"Model Id: {light.ModelId}\n" +
                $"Product Id: {light.ProductId}\n" + 
                $"Manufacturer Name: {light.ManufacturerName}\n";
        }
    }
}
