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
    public partial class frmPassword : Form
    {
        int id;
        PasswordManager passwordManager;
        public frmPassword(int userID)
        {
            InitializeComponent();
            id = userID;
            passwordManager = new PasswordManager(new EfPasswordDal());
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSame = txtNewPassword.Text == txtNewPasswordAgain.Text ? true : false;
                if (passwordManager.CheckLastPasswords(id, txtNewPassword.Text) && isSame)
                {
                    Password oldPassword = passwordManager.GetAll().Last(p => p.UserID == id);
                    oldPassword.IsActive = false;
                    passwordManager.Update(oldPassword);
                    passwordManager.Add(new Password { CreatedDate = DateTime.Now, IsActive = true, Text = txtNewPassword.Text, UserID = id });

                    MessageBox.Show("Şifreniz Değiştirilmiştir.");
                    this.Close();
                }
                else
                {
                    throw new Exception("Girdiğiniz Şifre Son 3 Şifreniz İle Aynıdır Lütfen Farklı Bir Şifre Giriniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
