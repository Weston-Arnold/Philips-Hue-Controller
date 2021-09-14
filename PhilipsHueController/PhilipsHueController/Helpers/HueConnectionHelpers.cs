using Q42.HueApi;
using System;
using System.Threading.Tasks;

namespace PhilipsHueController
{
    public static class HueConnectionHelpers
    {
        public static async Task ConfigureBridge()
        {
            var locator = new HttpBridgeLocator();

            await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));

            var localHueClient = new LocalHueClient("192.168.1.64");
            var appKey = await localHueClient.RegisterAsync("PhilipsHueController", "MyPC");

            localHueClient.Initialize(appKey);

            var command = new LightCommand();
            command.TurnOn();
            await localHueClient.SendCommandAsync(command);
        }
    }
}
