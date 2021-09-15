using PhilipsHueController.Helpers;
using Q42.HueApi;
using Q42.HueApi.Models.Bridge;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipsHueController
{
    public static class HueConnectionHelpers
    {
        public static async Task ConfigureBridge()
        {
            var bridge = await GetNearbyBridge();
            if(bridge == null)
            {
                //todo
                return;
            }

            var localHueClient = new LocalHueClient(bridge.IpAddress);
            var appKey = await localHueClient.RegisterAsync("PhilipsHueController", "MyPC");

            localHueClient.Initialize(appKey);
            ConfigHelpers.AddOrUpdateAppSetting("AppKey", appKey);
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

        public static async Task<LocatedBridge> GetNearbyBridge()
        {
            //todo: multiple bridges found -- user selection?
            var locator = new HttpBridgeLocator();

            await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            var bridgesFound = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));

            if (bridgesFound.Any())
            {
                return bridgesFound[0];
            }

            return null;
        }
    }
}
