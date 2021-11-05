using PhilipsHueController.Common.Helpers;
using PhilipsHueController.Extensions;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.HSB;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController.Helpers
{
    public static class HueLightManager
    {
        public async static Task<IEnumerable<Light>> GetAllLights()
        {
            var localHueClient = HueConnectionManager.GetLocalHueClient();
            return await localHueClient.GetLightsAsync();
        }

        public async static Task<IEnumerable<string>> GetAllLightsByGroupId(string groupId)
        {
            var lightsInGroup = await HueGroupManager.GetGroupById(groupId);
            return lightsInGroup.Lights;
        }

        public async static Task<Light> GetLightById(string lightId)
        {
            var localHueClient = HueConnectionManager.GetLocalHueClient();
            return await localHueClient.GetLightAsync(lightId);
        }

        public async static Task<IEnumerable<string>> GetAllGroupNamesForLight(string lightId)
        {
            var allGroups = await HueGroupManager.GetAllGroups();

            return allGroups
                .Where(x => x.Lights.Contains(lightId))
                .Select(x => x.Name)
                .ToList();
        }

        public async static Task RenameLightById(string lightId, string newName)
        {
            var light = await GetLightById(lightId);
            var hueClient = HueConnectionManager.GetLocalHueClient();

            await hueClient.SetLightNameAsync(light.Id, newName);
        }

        public async static Task BlinkSelectedLight(string lightId)
        {
            var light = await GetLightById(lightId);
            var currentBrightness = light.State.Brightness;

            await SetLightBrightness(lightId, 1);
            await SetLightBrightness(lightId, currentBrightness);
        }

        public async static Task SetLightBrightness(string lightId, byte brightnessValue)
        {
            var brightnessCommand = new LightCommand
            {
                Brightness = brightnessValue
            };

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendCommandAsync(brightnessCommand, new List<string> { lightId });
        }

        public async static Task SetLightOnOff(string lightId, bool on)
        {
            var powerCommand = on 
                ? new LightCommand().TurnOn() 
                : new LightCommand().TurnOff();

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendCommandAsync(powerCommand, new List<string> { lightId });
        }

        public async static Task SetLightColor(string lightId, Color color)
        {
            var setLightCommand = new LightCommand();
            var hexColor = color.ConvertToHex();

            setLightCommand.SetColor(new RGBColor(hexColor));

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendCommandAsync(setLightCommand, new List<string> { lightId });
        }

        public async static Task<byte> GetLightBrightness(string lightId)
        {
            var light = await GetLightById(lightId);
            return light.State.Brightness;
        }

        public async static Task<string> GetSelectedLightInformation(string lightId)
        {
            var light = await GetLightById(lightId);
            var lightGroups = await GetAllGroupNamesForLight(lightId);
            var lightGroupsFormattedString = string.Join(", ", lightGroups);

            var lightPowerState = light.State.On ? "On" : "Off";
            var isReachable = light.State.IsReachable.HasValue && light.State.IsReachable.Value ? "Yes" : "No";

            return
                $"Light Id: {light.Id}\n" +
                $"Light Name: {light.Name}\n" +
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
