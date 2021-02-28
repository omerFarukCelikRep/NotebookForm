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
    public partial class frmAdmin : Form
    {
        UserManager userManager;
        public frmAdmin()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            FillList();
        }


        private void lvUsers_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kullanıcıyı Aktif Hale Getirmek İstiyor Musunuz?", "User State", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                userManager.ChangeState(lvUsers.SelectedItems[0].SubItems[3].Text);
                FillList();
            }
        }
        private void FillList()
        {
            lvUsers.Items.Clear();
            
            foreach (User user in userManager.GetInactiveUsers())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(user.FirstName);
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.UserName);
                lvi.SubItems.Add(user.IsActive ? "Aktif" : "Pasif");
                lvi.Tag = user;
                lvUsers.Items.Add(lvi);
            }
        }
    }
}
