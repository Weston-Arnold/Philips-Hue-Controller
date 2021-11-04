using PhilipsHueController.Common.Helpers;
using PhilipsHueController.Extensions;
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

            return groups.ToList().Where(x => groupType == null || x.Type == groupType);
        }

        public async static Task<Group> GetGroupById(string id)
        {
            var localHueClient = HueConnectionManager.GetLocalHueClient();
            return await localHueClient.GetGroupAsync(id);
        }

        public async static Task<bool> UpdateGroupById(string id, List<string> lightIds, string name)
        {
            var group = await GetGroupById(id);
            var hueClient = HueConnectionManager.GetLocalHueClient();

            var result = await hueClient.UpdateGroupAsync(group.Id, lightIds, name);
            var error = result.FirstOrDefault(x => x.Error != null)?.Error;

            if(error != null)
            {
                var errorMessageWindow = new ErrorMessage(error.Description);
                errorMessageWindow.ShowDialog();

                return false;
            }
            return true;
        }

        public async static Task<List<string>> GetAllGroupNamesForLight(string lightId)
        {
            var allGroups = await GetAllGroups();

            return allGroups
                .Where(x => x.Lights.Contains(lightId))
                .Select(x => x.Name)
                .ToList();
        }

        public async static Task SetGroupLightsOnOff(string groupId, bool on)
        {
            var powerCommand = on
                ? new LightCommand().TurnOn()
                : new LightCommand().TurnOff();

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendGroupCommandAsync(powerCommand, groupId);
        }

        public async static Task SetGroupLightColor(Color color, string groupId)
        {
            var setLightCommand = new LightCommand();
            var hexColor = ColorHelpers.ConvertColorToHex(color);

            setLightCommand.SetColor(new RGBColor(hexColor));

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendGroupCommandAsync(setLightCommand, groupId);
        }

        public async static Task SetGroupLightBrightness(string groupId, byte brightnessValue)
        {
            var brightnessCommand = new LightCommand
            {
                Brightness = brightnessValue
            };

            var client = HueConnectionManager.GetLocalHueClient();
            await client.SendGroupCommandAsync(brightnessCommand, groupId);
        }

        public async static Task<string> GetSelectedGroupInformation(object selectedGroup)
        {
            var id = selectedGroup.GetObjectPropertyByName("Id");

            var group = await GetGroupById(id);
            var groupLightIds = await HueLightManager.GetAllLightsByGroupId(id);
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
