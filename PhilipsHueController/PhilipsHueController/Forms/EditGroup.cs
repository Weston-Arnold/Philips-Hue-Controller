using PhilipsHueController.Extensions;
using PhilipsHueController.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhilipsHueController.Forms
{
    public partial class EditGroup : Form
    {
        private readonly string GroupName = string.Empty;
        private readonly string GroupId = string.Empty;

        public EditGroup(object selectedGroup)
        {
            InitializeComponent();

            GroupId = selectedGroup.GetObjectPropertyByName("Id");
            GroupName = selectedGroup.GetObjectPropertyByName("GroupName");

            txtRename.Text = GroupName;
        }

        private async void EditGroup_Load(object sender, EventArgs e)
        {
            await LoadLightList();
        }

        private async void btnSaveChange_Click(object sender, EventArgs e)
        {
            await HueGroupHelpers.RenameGroupById(GroupId, txtRename.Text);
            Close();
        }

        private async Task LoadLightList()
        {
            var allLights = await HueLightHelpers.GetAllLights();
            foreach (var light in allLights.OrderBy(x => x.Name))
            {
                clbLights.Items.Add(new
                {
                    Id = light.Id,
                    LightName = light.Name
                });
            }
            clbLights.DisplayMember = "LightName";

            var groupLightIds = await HueLightHelpers.GetAllLightsByGroupId(GroupId);
            foreach(var lightId in groupLightIds)
            {
                var light = await HueLightHelpers.GetLightById(lightId);
                var lightObject = new
                {
                    Id = lightId,
                    LightName = light.GetObjectPropertyByName("Name")
                };
                var indexOfLight = clbLights.Items.IndexOf(lightObject);

                clbLights.SetItemChecked(indexOfLight, true);
            }

            clbLights.DisplayMember = "LightName";
        }
    }
}
