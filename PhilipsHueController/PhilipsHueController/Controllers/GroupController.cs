using PhilipsHueController.Common.Extensions;
using PhilipsHueController.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.Models.Groups;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController.Controllers
{
    public static class GroupController
    {
        public async static Task<IEnumerable<Group>> GetAllAsync(GroupType? groupType = null)
        {
            var groups = await HueConnectionService
                .GetLocalHueClient()
                .GetGroupsAsync();

            return groups.Where(x => groupType == null || x.Type == groupType);
        }

        public async static Task<Group> GetByIdAsync(string groupId)
        {
            return await HueConnectionService
                .GetLocalHueClient()
                .GetGroupAsync(groupId);
        }

        public async static Task<bool> UpdateByIdAsync(string groupId, List<string> lightIds, string name)
        {
            var group = await GetByIdAsync(groupId);

            var result = await HueConnectionService
                .GetLocalHueClient()
                .UpdateGroupAsync(group.Id, lightIds, name);

            var error = result
                .Where(x => x.Error != null)
                .Select(x => x.Error)
                .FirstOrDefault();

            if (error == null)
            {
                return true;
            }

            var errorMessageWindow = new ErrorMessage(error.Description);
            errorMessageWindow.ShowDialog();

            return false;
        }

        public async static Task TogglePowerAsync(string groupId, bool on)
        {
            var powerCommand = on
                ? new LightCommand().TurnOn()
                : new LightCommand().TurnOff();

            await SendGroupCommandAsync(powerCommand, groupId);
        }

        public async static Task SetColorAsync(string groupId, Color color)
        {
            var hexColor = color.ConvertToHex();

            var setLightCommand = new LightCommand();
            setLightCommand.SetColor(new RGBColor(hexColor));

            await SendGroupCommandAsync(setLightCommand, groupId);
        }

        public async static Task SetBrightnessAsync(string groupId, byte brightnessValue)
        {
            var brightnessCommand = new LightCommand
            {
                Brightness = brightnessValue
            };

            await SendGroupCommandAsync(brightnessCommand, groupId);
        }

        public async static Task<string> GetInformationAsync(string groupId)
        {
            var group = await GetByIdAsync(groupId);
            var groupLightIds = await LightController.GetAllByGroupIdAsync(groupId);
            var groupLights = new List<string>();

            foreach (var lightId in groupLightIds)
            {
                var light = await LightController.GetByIdAsync(lightId);
                groupLights.Add(light.Name);
            }

            var groupLightsFormattedString = string.Join(", ", groupLights);

            return
                $"Room Id: {group.Id}\n" +
                $"Room Name: {group.Name}\n" +
                $"Type: {group.Type}\n" +
                $"Class: {group.Class}\n" +
                $"Number of Lights: {group.Lights.Count}\n\n" +
                $"Lights: {groupLightsFormattedString}\n";
        }

        private async static Task SendGroupCommandAsync(LightCommand command, string groupId)
        {
            await HueConnectionService
                .GetLocalHueClient()
                .SendGroupCommandAsync(command, groupId);
        }
    }
}
