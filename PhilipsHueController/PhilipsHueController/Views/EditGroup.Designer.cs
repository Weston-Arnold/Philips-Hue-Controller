
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
            this.lblRoomName = new System.Windows.Forms.Label();
            this.clbLights = new System.Windows.Forms.CheckedListBox();
            this.lblLightsInRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChange.Location = new System.Drawing.Point(101, 335);
            this.btnSaveChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(136, 30);
            this.btnSaveChange.TabIndex = 3;
            this.btnSaveChange.Text = "Save Changes";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtRename
            // 
            this.txtRename.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRename.Location = new System.Drawing.Point(53, 47);
            this.txtRename.Margin = new System.Windows.Forms.Padding(2);
            this.txtRename.MaxLength = 50;
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(239, 27);
            this.txtRename.TabIndex = 2;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.Location = new System.Drawing.Point(53, 26);
            this.lblRoomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(88, 19);
            this.lblRoomName.TabIndex = 4;
            this.lblRoomName.Text = "Room Name";
            // 
            // clbLights
            // 
            this.clbLights.CheckOnClick = true;
            this.clbLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbLights.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbLights.FormattingEnabled = true;
            this.clbLights.Location = new System.Drawing.Point(53, 116);
            this.clbLights.Margin = new System.Windows.Forms.Padding(2);
            this.clbLights.Name = "clbLights";
            this.clbLights.Size = new System.Drawing.Size(239, 202);
            this.clbLights.TabIndex = 5;
            // 
            // lblLightsInRoom
            // 
            this.lblLightsInRoom.AutoSize = true;
            this.lblLightsInRoom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightsInRoom.Location = new System.Drawing.Point(53, 95);
            this.lblLightsInRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLightsInRoom.Name = "lblLightsInRoom";
            this.lblLightsInRoom.Size = new System.Drawing.Size(48, 19);
            this.lblLightsInRoom.TabIndex = 7;
            this.lblLightsInRoom.Text = "Lights";
            // 
            // EditGroup
            // 
            this.AcceptButton = this.btnSaveChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 391);
            this.Controls.Add(this.lblLightsInRoom);
            this.Controls.Add(this.clbLights);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.txtRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Room";
            this.Load += new System.EventHandler(this.EditGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.CheckedListBox clbLights;
        private System.Windows.Forms.Label lblLightsInRoom;
    }
}