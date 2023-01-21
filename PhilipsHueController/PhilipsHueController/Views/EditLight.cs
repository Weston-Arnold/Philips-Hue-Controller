using PhilipsHueController.Common.Extensions;
using PhilipsHueController.Controllers;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class EditLight : Form
    {
        private readonly string LightName = string.Empty;
        private readonly string LightId = string.Empty;

        public EditLight(object selectedLight)
        {
            InitializeComponent();

            LightId = selectedLight.GetObjectPropertyByName("Id");
            LightName = selectedLight.GetObjectPropertyByName("LightName");

            txtRename.Text = LightName;
        }

        private async void btnSaveChange_Click(object sender, System.EventArgs e)
        {
            await LightController.UpdateByIdAsync(LightId, txtRename.Text);
            Close();
        }
    }
}
