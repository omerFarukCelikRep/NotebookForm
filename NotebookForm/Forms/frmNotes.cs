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
    public partial class frmNotes : Form
    {
        int id;
        UserManager userManager;
        NoteManager noteManager;
        public frmNotes(int userID)
        {
            InitializeComponent();
            id = userID;
            userManager = new UserManager(new EfUserDal());
            noteManager = new NoteManager(new EfNoteDal());
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            txtNoteTitle.Visible = true;
            txtNoteContent.Visible = true;
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            lbNoteTitles.BeginUpdate();
            lbNoteTitles.DataSource = noteManager.GetNotesByUser(id);
            lbNoteTitles.DisplayMember = "Title";
            lbNoteTitles.ValueMember = "NoteID";
            lbNoteTitles.EndUpdate();
        }

        private void lblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassword frmPassword = new frmPassword(id);
            frmPassword.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Note note = new Note
                {
                    Content = txtNoteContent.Text,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Title = txtNoteTitle.Text,
                    UserID = id
                };
                noteManager.Add(note);
                ClearTextBoxes();
                MessageBox.Show("Not Eklenmiştir");

                FillList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            txtNoteTitle.Text = string.Empty;
            txtNoteContent.Text = string.Empty;
            txtNoteTitle.Visible = false;
            txtNoteContent.Visible = false;
        }

        private void lbNoteTitles_DoubleClick(object sender, EventArgs e)
        {
            Note tmpNote = noteManager.GetAll().SingleOrDefault(n => n.NoteID == (int)lbNoteTitles.SelectedValue);
            txtNoteTitle.Text = tmpNote.Title;
            txtNoteContent.Text = tmpNote.Content;
            txtNoteTitle.Visible = true;
            txtNoteContent.Visible = true;

        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            Note tmpNote = noteManager.GetAll().SingleOrDefault(n => n.NoteID == (int)lbNoteTitles.SelectedValue);
            noteManager.Delete(tmpNote);
            MessageBox.Show("Not Başarıyla Silinmiştir");
            FillList();
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note tmpNote = noteManager.GetAll().SingleOrDefault(n => n.NoteID == (int)lbNoteTitles.SelectedValue);
            txtNoteTitle.Text = tmpNote.Title;
            txtNoteContent.Text = tmpNote.Content;
        }
    }
}
