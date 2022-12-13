
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
            this.btnCompleteSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteSetup.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompleteSetup.Location = new System.Drawing.Point(176, 370);
            this.btnCompleteSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompleteSetup.Name = "btnCompleteSetup";
            this.btnCompleteSetup.Size = new System.Drawing.Size(241, 44);
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
            this.pnlContinueSetup.Location = new System.Drawing.Point(1, -1);
            this.pnlContinueSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContinueSetup.Name = "pnlContinueSetup";
            this.pnlContinueSetup.Size = new System.Drawing.Size(35, 191);
            this.pnlContinueSetup.TabIndex = 1;
            this.pnlContinueSetup.Visible = false;
            // 
            // lblSetupRequiredTitle
            // 
            this.lblSetupRequiredTitle.AutoSize = true;
            this.lblSetupRequiredTitle.Font = new System.Drawing.Font("Cascadia Code", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupRequiredTitle.Location = new System.Drawing.Point(134, 200);
            this.lblSetupRequiredTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetupRequiredTitle.Name = "lblSetupRequiredTitle";
            this.lblSetupRequiredTitle.Size = new System.Drawing.Size(330, 50);
            this.lblSetupRequiredTitle.TabIndex = 2;
            this.lblSetupRequiredTitle.Text = "Setup Required";
            // 
            // lblContinueSetupPrompt
            // 
            this.lblContinueSetupPrompt.AutoSize = true;
            this.lblContinueSetupPrompt.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContinueSetupPrompt.Location = new System.Drawing.Point(40, 292);
            this.lblContinueSetupPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContinueSetupPrompt.MaximumSize = new System.Drawing.Size(525, 0);
            this.lblContinueSetupPrompt.Name = "lblContinueSetupPrompt";
            this.lblContinueSetupPrompt.Size = new System.Drawing.Size(504, 32);
            this.lblContinueSetupPrompt.TabIndex = 1;
            this.lblContinueSetupPrompt.Text = "Connection to a Philips Hue Bridge is required to use this application. Please Co" +
    "mplete the setup process before continuing.";
            this.lblContinueSetupPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLights
            // 
            this.lbLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLights.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLights.FormattingEnabled = true;
            this.lbLights.ItemHeight = 16;
            this.lbLights.Location = new System.Drawing.Point(19, 44);
            this.lbLights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbLights.Name = "lbLights";
            this.lbLights.ScrollAlwaysVisible = true;
            this.lbLights.Size = new System.Drawing.Size(275, 164);
            this.lbLights.TabIndex = 2;
            this.lbLights.Click += new System.EventHandler(this.lbLights_OnClick);
            this.lbLights.DoubleClick += new System.EventHandler(this.lbLights_MouseDoubleClick);
            // 
            // lblLightListHeader
            // 
            this.lblLightListHeader.AutoSize = true;
            this.lblLightListHeader.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightListHeader.Location = new System.Drawing.Point(19, 10);
            this.lblLightListHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLightListHeader.Name = "lblLightListHeader";
            this.lblLightListHeader.Size = new System.Drawing.Size(120, 27);
            this.lblLightListHeader.TabIndex = 3;
            this.lblLightListHeader.Text = "My Lights";
            // 
            // btnRenameLight
            // 
            this.btnRenameLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenameLight.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRenameLight.Location = new System.Drawing.Point(19, 239);
            this.btnRenameLight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRenameLight.Name = "btnRenameLight";
            this.btnRenameLight.Size = new System.Drawing.Size(274, 39);
            this.btnRenameLight.TabIndex = 4;
            this.btnRenameLight.Text = "Rename Light";
            this.btnRenameLight.UseVisualStyleBackColor = true;
            this.btnRenameLight.Click += new System.EventHandler(this.btnRenameLight_Click);
            // 
            // txtAdditionalInformation
            // 
            this.txtAdditionalInformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdditionalInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdditionalInformation.CausesValidation = false;
            this.txtAdditionalInformation.Enabled = false;
            this.txtAdditionalInformation.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdditionalInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdditionalInformation.Location = new System.Drawing.Point(19, 327);
            this.txtAdditionalInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdditionalInformation.Name = "txtAdditionalInformation";
            this.txtAdditionalInformation.ReadOnly = true;
            this.txtAdditionalInformation.Size = new System.Drawing.Size(274, 302);
            this.txtAdditionalInformation.TabIndex = 5;
            this.txtAdditionalInformation.Text = "";
            // 
            // lblAdditionalLightInformation
            // 
            this.lblAdditionalLightInformation.AutoSize = true;
            this.lblAdditionalLightInformation.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdditionalLightInformation.Location = new System.Drawing.Point(19, 294);
            this.lblAdditionalLightInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdditionalLightInformation.Name = "lblAdditionalLightInformation";
            this.lblAdditionalLightInformation.Size = new System.Drawing.Size(192, 27);
            this.lblAdditionalLightInformation.TabIndex = 6;
            this.lblAdditionalLightInformation.Text = "Additional Info";
            // 
            // txtBridgeInfo
            // 
            this.txtBridgeInfo.AutoSize = true;
            this.txtBridgeInfo.Location = new System.Drawing.Point(19, 705);
            this.txtBridgeInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBridgeInfo.Name = "txtBridgeInfo";
            this.txtBridgeInfo.Size = new System.Drawing.Size(0, 15);
            this.txtBridgeInfo.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.Location = new System.Drawing.Point(307, 634);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(290, 37);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect Hue Bridge";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbLightGroups
            // 
            this.lbLightGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLightGroups.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLightGroups.FormattingEnabled = true;
            this.lbLightGroups.ItemHeight = 16;
            this.lbLightGroups.Location = new System.Drawing.Point(307, 44);
            this.lbLightGroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbLightGroups.Name = "lbLightGroups";
            this.lbLightGroups.ScrollAlwaysVisible = true;
            this.lbLightGroups.Size = new System.Drawing.Size(274, 164);
            this.lbLightGroups.TabIndex = 9;
            this.lbLightGroups.Click += new System.EventHandler(this.lbLightGroups_OnClick);
            this.lbLightGroups.DoubleClick += new System.EventHandler(this.lbLightGroups_MouseDoubleClick);
            // 
            // lblLightRooms
            // 
            this.lblLightRooms.AutoSize = true;
            this.lblLightRooms.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightRooms.Location = new System.Drawing.Point(307, 10);
            this.lblLightRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLightRooms.Name = "lblLightRooms";
            this.lblLightRooms.Size = new System.Drawing.Size(192, 27);
            this.lblLightRooms.TabIndex = 10;
            this.lblLightRooms.Text = "My Light Groups";
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditGroup.Location = new System.Drawing.Point(307, 239);
            this.btnEditGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(273, 39);
            this.btnEditGroup.TabIndex = 11;
            this.btnEditGroup.Text = "Edit Group Name / Lights";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // txtQuickOptionsTitle
            // 
            this.txtQuickOptionsTitle.AutoSize = true;
            this.txtQuickOptionsTitle.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuickOptionsTitle.Location = new System.Drawing.Point(307, 294);
            this.txtQuickOptionsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtQuickOptionsTitle.Name = "txtQuickOptionsTitle";
            this.txtQuickOptionsTitle.Size = new System.Drawing.Size(96, 27);
            this.txtQuickOptionsTitle.TabIndex = 12;
            this.txtQuickOptionsTitle.Text = "Actions";
            // 
            // btnLightsOff
            // 
            this.btnLightsOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightsOff.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLightsOff.Location = new System.Drawing.Point(447, 327);
            this.btnLightsOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLightsOff.Name = "btnLightsOff";
            this.btnLightsOff.Size = new System.Drawing.Size(144, 39);
            this.btnLightsOff.TabIndex = 13;
            this.btnLightsOff.Text = "Turn Light(s) Off";
            this.btnLightsOff.UseVisualStyleBackColor = true;
            this.btnLightsOff.Click += new System.EventHandler(this.btnLightsOff_Click);
            // 
            // btnLightsOn
            // 
            this.btnLightsOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightsOn.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLightsOn.Location = new System.Drawing.Point(307, 327);
            this.btnLightsOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLightsOn.Name = "btnLightsOn";
            this.btnLightsOn.Size = new System.Drawing.Size(136, 39);
            this.btnLightsOn.TabIndex = 14;
            this.btnLightsOn.Text = "Turn Light(s) On";
            this.btnLightsOn.UseVisualStyleBackColor = true;
            this.btnLightsOn.Click += new System.EventHandler(this.btnLightsOn_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeColor.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeColor.Location = new System.Drawing.Point(307, 375);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(284, 39);
            this.btnChangeColor.TabIndex = 15;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(307, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Brightness";
            // 
            // tbBrightness
            // 
            this.tbBrightness.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbBrightness.Location = new System.Drawing.Point(307, 487);
            this.tbBrightness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBrightness.Minimum = 1;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(273, 45);
            this.tbBrightness.TabIndex = 18;
            this.tbBrightness.Value = 1;
            this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(612, 682);
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
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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