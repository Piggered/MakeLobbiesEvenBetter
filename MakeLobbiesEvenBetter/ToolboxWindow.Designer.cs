namespace MakeLobbiesEvenBetter
{
    partial class ToolboxWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolboxWindow));
            this.forceReload = new System.Windows.Forms.Button();
            this.hideProfiles = new System.Windows.Forms.Button();
            this.closeToolbox = new System.Windows.Forms.Button();
            this.showProfilePictures = new System.Windows.Forms.Button();
            this.showProfileLinks = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.killDbd = new System.Windows.Forms.Button();
            this.notifyOnNotedHost = new System.Windows.Forms.Button();
            this.aboutThisProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forceReload
            // 
            this.forceReload.Location = new System.Drawing.Point(12, 12);
            this.forceReload.Name = "forceReload";
            this.forceReload.Size = new System.Drawing.Size(216, 27);
            this.forceReload.TabIndex = 1;
            this.forceReload.Text = "Force Reload";
            this.toolTip.SetToolTip(this.forceReload, "Forcibly reloads the stream reader by entirely re-reading the log file.\r\nUse this" +
        " if the program is not updating profiles properly.");
            this.forceReload.UseVisualStyleBackColor = true;
            this.forceReload.Click += new System.EventHandler(this.ForceReload_Click);
            // 
            // hideProfiles
            // 
            this.hideProfiles.Location = new System.Drawing.Point(12, 144);
            this.hideProfiles.Name = "hideProfiles";
            this.hideProfiles.Size = new System.Drawing.Size(216, 27);
            this.hideProfiles.TabIndex = 4;
            this.hideProfiles.Text = "Hide Profiles: OFF";
            this.toolTip.SetToolTip(this.hideProfiles, "Should the program hide Steam profiles?");
            this.hideProfiles.UseVisualStyleBackColor = true;
            this.hideProfiles.Click += new System.EventHandler(this.HideProfiles_Click);
            // 
            // closeToolbox
            // 
            this.closeToolbox.Location = new System.Drawing.Point(12, 309);
            this.closeToolbox.Name = "closeToolbox";
            this.closeToolbox.Size = new System.Drawing.Size(216, 27);
            this.closeToolbox.TabIndex = 0;
            this.closeToolbox.Text = "Close Toolbox";
            this.closeToolbox.UseVisualStyleBackColor = true;
            this.closeToolbox.Click += new System.EventHandler(this.CloseToolbox_Click);
            // 
            // showProfilePictures
            // 
            this.showProfilePictures.Location = new System.Drawing.Point(12, 177);
            this.showProfilePictures.Name = "showProfilePictures";
            this.showProfilePictures.Size = new System.Drawing.Size(216, 27);
            this.showProfilePictures.TabIndex = 5;
            this.showProfilePictures.Text = "Show Profile Pictures: ON";
            this.toolTip.SetToolTip(this.showProfilePictures, "Should the program show Steam profile pictures?");
            this.showProfilePictures.UseVisualStyleBackColor = true;
            this.showProfilePictures.Click += new System.EventHandler(this.ShowProfilePictures_Click);
            // 
            // showProfileLinks
            // 
            this.showProfileLinks.Location = new System.Drawing.Point(12, 210);
            this.showProfileLinks.Name = "showProfileLinks";
            this.showProfileLinks.Size = new System.Drawing.Size(216, 27);
            this.showProfileLinks.TabIndex = 6;
            this.showProfileLinks.Text = "Show Profile Links: ON";
            this.toolTip.SetToolTip(this.showProfileLinks, "Should the program allow you to open Steam profiles?");
            this.showProfileLinks.UseVisualStyleBackColor = true;
            this.showProfileLinks.Click += new System.EventHandler(this.ShowProfileLinks_Click);
            // 
            // killDbd
            // 
            this.killDbd.Location = new System.Drawing.Point(12, 45);
            this.killDbd.Name = "killDbd";
            this.killDbd.Size = new System.Drawing.Size(216, 27);
            this.killDbd.TabIndex = 2;
            this.killDbd.Text = "Kill Dead by Daylight";
            this.toolTip.SetToolTip(this.killDbd, "Forcibly closes the Dead by Daylight process if running.");
            this.killDbd.UseVisualStyleBackColor = true;
            this.killDbd.Click += new System.EventHandler(this.KillDbd_Click);
            // 
            // notifyOnNotedHost
            // 
            this.notifyOnNotedHost.Location = new System.Drawing.Point(12, 243);
            this.notifyOnNotedHost.Name = "notifyOnNotedHost";
            this.notifyOnNotedHost.Size = new System.Drawing.Size(216, 27);
            this.notifyOnNotedHost.TabIndex = 7;
            this.notifyOnNotedHost.Text = "Notify on Noted Host: ON";
            this.toolTip.SetToolTip(this.notifyOnNotedHost, "Should the program notify you whenever you encouter a host that you\'ve noted?");
            this.notifyOnNotedHost.UseVisualStyleBackColor = true;
            this.notifyOnNotedHost.Click += new System.EventHandler(this.NotifyOnNotedHost_Click);
            // 
            // aboutThisProgram
            // 
            this.aboutThisProgram.Location = new System.Drawing.Point(12, 78);
            this.aboutThisProgram.Name = "aboutThisProgram";
            this.aboutThisProgram.Size = new System.Drawing.Size(216, 27);
            this.aboutThisProgram.TabIndex = 3;
            this.aboutThisProgram.Text = "About this Program";
            this.toolTip.SetToolTip(this.aboutThisProgram, "Should the program hide Steam profiles?");
            this.aboutThisProgram.UseVisualStyleBackColor = true;
            this.aboutThisProgram.Click += new System.EventHandler(this.AboutThisProgram_Click);
            // 
            // ToolboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 345);
            this.Controls.Add(this.aboutThisProgram);
            this.Controls.Add(this.killDbd);
            this.Controls.Add(this.notifyOnNotedHost);
            this.Controls.Add(this.showProfileLinks);
            this.Controls.Add(this.showProfilePictures);
            this.Controls.Add(this.closeToolbox);
            this.Controls.Add(this.hideProfiles);
            this.Controls.Add(this.forceReload);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolboxWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toolbox";
            this.Load += new System.EventHandler(this.ToolboxWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forceReload;
        private System.Windows.Forms.Button hideProfiles;
        private System.Windows.Forms.Button closeToolbox;
        private System.Windows.Forms.Button showProfilePictures;
        private System.Windows.Forms.Button showProfileLinks;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button notifyOnNotedHost;
        private System.Windows.Forms.Button killDbd;
        private System.Windows.Forms.Button aboutThisProgram;
    }
}