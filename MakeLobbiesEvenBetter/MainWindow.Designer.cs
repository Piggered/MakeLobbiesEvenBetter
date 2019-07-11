namespace MakeLobbiesEvenBetter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.profileName = new System.Windows.Forms.Label();
            this.profileRealName = new System.Windows.Forms.Label();
            this.groupBoxNotes = new System.Windows.Forms.GroupBox();
            this.noteNotice = new System.Windows.Forms.Label();
            this.saveNote = new System.Windows.Forms.Button();
            this.cancelNote = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.viewProfileBrowser = new System.Windows.Forms.Button();
            this.viewProfileSteam = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.profileLocation = new System.Windows.Forms.Label();
            this.labelLooking = new System.Windows.Forms.Label();
            this.toolboxButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.textBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.textBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(120, 13);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(122, 24);
            this.profileName.TabIndex = 1;
            this.profileName.Text = "Placeholder";
            // 
            // profileRealName
            // 
            this.profileRealName.AutoSize = true;
            this.profileRealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileRealName.Location = new System.Drawing.Point(121, 37);
            this.profileRealName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profileRealName.Name = "profileRealName";
            this.profileRealName.Size = new System.Drawing.Size(86, 18);
            this.profileRealName.TabIndex = 2;
            this.profileRealName.Text = "Placeholder";
            // 
            // groupBoxNotes
            // 
            this.groupBoxNotes.Controls.Add(this.noteNotice);
            this.groupBoxNotes.Controls.Add(this.saveNote);
            this.groupBoxNotes.Controls.Add(this.cancelNote);
            this.groupBoxNotes.Controls.Add(this.textBoxNotes);
            this.groupBoxNotes.Location = new System.Drawing.Point(12, 121);
            this.groupBoxNotes.Name = "groupBoxNotes";
            this.groupBoxNotes.Size = new System.Drawing.Size(566, 288);
            this.groupBoxNotes.TabIndex = 4;
            this.groupBoxNotes.TabStop = false;
            this.groupBoxNotes.Text = "Profile Notes";
            // 
            // noteNotice
            // 
            this.noteNotice.AutoSize = true;
            this.noteNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNotice.Location = new System.Drawing.Point(6, 263);
            this.noteNotice.Name = "noteNotice";
            this.noteNotice.Size = new System.Drawing.Size(296, 13);
            this.noteNotice.TabIndex = 3;
            this.noteNotice.Text = "This profile will remain on screen while you\'re editing the note.";
            this.noteNotice.Visible = false;
            // 
            // saveNote
            // 
            this.saveNote.Enabled = false;
            this.saveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNote.Location = new System.Drawing.Point(401, 257);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(75, 25);
            this.saveNote.TabIndex = 2;
            this.saveNote.TabStop = false;
            this.saveNote.Text = "Save";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.SaveNote_Click);
            // 
            // cancelNote
            // 
            this.cancelNote.Enabled = false;
            this.cancelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelNote.Location = new System.Drawing.Point(482, 257);
            this.cancelNote.Name = "cancelNote";
            this.cancelNote.Size = new System.Drawing.Size(75, 25);
            this.cancelNote.TabIndex = 1;
            this.cancelNote.TabStop = false;
            this.cancelNote.Text = "Cancel";
            this.cancelNote.UseVisualStyleBackColor = true;
            this.cancelNote.Click += new System.EventHandler(this.CancelNote_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.AcceptsReturn = true;
            this.textBoxNotes.AcceptsTab = true;
            this.textBoxNotes.ContextMenuStrip = this.textBoxMenu;
            this.textBoxNotes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.Location = new System.Drawing.Point(6, 20);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(552, 231);
            this.textBoxNotes.TabIndex = 0;
            this.textBoxNotes.TextChanged += new System.EventHandler(this.TextBoxNotes_TextChanged);
            this.textBoxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNotes_KeyDown);
            // 
            // viewProfileBrowser
            // 
            this.viewProfileBrowser.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileBrowser.Image")));
            this.viewProfileBrowser.Location = new System.Drawing.Point(506, 89);
            this.viewProfileBrowser.Name = "viewProfileBrowser";
            this.viewProfileBrowser.Size = new System.Drawing.Size(30, 30);
            this.viewProfileBrowser.TabIndex = 5;
            this.viewProfileBrowser.TabStop = false;
            this.toolTip.SetToolTip(this.viewProfileBrowser, "Open profile on your web browser");
            this.viewProfileBrowser.UseVisualStyleBackColor = true;
            this.viewProfileBrowser.Click += new System.EventHandler(this.ViewProfileBrowser_Click);
            // 
            // viewProfileSteam
            // 
            this.viewProfileSteam.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileSteam.Image")));
            this.viewProfileSteam.Location = new System.Drawing.Point(542, 89);
            this.viewProfileSteam.Name = "viewProfileSteam";
            this.viewProfileSteam.Size = new System.Drawing.Size(30, 30);
            this.viewProfileSteam.TabIndex = 7;
            this.viewProfileSteam.TabStop = false;
            this.toolTip.SetToolTip(this.viewProfileSteam, "Open profile on your Steam client");
            this.viewProfileSteam.UseVisualStyleBackColor = true;
            this.viewProfileSteam.Click += new System.EventHandler(this.ViewProfileSteam_Click);
            // 
            // profileLocation
            // 
            this.profileLocation.AutoSize = true;
            this.profileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLocation.Location = new System.Drawing.Point(121, 97);
            this.profileLocation.Name = "profileLocation";
            this.profileLocation.Size = new System.Drawing.Size(73, 15);
            this.profileLocation.TabIndex = 9;
            this.profileLocation.Text = "Placeholder";
            // 
            // labelLooking
            // 
            this.labelLooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLooking.Location = new System.Drawing.Point(0, 0);
            this.labelLooking.Name = "labelLooking";
            this.labelLooking.Size = new System.Drawing.Size(590, 421);
            this.labelLooking.TabIndex = 10;
            this.labelLooking.Text = "Fetching Lobby Host...";
            this.labelLooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLooking.Visible = false;
            // 
            // toolboxButton
            // 
            this.toolboxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolboxButton.Location = new System.Drawing.Point(506, 11);
            this.toolboxButton.Name = "toolboxButton";
            this.toolboxButton.Size = new System.Drawing.Size(65, 25);
            this.toolboxButton.TabIndex = 11;
            this.toolboxButton.TabStop = false;
            this.toolboxButton.Text = "Toolbox";
            this.toolboxButton.UseVisualStyleBackColor = true;
            this.toolboxButton.Click += new System.EventHandler(this.ToolboxButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePicture.ImageLocation = "";
            this.profilePicture.Location = new System.Drawing.Point(14, 13);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(100, 100);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 8;
            this.profilePicture.TabStop = false;
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem});
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.textBoxMenu.ShowCheckMargin = true;
            this.textBoxMenu.ShowImageMargin = false;
            this.textBoxMenu.Size = new System.Drawing.Size(128, 148);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(99, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(99, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 421);
            this.Controls.Add(this.toolboxButton);
            this.Controls.Add(this.profileLocation);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.viewProfileSteam);
            this.Controls.Add(this.viewProfileBrowser);
            this.Controls.Add(this.groupBoxNotes);
            this.Controls.Add(this.profileRealName);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.labelLooking);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Lobbies Even Better";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBoxNotes.ResumeLayout(false);
            this.groupBoxNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.textBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button viewProfileBrowser;
        private System.Windows.Forms.Button viewProfileSteam;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelLooking;
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.Button cancelNote;
        private System.Windows.Forms.Label noteNotice;
        private System.Windows.Forms.Button toolboxButton;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Label profileRealName;
        private System.Windows.Forms.Label profileLocation;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.ContextMenuStrip textBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    }
}

