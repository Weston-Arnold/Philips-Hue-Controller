using PhilipsHueController.Extensions;
using Q42.HueApi;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController.Helpers
{
    public static class HueLightHelpers
    {
        public async static Task<List<Light>> GetAllLights()
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            var lights = await localHueClient.GetLightsAsync();

            return lights.ToList();
        }

        public async static Task<List<string>> GetAllLightsByGroupId(string id)
        {
            var lightsInGroup = await HueGroupHelpers.GetGroupById(id);
            return lightsInGroup.Lights;
        }

        public async static Task<Light> GetLightById(string id)
        {
            var localHueClient = HueConnectionHelpers.GetLocalHueClient();
            return await localHueClient.GetLightAsync(id);
        }

        public async static Task RenameLightById(string id, string newName)
        {
            var light = await GetLightById(id);
            var hueClient = HueConnectionHelpers.GetLocalHueClient();

            await hueClient.SetLightNameAsync(light.Id, newName);
        }

        public async static Task BlipSelectedLight(object selectedLight)
        {
            var id = selectedLight.GetObjectPropertyByName("Id");

            var light = await GetLightById(id);
            var currentBrightness = light.State.Brightness;

            await SetSingleLightBrightness(id, 1);
            await SetSingleLightBrightness(id, currentBrightness);
        }

        public async static Task SetSingleLightBrightness(string lightId, byte brightnessValue)
        {
            var brightnessCommand = new LightCommand
            {
                Brightness = brightnessValue
            };

            var client = HueConnectionHelpers.GetLocalHueClient();
            await client.SendCommandAsync(brightnessCommand, new List<string> { lightId });
        }

        public async static Task<string> GetSelectedLightInformation(object selectedLight)
        {
            var id = selectedLight.GetObjectPropertyByName("Id");

            var light = await GetLightById(id);
            var lightGroups = await HueGroupHelpers.GetAllGroupNamesForLight(id);
            var lightGroupsFormattedString = string.Join(", ", lightGroups);

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
                $"Manufacturer Name: {light.ManufacturerName}\n\n" +
                $"Groups: {lightGroupsFormattedString}\n";
        }
    }
}
