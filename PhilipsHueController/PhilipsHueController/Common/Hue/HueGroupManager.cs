using PhilipsHueController.Common.Helpers;
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

namespace PhilipsHueController.Helpers
{
    public static class HueGroupManager
    {
        public async static Task<IEnumerable<Group>> GetAllGroups(GroupType? groupType = null)
        {
            var localHueClient = HueConnectionManager.GetLocalHueClient();
            var groups = await localHueClient.GetGroupsAsync();

            return groups.Where(x => groupType == null || x.Type == groupType);
        }

        public async static Task<Group> GetGroupById(string groupId)
        {
            var localHueClient = HueConnectionManager.GetLocalHueClient();
            return await localHueClient.GetGroupAsync(groupId);
        }

        public async static Task<bool> UpdateGroupById(string groupId, List<string> lightIds, string name)
        {
            var group = await GetGroupById(groupId);
            var hueClient = HueConnectionManager.GetLocalHueClient();

            var result = await hueClient.UpdateGroupAsync(group.Id, lightIds, name);
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

        public async static Task ToggleGroupLightsOnOff(string groupId, bool on)
        {
            var powerCommand = on
                ? new LightCommand().TurnOn()
                : new LightCommand().TurnOff();

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendGroupCommandAsync(powerCommand, groupId);
        }

        public async static Task SetGroupColor(string groupId, Color color)
        {
            var setLightCommand = new LightCommand();
            var hexColor = color.ConvertToHex();

            setLightCommand.SetColor(new RGBColor(hexColor));

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendGroupCommandAsync(setLightCommand, groupId);
        }

        public async static Task SetGroupBrightness(string groupId, byte brightnessValue)
        {
            var brightnessCommand = new LightCommand
            {
                Brightness = brightnessValue
            };

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendGroupCommandAsync(brightnessCommand, groupId);
        }

        public async static Task<string> GetGroupInformation(string groupId)
        {
            var group = await GetGroupById(groupId);
            var groupLightIds = await HueLightManager.GetAllLightsByGroupId(groupId);
            var groupLights = new List<string>();

            foreach(var lightId in groupLightIds)
            {
                var light = await HueLightManager.GetLightById(lightId);
                groupLights.Add(light.Name);
            }
            
            var groupLightsFormattedString = string.Join(", ", groupLights);

            return
                $"Group Id: {group.Id}\n" +
                $"Group Name: {group.Name}\n" +
                $"Type: {group.Type}\n" + 
                $"Class: {group.Class}\n" +
                $"Number of Lights: {group.Lights.Count}\n\n" +
                $"Lights: {groupLightsFormattedString}\n";
        }
    }
}
