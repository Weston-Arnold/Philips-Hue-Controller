
namespace PhilipsHueController.Forms
{
    partial class EditGroup
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
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.clbLights = new System.Windows.Forms.CheckedListBox();
            this.lblLightsInGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(144, 558);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(195, 50);
            this.btnSaveChange.TabIndex = 3;
            this.btnSaveChange.Text = "Save Change";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(76, 78);
            this.txtRename.MaxLength = 50;
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(340, 31);
            this.txtRename.TabIndex = 2;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(76, 50);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(114, 25);
            this.lblGroupName.TabIndex = 4;
            this.lblGroupName.Text = "Group Name";
            // 
            // clbLights
            // 
            this.clbLights.FormattingEnabled = true;
            this.clbLights.Location = new System.Drawing.Point(76, 175);
            this.clbLights.Name = "clbLights";
            this.clbLights.Size = new System.Drawing.Size(340, 368);
            this.clbLights.TabIndex = 5;
            // 
            // lblLightsInGroup
            // 
            this.lblLightsInGroup.AutoSize = true;
            this.lblLightsInGroup.Location = new System.Drawing.Point(76, 147);
            this.lblLightsInGroup.Name = "lblLightsInGroup";
            this.lblLightsInGroup.Size = new System.Drawing.Size(133, 25);
            this.lblLightsInGroup.TabIndex = 7;
            this.lblLightsInGroup.Text = "Lights in Group";
            // 
            // EditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 651);
            this.Controls.Add(this.lblLightsInGroup);
            this.Controls.Add(this.clbLights);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.txtRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.EditGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.CheckedListBox clbLights;
        private System.Windows.Forms.Label lblLightsInGroup;
    }
}