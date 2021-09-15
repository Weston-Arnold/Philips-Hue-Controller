using PhilipsHueController.Helpers;
using Q42.HueApi;
using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhilipsHueController
{
    public static class HueConnectionHelpers
    {
        public static async Task<bool> ConfigureBridge(string ipAddress)
        {
            try
            {
                var localHueClient = new LocalHueClient(ipAddress);
                var appKey = await localHueClient.RegisterAsync("PhilipsHueController", "MyPC");

                localHueClient.Initialize(appKey);
                ConfigHelpers.AddOrUpdateAppSetting("AppKey", appKey);

                return true;
            }
            catch (LinkButtonNotPressedException)
            {
                return false;
            }
        }

        public static void LoadConfiguredBridge()
        {
            var localHueClient = new LocalHueClient("192.168.1.64");
            var appKey = ConfigHelpers.GetSettingByKey("AppKey");

            localHueClient.Initialize(appKey);
        }

        public static bool IsApplicationRegistered()
        {
            var appKey = ConfigHelpers.GetSettingByKey("AppKey");
            return appKey != null;
        }

        public static async Task<List<LocatedBridge>> GetNearbyBridges()
        {
            //todo: multiple bridges found -- user selection?
            var locator = new HttpBridgeLocator();

            await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            return await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
        }
    }
}
