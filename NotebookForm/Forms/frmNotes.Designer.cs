
namespace NotebookForm.Forms
{
    partial class frmNotes
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblChangePassword = new System.Windows.Forms.LinkLabel();
            this.txtNoteContent = new System.Windows.Forms.TextBox();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.lbNoteTitles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(403, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(9, 330);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(153, 20);
            this.lblChangePassword.TabIndex = 10;
            this.lblChangePassword.TabStop = true;
            this.lblChangePassword.Text = "Change Password";
            this.lblChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangePassword_LinkClicked);
            // 
            // txtNoteContent
            // 
            this.txtNoteContent.Location = new System.Drawing.Point(183, 91);
            this.txtNoteContent.Multiline = true;
            this.txtNoteContent.Name = "txtNoteContent";
            this.txtNoteContent.Size = new System.Drawing.Size(248, 223);
            this.txtNoteContent.TabIndex = 8;
            this.txtNoteContent.Visible = false;
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(183, 59);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(248, 26);
            this.txtNoteTitle.TabIndex = 9;
            this.txtNoteTitle.Visible = false;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(310, 10);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(121, 43);
            this.btnAddNote.TabIndex = 6;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(183, 10);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(121, 43);
            this.btnDeleteNote.TabIndex = 7;
            this.btnDeleteNote.Text = "Delete Note";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // lbNoteTitles
            // 
            this.lbNoteTitles.ContextMenuStrip = this.contextMenuStrip1;
            this.lbNoteTitles.FormattingEnabled = true;
            this.lbNoteTitles.ItemHeight = 20;
            this.lbNoteTitles.Location = new System.Drawing.Point(9, 10);
            this.lbNoteTitles.Name = "lbNoteTitles";
            this.lbNoteTitles.Size = new System.Drawing.Size(168, 304);
            this.lbNoteTitles.TabIndex = 5;
            this.lbNoteTitles.DoubleClick += new System.EventHandler(this.lbNoteTitles_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
            // 
            // frmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 369);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.txtNoteContent);
            this.Controls.Add(this.txtNoteTitle);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.lbNoteTitles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNotes";
            this.Text = "frmNotes";
            this.Load += new System.EventHandler(this.frmNotes_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lblChangePassword;
        private System.Windows.Forms.TextBox txtNoteContent;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.ListBox lbNoteTitles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
    }
}