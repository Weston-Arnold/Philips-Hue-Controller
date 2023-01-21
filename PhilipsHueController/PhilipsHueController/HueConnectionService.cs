using PhilipsHueController.Common.Helpers;
using Q42.HueApi;
using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhilipsHueController
{
    public static class HueConnectionService
    {
        private static LocalHueClient LocalHueClient;

        public static LocalHueClient GetLocalHueClient()
        {
            if (LocalHueClient == null)
            {
                LoadConfiguredBridge();
            }
            return LocalHueClient;
        }

        public static async Task<List<LocatedBridge>> GetLocalNetworkBridges()
        {
            return await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
        }

        public async static Task<string> GetConnectedBridgeFooterInformation()
        {
            var client = GetLocalHueClient();
            var bridge = await client.GetBridgeAsync();

            return $"Bridge Information - {bridge.Config.Name} | Id : {bridge.Config.BridgeId} | {bridge.Config.IpAddress} | {bridge.Config.MacAddress}";
        }

        public static async Task<bool> ConfigureBridge(string ipAddress)
        {
            try
            {
                LocalHueClient = new LocalHueClient(ipAddress);
                var appKey = await LocalHueClient.RegisterAsync("PhilipsHueController", "MyPC");

                LocalHueClient.Initialize(appKey);

                ConfigurationHelpers.AddOrUpdateAppSettingByKey("AppKey", appKey);
                ConfigurationHelpers.AddOrUpdateAppSettingByKey("BridgeIpAddress", ipAddress);

                return true;
            }
            catch (LinkButtonNotPressedException)
            {
                return false;
            }
        }

        public static void LoadConfiguredBridge()
        {
            var bridgeIpAddress = ConfigurationHelpers.GetAppSettingByKey("BridgeIpAddress");
            var appKey = ConfigurationHelpers.GetAppSettingByKey("AppKey");

            LocalHueClient = new LocalHueClient(bridgeIpAddress);
            LocalHueClient.Initialize(appKey);
        }

        public static bool IsApplicationRegistered()
        {
            return ConfigurationHelpers.GetAppSettingByKey("AppKey") != null;
        }
    }
}
