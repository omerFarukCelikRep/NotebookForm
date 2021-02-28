
namespace NotebookForm.Forms
{
    partial class frmRegister
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
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUserNameCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Location = new System.Drawing.Point(183, 268);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(168, 26);
            this.txtPasswordAgain.TabIndex = 21;
            this.txtPasswordAgain.TextChanged += new System.EventHandler(this.txtPasswordAgain_TextChanged);
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Location = new System.Drawing.Point(25, 271);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(152, 20);
            this.lblPasswordAgain.TabIndex = 20;
            this.lblPasswordAgain.Text = "Password Again : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 208);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 26);
            this.txtPassword.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 20);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password : ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(183, 148);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 26);
            this.txtUserName.TabIndex = 17;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(25, 151);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 20);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "User Name : ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(181, 88);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 26);
            this.txtLastName.TabIndex = 15;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(25, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(110, 20);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(181, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(170, 26);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(25, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(111, 20);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name : ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(183, 331);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 38);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(179, 297);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 20);
            this.lblPwd.TabIndex = 22;
            // 
            // lblUserNameCheck
            // 
            this.lblUserNameCheck.AutoSize = true;
            this.lblUserNameCheck.Location = new System.Drawing.Point(179, 177);
            this.lblUserNameCheck.Name = "lblUserNameCheck";
            this.lblUserNameCheck.Size = new System.Drawing.Size(0, 20);
            this.lblUserNameCheck.TabIndex = 23;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 381);
            this.Controls.Add(this.lblUserNameCheck);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.lblPasswordAgain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.Label lblPasswordAgain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUserNameCheck;
    }
}