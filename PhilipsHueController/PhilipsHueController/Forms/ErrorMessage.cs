using System.Windows.Forms;

namespace PhilipsHueController.Forms
{
    public partial class ErrorMessage : Form
    {
        public ErrorMessage(string errorMessage)
        {
            InitializeComponent();

            txtErrorMessage.Text = $"Error: {errorMessage}";
        }

        private void btnCloseErrorMessage_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
