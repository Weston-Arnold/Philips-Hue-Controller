
namespace PhilipsHueController
{
    partial class SetupWindow
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
            this.SuspendLayout();
            // 
            // lblConnectionError
            // 
            this.lblConnectionError.AutoSize = true;
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionError.Location = new System.Drawing.Point(12, 661);
            this.lblConnectionError.MaximumSize = new System.Drawing.Size(750, 0);
            this.lblConnectionError.Name = "lblConnectionError";
            this.lblConnectionError.Size = new System.Drawing.Size(737, 50);
            this.lblConnectionError.TabIndex = 9;
            this.lblConnectionError.Text = "Could not connect to selected bridge. Ensure that you are pressing the button on " +
    "your Hue Bridge within 30 seconds prior to clicking the connect button.";
            // 
            // lbBridgeList
            // 
            this.lbBridgeList.FormattingEnabled = true;
            this.lbBridgeList.ItemHeight = 25;
            this.lbBridgeList.Location = new System.Drawing.Point(206, 180);
            this.lbBridgeList.Name = "lbBridgeList";
            this.lbBridgeList.Size = new System.Drawing.Size(316, 279);
            this.lbBridgeList.TabIndex = 8;
            this.lbBridgeList.SelectedIndexChanged += new System.EventHandler(this.lbBridgeList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 491);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(316, 65);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSetupInstructions
            // 
            this.lblSetupInstructions.AutoSize = true;
            this.lblSetupInstructions.Location = new System.Drawing.Point(132, 67);
            this.lblSetupInstructions.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblSetupInstructions.Name = "lblSetupInstructions";
            this.lblSetupInstructions.Size = new System.Drawing.Size(482, 100);
            this.lblSetupInstructions.TabIndex = 6;
            this.lblSetupInstructions.Text = "Click the button below to search for your Hue Bridge and select the one you wish " +
    "to connect to. Once selected, press the button on your Hue bridge and click conn" +
    "ect within 30 seconds.";
            // 
            // btnConnectBridge
            // 
            this.btnConnectBridge.BackColor = System.Drawing.Color.White;
            this.btnConnectBridge.Location = new System.Drawing.Point(206, 580);
            this.btnConnectBridge.Name = "btnConnectBridge";
            this.btnConnectBridge.Size = new System.Drawing.Size(316, 64);
            this.btnConnectBridge.TabIndex = 5;
            this.btnConnectBridge.Text = "Connect Hue Bridge";
            this.btnConnectBridge.UseVisualStyleBackColor = false;
            this.btnConnectBridge.Click += new System.EventHandler(this.btnConnectBridge_Click);
            // 
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 779);
            this.Controls.Add(this.lblConnectionError);
            this.Controls.Add(this.lbBridgeList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSetupInstructions);
            this.Controls.Add(this.btnConnectBridge);
            this.Name = "SetupWindow";
            this.Text = "Philips Hue Controller";
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
    }
}

