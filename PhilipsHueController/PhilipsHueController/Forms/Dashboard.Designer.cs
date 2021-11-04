
namespace PhilipsHueController
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompleteSetup = new System.Windows.Forms.Button();
            this.pnlContinueSetup = new System.Windows.Forms.Panel();
            this.lblSetupRequiredTitle = new System.Windows.Forms.Label();
            this.lblContinueSetupPrompt = new System.Windows.Forms.Label();
            this.lbLights = new System.Windows.Forms.ListBox();
            this.lblLightListHeader = new System.Windows.Forms.Label();
            this.btnRenameLight = new System.Windows.Forms.Button();
            this.txtAdditionalInformation = new System.Windows.Forms.RichTextBox();
            this.lblAdditionalLightInformation = new System.Windows.Forms.Label();
            this.txtBridgeInfo = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbLightGroups = new System.Windows.Forms.ListBox();
            this.lblLightRooms = new System.Windows.Forms.Label();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.txtQuickOptionsTitle = new System.Windows.Forms.Label();
            this.btnLightsOff = new System.Windows.Forms.Button();
            this.btnLightsOn = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.dlgChangeColor = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.pnlContinueSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompleteSetup
            // 
            this.btnCompleteSetup.Location = new System.Drawing.Point(252, 616);
            this.btnCompleteSetup.Name = "btnCompleteSetup";
            this.btnCompleteSetup.Size = new System.Drawing.Size(344, 73);
            this.btnCompleteSetup.TabIndex = 0;
            this.btnCompleteSetup.Text = "Complete Setup";
            this.btnCompleteSetup.UseVisualStyleBackColor = true;
            this.btnCompleteSetup.Click += new System.EventHandler(this.btnCompleteSetup_Click);
            // 
            // pnlContinueSetup
            // 
            this.pnlContinueSetup.Controls.Add(this.lblSetupRequiredTitle);
            this.pnlContinueSetup.Controls.Add(this.lblContinueSetupPrompt);
            this.pnlContinueSetup.Controls.Add(this.btnCompleteSetup);
            this.pnlContinueSetup.Location = new System.Drawing.Point(2, -1);
            this.pnlContinueSetup.Name = "pnlContinueSetup";
            this.pnlContinueSetup.Size = new System.Drawing.Size(264, 24);
            this.pnlContinueSetup.TabIndex = 1;
            this.pnlContinueSetup.Visible = false;
            // 
            // lblSetupRequiredTitle
            // 
            this.lblSetupRequiredTitle.AutoSize = true;
            this.lblSetupRequiredTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupRequiredTitle.Location = new System.Drawing.Point(221, 332);
            this.lblSetupRequiredTitle.Name = "lblSetupRequiredTitle";
            this.lblSetupRequiredTitle.Size = new System.Drawing.Size(410, 74);
            this.lblSetupRequiredTitle.TabIndex = 2;
            this.lblSetupRequiredTitle.Text = "Setup Required";
            // 
            // lblContinueSetupPrompt
            // 
            this.lblContinueSetupPrompt.AutoSize = true;
            this.lblContinueSetupPrompt.Location = new System.Drawing.Point(57, 486);
            this.lblContinueSetupPrompt.MaximumSize = new System.Drawing.Size(750, 0);
            this.lblContinueSetupPrompt.Name = "lblContinueSetupPrompt";
            this.lblContinueSetupPrompt.Size = new System.Drawing.Size(724, 50);
            this.lblContinueSetupPrompt.TabIndex = 1;
            this.lblContinueSetupPrompt.Text = "Connection to a Philips Hue Bridge is required to use this application. Please Co" +
    "mplete the setup process before continuing.";
            this.lblContinueSetupPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLights
            // 
            this.lbLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLights.FormattingEnabled = true;
            this.lbLights.ItemHeight = 25;
            this.lbLights.Location = new System.Drawing.Point(27, 73);
            this.lbLights.Name = "lbLights";
            this.lbLights.ScrollAlwaysVisible = true;
            this.lbLights.Size = new System.Drawing.Size(391, 304);
            this.lbLights.TabIndex = 2;
            this.lbLights.Click += new System.EventHandler(this.lbLights_OnClick);
            this.lbLights.DoubleClick += new System.EventHandler(this.lbLights_MouseDoubleClick);
            // 
            // lblLightListHeader
            // 
            this.lblLightListHeader.AutoSize = true;
            this.lblLightListHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightListHeader.Location = new System.Drawing.Point(27, 17);
            this.lblLightListHeader.Name = "lblLightListHeader";
            this.lblLightListHeader.Size = new System.Drawing.Size(147, 41);
            this.lblLightListHeader.TabIndex = 3;
            this.lblLightListHeader.Text = "My Lights";
            // 
            // btnRenameLight
            // 
            this.btnRenameLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenameLight.Location = new System.Drawing.Point(27, 399);
            this.btnRenameLight.Name = "btnRenameLight";
            this.btnRenameLight.Size = new System.Drawing.Size(391, 65);
            this.btnRenameLight.TabIndex = 4;
            this.btnRenameLight.Text = "Rename Light";
            this.btnRenameLight.UseVisualStyleBackColor = true;
            this.btnRenameLight.Click += new System.EventHandler(this.btnRenameLight_Click);
            // 
            // txtAdditionalInformation
            // 
            this.txtAdditionalInformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdditionalInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdditionalInformation.Enabled = false;
            this.txtAdditionalInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdditionalInformation.Location = new System.Drawing.Point(27, 545);
            this.txtAdditionalInformation.Name = "txtAdditionalInformation";
            this.txtAdditionalInformation.Size = new System.Drawing.Size(391, 504);
            this.txtAdditionalInformation.TabIndex = 5;
            this.txtAdditionalInformation.Text = "";
            // 
            // lblAdditionalLightInformation
            // 
            this.lblAdditionalLightInformation.AutoSize = true;
            this.lblAdditionalLightInformation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdditionalLightInformation.Location = new System.Drawing.Point(27, 490);
            this.lblAdditionalLightInformation.Name = "lblAdditionalLightInformation";
            this.lblAdditionalLightInformation.Size = new System.Drawing.Size(317, 41);
            this.lblAdditionalLightInformation.TabIndex = 6;
            this.lblAdditionalLightInformation.Text = "Additional Information";
            // 
            // txtBridgeInfo
            // 
            this.txtBridgeInfo.AutoSize = true;
            this.txtBridgeInfo.Location = new System.Drawing.Point(27, 1175);
            this.txtBridgeInfo.Name = "txtBridgeInfo";
            this.txtBridgeInfo.Size = new System.Drawing.Size(0, 25);
            this.txtBridgeInfo.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Location = new System.Drawing.Point(438, 1056);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(414, 61);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect Hue Bridge";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbLightGroups
            // 
            this.lbLightGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLightGroups.FormattingEnabled = true;
            this.lbLightGroups.ItemHeight = 25;
            this.lbLightGroups.Location = new System.Drawing.Point(438, 73);
            this.lbLightGroups.Name = "lbLightGroups";
            this.lbLightGroups.ScrollAlwaysVisible = true;
            this.lbLightGroups.Size = new System.Drawing.Size(390, 304);
            this.lbLightGroups.TabIndex = 9;
            this.lbLightGroups.Click += new System.EventHandler(this.lbLightGroups_OnClick);
            this.lbLightGroups.DoubleClick += new System.EventHandler(this.lbLightGroups_MouseDoubleClick);
            // 
            // lblLightRooms
            // 
            this.lblLightRooms.AutoSize = true;
            this.lblLightRooms.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightRooms.Location = new System.Drawing.Point(438, 17);
            this.lblLightRooms.Name = "lblLightRooms";
            this.lblLightRooms.Size = new System.Drawing.Size(239, 41);
            this.lblLightRooms.TabIndex = 10;
            this.lblLightRooms.Text = "My Light Groups";
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.Location = new System.Drawing.Point(438, 399);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(390, 65);
            this.btnEditGroup.TabIndex = 11;
            this.btnEditGroup.Text = "Edit Group Name / Lights";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // txtQuickOptionsTitle
            // 
            this.txtQuickOptionsTitle.AutoSize = true;
            this.txtQuickOptionsTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuickOptionsTitle.Location = new System.Drawing.Point(438, 490);
            this.txtQuickOptionsTitle.Name = "txtQuickOptionsTitle";
            this.txtQuickOptionsTitle.Size = new System.Drawing.Size(116, 41);
            this.txtQuickOptionsTitle.TabIndex = 12;
            this.txtQuickOptionsTitle.Text = "Actions";
            // 
            // btnLightsOff
            // 
            this.btnLightsOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightsOff.Location = new System.Drawing.Point(647, 545);
            this.btnLightsOff.Name = "btnLightsOff";
            this.btnLightsOff.Size = new System.Drawing.Size(181, 65);
            this.btnLightsOff.TabIndex = 13;
            this.btnLightsOff.Text = "Turn Light(s) Off";
            this.btnLightsOff.UseVisualStyleBackColor = true;
            this.btnLightsOff.Click += new System.EventHandler(this.btnLightsOff_Click);
            // 
            // btnLightsOn
            // 
            this.btnLightsOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightsOn.Location = new System.Drawing.Point(438, 545);
            this.btnLightsOn.Name = "btnLightsOn";
            this.btnLightsOn.Size = new System.Drawing.Size(182, 65);
            this.btnLightsOn.TabIndex = 14;
            this.btnLightsOn.Text = "Turn Light(s) On";
            this.btnLightsOn.UseVisualStyleBackColor = true;
            this.btnLightsOn.Click += new System.EventHandler(this.btnLightsOn_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeColor.Location = new System.Drawing.Point(438, 625);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(390, 65);
            this.btnChangeColor.TabIndex = 15;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(438, 729);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Brightness";
            // 
            // tbBrightness
            // 
            this.tbBrightness.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbBrightness.Location = new System.Drawing.Point(438, 811);
            this.tbBrightness.Minimum = 1;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(390, 69);
            this.tbBrightness.TabIndex = 18;
            this.tbBrightness.Value = 1;
            this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(864, 1126);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlContinueSetup);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtBridgeInfo);
            this.Controls.Add(this.lblAdditionalLightInformation);
            this.Controls.Add(this.txtAdditionalInformation);
            this.Controls.Add(this.btnRenameLight);
            this.Controls.Add(this.lblLightListHeader);
            this.Controls.Add(this.lbLights);
            this.Controls.Add(this.btnLightsOn);
            this.Controls.Add(this.btnLightsOff);
            this.Controls.Add(this.txtQuickOptionsTitle);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.lblLightRooms);
            this.Controls.Add(this.lbLightGroups);
            this.Controls.Add(this.btnChangeColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlContinueSetup.ResumeLayout(false);
            this.pnlContinueSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteSetup;
        private System.Windows.Forms.Panel pnlContinueSetup;
        private System.Windows.Forms.Label lblContinueSetupPrompt;
        private System.Windows.Forms.Label lblSetupRequiredTitle;
        private System.Windows.Forms.ListBox lbLights;
        private System.Windows.Forms.Label lblLightListHeader;
        private System.Windows.Forms.Button btnRenameLight;
        private System.Windows.Forms.RichTextBox txtAdditionalInformation;
        private System.Windows.Forms.Label lblAdditionalLightInformation;
        private System.Windows.Forms.Label txtBridgeInfo;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox lbLightGroups;
        private System.Windows.Forms.Label lblLightRooms;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.Label txtQuickOptionsTitle;
        private System.Windows.Forms.Button btnLightsOff;
        private System.Windows.Forms.Button btnLightsOn;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog dlgChangeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbBrightness;
    }
}