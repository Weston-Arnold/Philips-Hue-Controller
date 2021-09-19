
namespace PhilipsHueController.Forms
{
    partial class RenameGroup
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
            this.SuspendLayout();
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(225, 99);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(195, 50);
            this.btnSaveChange.TabIndex = 3;
            this.btnSaveChange.Text = "Save Change";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(77, 46);
            this.txtRename.MaxLength = 50;
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(501, 31);
            this.txtRename.TabIndex = 2;
            // 
            // RenameGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 198);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.txtRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RenameGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txtRename;
    }
}