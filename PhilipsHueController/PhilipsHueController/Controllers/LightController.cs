using PhilipsHueController.Common.Extensions;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.HSB;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController.Controllers
{
    public static class LightController
    {
        public async static Task<IEnumerable<Light>> GetAllAsync()
        {
            return await HueConnectionService
                .GetLocalHueClient()
                .GetLightsAsync();
        }

        public async static Task<IEnumerable<string>> GetAllByGroupIdAsync(string groupId)
        {
            var lightsInGroup = await GroupController.GetByIdAsync(groupId);
            return lightsInGroup.Lights;
        }

        public async static Task<Light> GetByIdAsync(string lightId)
        {
            return await HueConnectionService
                .GetLocalHueClient()
                .GetLightAsync(lightId);
        }

        public async static Task<IEnumerable<string>> GetGroupListForLightAsync(string lightId)
        {
            var allGroups = await GroupController.GetAllAsync();

            return allGroups
                .Where(x => x.Lights.Contains(lightId))
                .Select(x => x.Name)
                .ToList();
        }

        public async static Task UpdateByIdAsync(string lightId, string newName)
        {
            var light = await GetByIdAsync(lightId);

            await HueConnectionService
                .GetLocalHueClient()
                .SetLightNameAsync(light.Id, newName);
        }

        public async static Task BlinkAsync(string lightId)
        {
            var light = await GetByIdAsync(lightId);
            var currentBrightness = light.State.Brightness;

            await SetBrightnessAsync(lightId, 1);
            await SetBrightnessAsync(lightId, currentBrightness);
        }

        public async static Task SetBrightnessAsync(string lightId, byte brightnessValue)
        {
            var brightnessCommand = new LightCommand
            {
                Brightness = brightnessValue
            };

            await SendLightCommandAsync(brightnessCommand, lightId);
        }

        public async static Task TogglePowerAsync(string lightId, bool on)
        {
            var powerCommand = on
                ? new LightCommand().TurnOn()
                : new LightCommand().TurnOff();

            await SendLightCommandAsync(powerCommand, lightId);
        }

        public async static Task SetColorAsync(string lightId, Color color)
        {
            var setLightCommand = new LightCommand();
            var hexColor = color.ConvertToHex();

            setLightCommand.SetColor(new RGBColor(hexColor));

            await SendLightCommandAsync(setLightCommand, lightId);
        }

        public async static Task<byte> GetCurrentBrightnessAsync(string lightId)
        {
            var light = await GetByIdAsync(lightId);
            return light.State.Brightness;
        }

        public async static Task<string> GetInformationAsync(string lightId)
        {
            var light = await GetByIdAsync(lightId);
            var lightGroups = await GetGroupListForLightAsync(lightId);
            var lightGroupsFormattedString = string.Join(", ", lightGroups);

            var lightPowerState = light.State.On ? "On" : "Off";
            var isReachable = light.State.IsReachable == true
                ? "Yes" 
                : "No";

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

        private async static Task SendLightCommandAsync(LightCommand command, string lightId)
        {
            await HueConnectionService
                .GetLocalHueClient()
                .SendCommandAsync(command, new List<string> { lightId });
        }
    }
}
