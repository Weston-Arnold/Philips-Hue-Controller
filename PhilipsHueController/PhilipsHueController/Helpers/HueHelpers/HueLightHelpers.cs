using PhilipsHueController.Extensions;
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

        public async static Task<Light> GetLightById(string id)
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetLightAsync(id);
        }

        public async static Task<string> GetSelectedLightInformation(object selectedLight)
        {
            var id = selectedLight.GetObjectPropertyByName("Id");
            var light = await GetLightById(id);

            var lightPowerState = light.State.On ? "On" : "Off";
            var isReachable = light.State.IsReachable.HasValue && light.State.IsReachable.Value ? "Yes" : "No";

            return
                $"Id: {light.Id}\n" +
                $"Name: {light.Name}\n" +
                $"Power: {lightPowerState}\n" +
                $"Reachable: {isReachable}\n" +
                $"Brightness: {light.State.Brightness}\n" +
                $"Color Mode: {light.State.ColorMode ?? "N/A"}\n" +
                $"Color Temperature: {light.State.ColorTemperature.ToString() ?? "N/A"}\n" +
                $"Hue: {light.State.Hue.ToString() ?? "N/A"}\n" +
                $"Effect: {light.State.Effect.ToString() ?? "N/A"}\n" +
                $"Mode: {light.State.Mode}\n" +
                $"Saturation: {light.State.Saturation.ToString() ?? "N/A"}\n" +
                $"Ver: {light.SoftwareVersion}\n" +
                $"Model Id: {light.ModelId}\n" +
                $"Product Id: {light.ProductId}\n" +
                $"Type: {light.Type}\n" +
                $"Manufacturer Name: {light.ManufacturerName}\n";
        }
    }
}
