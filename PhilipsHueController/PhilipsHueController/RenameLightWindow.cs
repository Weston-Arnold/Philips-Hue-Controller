using PhilipsHueController.Helpers;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class RenameLightWindow : Form
    {
        private readonly string LightName = string.Empty;

        public RenameLightWindow(string lightName)
        {
            InitializeComponent();

            LightName = lightName;
            txtRename.Text = LightName;
        }

        private async void btnSaveChange_Click(object sender, System.EventArgs e)
        {
            var lights = await HueLightHelpers.GetAllLights();
            var hueClient = HueConnectionHelpers.GetLocalHueClient();

            foreach (var light in lights)
            {
                if(light.Name != LightName)
                {
                    continue;
                }

                await hueClient.SetLightNameAsync(light.Id, txtRename.Text);
                Close();
            }
        }
    }
}
