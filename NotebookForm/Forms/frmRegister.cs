using NotebookForm.Business.Concrete;
using NotebookForm.DataAccess.Concrete.EntityFramework;
using NotebookForm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookForm.Forms
{
    public partial class frmRegister : Form
    {
        UserManager userManager;
        PasswordManager passwordManager;
        public frmRegister()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
            passwordManager = new PasswordManager(new EfPasswordDal());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User tmpUser = new User
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    CreatedDate = DateTime.Now,
                    IsActive = false,
                    Role = UserRole.User,
                    UserName = txtUserName.Text
                };
                userManager.Add(tmpUser);

                Password password = new Password
                {
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Text = txtPassword.Text,
                    UserID = userManager.GetUserID(txtUserName.Text)
                };
                passwordManager.Add(password);

                if (!userManager.UserNameCheck(txtUserName.Text))
                {
                    MessageBox.Show("Kayıt İşleminiz Gerçekleşmiştir.");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                lblPwd.Text = "Şifre Uyuşmuyor";
            }
            else
            {
                lblPwd.Text = string.Empty;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (userManager.UserNameCheck(txtUserName.Text))
            {
                lblUserNameCheck.Text = "Kullanıcı Adı Önceden Alınmıştır";
            }
            else
            {
                lblUserNameCheck.Text = "Kullanıcı Adı Uygun";
            }
        }
    }
}
