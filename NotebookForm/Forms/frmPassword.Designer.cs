
namespace NotebookForm.Forms
{
    partial class frmPassword
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
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblNewPasswordAgain = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(209, 133);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(186, 26);
            this.txtNewPasswordAgain.TabIndex = 32;
            // 
            // lblNewPasswordAgain
            // 
            this.lblNewPasswordAgain.AutoSize = true;
            this.lblNewPasswordAgain.Location = new System.Drawing.Point(12, 136);
            this.lblNewPasswordAgain.Name = "lblNewPasswordAgain";
            this.lblNewPasswordAgain.Size = new System.Drawing.Size(191, 20);
            this.lblNewPasswordAgain.TabIndex = 31;
            this.lblNewPasswordAgain.Text = "New Password Again : ";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(209, 77);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(186, 26);
            this.txtNewPassword.TabIndex = 30;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 80);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(140, 20);
            this.lblNewPassword.TabIndex = 29;
            this.lblNewPassword.Text = "New Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(207, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 26);
            this.txtPassword.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 24);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 20);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password : ";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(209, 178);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(186, 38);
            this.btnChangePassword.TabIndex = 22;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 248);
            this.Controls.Add(this.txtNewPasswordAgain);
            this.Controls.Add(this.lblNewPasswordAgain);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPassword";
            this.Text = "frmPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Label lblNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnChangePassword;
    }
}