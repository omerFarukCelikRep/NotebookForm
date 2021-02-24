using NotebookForm.Business.Concrete;
using NotebookForm.DataAccess.Concrete.EntityFramework;
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
        public frmLogin()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userManager.LoginCheck(txtUserName.Text, txtPassword.Text))
            {
                frmAdmin frmAdmin = new frmAdmin();
                frmAdmin.ShowDialog();

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            userManager.GetAll();
        }
    }
}
