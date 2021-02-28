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
    public partial class frmLogin : Form
    {
        UserManager userManager;
        PasswordManager passwordManager;
        public frmLogin()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
            passwordManager = new PasswordManager(new EfPasswordDal());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (userManager.IsAdmin(txtUserName.Text, txtPassword.Text))
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.ShowDialog();
                }
                else if (userManager.LoginCheck(txtUserName.Text, txtPassword.Text))
                {
                    frmNotes frmNotes = new frmNotes(userManager.GetUserID(txtUserName.Text));
                    frmNotes.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
    }
}
