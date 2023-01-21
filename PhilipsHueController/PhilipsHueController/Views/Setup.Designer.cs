
namespace PhilipsHueController
{
    partial class Setup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConnectionError = new System.Windows.Forms.Label();
            this.lbBridgeList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSetupInstructions = new System.Windows.Forms.Label();
            this.btnConnectBridge = new System.Windows.Forms.Button();
            this.lblSetupTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConnectionError
            // 
            this.lblConnectionError.AutoSize = true;
            this.lblConnectionError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionError.Location = new System.Drawing.Point(21, 420);
            this.lblConnectionError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnectionError.MaximumSize = new System.Drawing.Size(525, 0);
            this.lblConnectionError.Name = "lblConnectionError";
            this.lblConnectionError.Size = new System.Drawing.Size(489, 38);
            this.lblConnectionError.TabIndex = 9;
            this.lblConnectionError.Text = "Could not connect to selected bridge. Ensure that you are pressing the \"Connect\" " +
    "button within 30 seconds of pressing the button on your bridge.";
            this.lblConnectionError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBridgeList
            // 
            this.lbBridgeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBridgeList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBridgeList.FormattingEnabled = true;
            this.lbBridgeList.ItemHeight = 19;
            this.lbBridgeList.Location = new System.Drawing.Point(73, 222);
            this.lbBridgeList.Margin = new System.Windows.Forms.Padding(2);
            this.lbBridgeList.Name = "lbBridgeList";
            this.lbBridgeList.Size = new System.Drawing.Size(372, 137);
            this.lbBridgeList.TabIndex = 8;
            this.lbBridgeList.SelectedIndexChanged += new System.EventHandler(this.lbBridgeList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(76, 142);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(369, 39);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSetupInstructions
            // 
            this.lblSetupInstructions.AutoSize = true;
            this.lblSetupInstructions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupInstructions.Location = new System.Drawing.Point(80, 54);
            this.lblSetupInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetupInstructions.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblSetupInstructions.Name = "lblSetupInstructions";
            this.lblSetupInstructions.Size = new System.Drawing.Size(340, 76);
            this.lblSetupInstructions.TabIndex = 6;
            this.lblSetupInstructions.Text = "Click the button below to search for your Hue Bridge. Once yours is selected, pre" +
    "ss the button on the top of your bridge and click \"Connect Hue Bridge\" within 30" +
    " seconds.";
            this.lblSetupInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectBridge
            // 
            this.btnConnectBridge.BackColor = System.Drawing.Color.White;
            this.btnConnectBridge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectBridge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnectBridge.Location = new System.Drawing.Point(74, 374);
            this.btnConnectBridge.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectBridge.Name = "btnConnectBridge";
            this.btnConnectBridge.Size = new System.Drawing.Size(371, 38);
            this.btnConnectBridge.TabIndex = 5;
            this.btnConnectBridge.Text = "Connect";
            this.btnConnectBridge.UseVisualStyleBackColor = false;
            this.btnConnectBridge.Click += new System.EventHandler(this.btnConnectBridge_Click);
            // 
            // lblSetupTitle
            // 
            this.lblSetupTitle.AutoSize = true;
            this.lblSetupTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupTitle.Location = new System.Drawing.Point(80, 9);
            this.lblSetupTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetupTitle.Name = "lblSetupTitle";
            this.lblSetupTitle.Size = new System.Drawing.Size(355, 45);
            this.lblSetupTitle.TabIndex = 10;
            this.lblSetupTitle.Text = "Connect to Hue Bridge";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 467);
            this.Controls.Add(this.lblSetupTitle);
            this.Controls.Add(this.lblConnectionError);
            this.Controls.Add(this.lbBridgeList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSetupInstructions);
            this.Controls.Add(this.btnConnectBridge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Setup";
            this.Load += new System.EventHandler(this.SetupWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionError;
        private System.Windows.Forms.ListBox lbBridgeList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSetupInstructions;
        private System.Windows.Forms.Button btnConnectBridge;
        private System.Windows.Forms.Label lblSetupTitle;
    }
}

