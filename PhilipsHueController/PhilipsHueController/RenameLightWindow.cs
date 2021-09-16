using PhilipsHueController.Extensions;
using PhilipsHueController.Helpers;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class RenameLightWindow : Form
    {
        private readonly string LightName = string.Empty;
        private readonly string LightId = string.Empty;

        public RenameLightWindow(object selectedLight)
        {
            InitializeComponent();

            LightId = selectedLight.GetObjectPropertyByName("Id");
            LightName = selectedLight.GetObjectPropertyByName("LightName");

            txtRename.Text = LightName;
        }

        private async void btnSaveChange_Click(object sender, System.EventArgs e)
        {
            var lights = await HueLightHelpers.GetAllLights();
            var hueClient = HueConnectionHelpers.GetLocalHueClient();

            foreach (var light in lights)
            {
                if(light.Id != LightId)
                {
                    continue;
                }

                await hueClient.SetLightNameAsync(light.Id, txtRename.Text);
                Close();
            }
        }
    }
}
