using PhilipsHueController.Extensions;
using PhilipsHueController.Helpers;
using System;
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

        private async void btnSaveChange_Click(object sender, EventArgs e)
        {
            await HueGroupHelpers.RenameGroupById(GroupId, txtRename.Text);
            Close();
        }
    }
}
