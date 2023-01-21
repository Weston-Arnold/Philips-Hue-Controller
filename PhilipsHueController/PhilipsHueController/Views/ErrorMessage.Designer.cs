
namespace PhilipsHueController.Forms
{
    partial class ErrorMessage
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
            this.txtErrorMessage = new System.Windows.Forms.Label();
            this.btnCloseErrorMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.AutoSize = true;
            this.txtErrorMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.txtErrorMessage.Location = new System.Drawing.Point(22, 13);
            this.txtErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtErrorMessage.MaximumSize = new System.Drawing.Size(210, 0);
            this.txtErrorMessage.MinimumSize = new System.Drawing.Size(350, 0);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(350, 19);
            this.txtErrorMessage.TabIndex = 0;
            this.txtErrorMessage.Text = " ";
            this.txtErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseErrorMessage
            // 
            this.btnCloseErrorMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseErrorMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseErrorMessage.Location = new System.Drawing.Point(121, 67);
            this.btnCloseErrorMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseErrorMessage.Name = "btnCloseErrorMessage";
            this.btnCloseErrorMessage.Size = new System.Drawing.Size(153, 29);
            this.btnCloseErrorMessage.TabIndex = 1;
            this.btnCloseErrorMessage.Text = "Close";
            this.btnCloseErrorMessage.UseVisualStyleBackColor = true;
            this.btnCloseErrorMessage.Click += new System.EventHandler(this.btnCloseErrorMessage_Click);
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 110);
            this.Controls.Add(this.btnCloseErrorMessage);
            this.Controls.Add(this.txtErrorMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtErrorMessage;
        private System.Windows.Forms.Button btnCloseErrorMessage;
    }
}