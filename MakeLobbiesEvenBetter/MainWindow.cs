using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;
using Newtonsoft.Json;

namespace MakeLobbiesEvenBetter
{
    public partial class MainWindow : Form
    {
        private bool _isEditingNote = false;

        private Settings settings;

        private SteamUser _activeProfile;
        private SteamUser _viewingProfile;

        private LogReader _logReader;

        private readonly string HIDDEN_PFP = "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/fe/fef49e7fa7e1997310d705b2a6158ff8dc1cdfeb_full.jpg";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Form Interaction
        private void MainWindow_Load(object sender, EventArgs e)
        {
            settings = Settings.LoadSettings();

            SetProfileVisible(false);

            if (settings.HideProfiles)
            {
                HideProfileView();
            }

            if (!settings.ShowProfilePictures)
            {
                profileName.Location = new Point(20, 13);
                profileRealName.Location = new Point(21, 37);
                profileLocation.Location = new Point(21, 97);
            }

            _logReader = new LogReader();
            _logReader.NewHost += OnNewHost;
        }

        private void ViewProfileBrowser_Click(object sender, EventArgs e)
        {
            if (_activeProfile != null)
            {
                Process.Start("https://steamcommunity.com/profiles/" + _viewingProfile.SteamID64);
            }

            labelLooking.Focus();
        }

        private void ViewProfileSteam_Click(object sender, EventArgs e)
        {
            if (_activeProfile != null)
            {
                Process.Start("steam://openurl/https://steamcommunity.com/profiles/" + _viewingProfile.SteamID64);
            }

            labelLooking.Focus();
        }

        private void TextBoxNotes_TextChanged(object sender, EventArgs e)
        {
            SetEditingNote(NoteManager.GetNote(_viewingProfile.SteamID64) != textBoxNotes.Text, false);
        }

        private void SaveNote_Click(object sender, EventArgs e)
        {
            NoteManager.SaveNote(_viewingProfile.SteamID64, textBoxNotes.Text);

            SetEditingNote(false);
        }

        private void CancelNote_Click(object sender, EventArgs e)
        {
            textBoxNotes.Text = NoteManager.GetNote(_viewingProfile.SteamID64);

            SetEditingNote(false);
        }

        private void TextBoxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                e.SuppressKeyPress = true;
                SaveNote_Click(this, null);
            }
        }

        private void ToolboxButton_Click(object sender, EventArgs e)
        {
            ToolboxWindow toolbox = new ToolboxWindow(this, _logReader, settings);

            labelLooking.Focus();

            toolbox.ShowDialog();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.SelectedText = string.Empty;
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.SelectAll();
        }

        // Public Methods
        public void SetActiveProfile(SteamUser user)
        {
            _activeProfile = user;

            SetProfileVisible(true);

            if (!_isEditingNote)
            {
                SetViewingProfile();
            }
        }

        public SteamUser GetActiveProfile()
        {
            return _activeProfile;
        }

        public void ToggleHidingProfiles()
        {
            settings.SetHideProfiles(!settings.HideProfiles);

            if (settings.HideProfiles)
            {
                HideProfileView();
            }
            else
            {
                SetViewingProfile(false, true);
            }
        }

        public void ToggleShowProfilePictures()
        {
            settings.SetShowProfilePictures(!settings.ShowProfilePictures);

            if (settings.ShowProfilePictures)
            {
                profilePicture.Visible = true;

                profileName.Location = new Point(120, 13);
                profileRealName.Location = new Point(121, 37);
                profileLocation.Location = new Point(121, 97);
            }
            else
            {
                profilePicture.Visible = false;

                profileName.Location = new Point(10, 13);
                profileRealName.Location = new Point(11, 37);
                profileLocation.Location = new Point(11, 97);
            }
        }

        public void ToggleShowProfileLinks()
        {
            settings.SetShowProfileLinks(!settings.ShowProfileLinks);

            if (settings.ShowProfileLinks)
            {
                viewProfileBrowser.Visible = true;
                viewProfileSteam.Visible = true;
            }
            else
            {
                viewProfileBrowser.Visible = false;
                viewProfileSteam.Visible = false;
            }
        }

        // Private Methods
        private void HideProfileView()
        {
            profileRealName.ForeColor = Color.Red;

            profileName.Text = "?????";
            profileRealName.Text = "You are hiding profiles.";
            profileLocation.Text = string.Empty;
            profilePicture.ImageLocation = HIDDEN_PFP;
        }

        private void SetProfileVisible(bool viewing)
        {
            groupBoxNotes.Visible = viewing;

            profilePicture.Visible = viewing && settings.ShowProfilePictures;

            profileName.Visible = viewing;
            profileRealName.Visible = viewing;
            profileLocation.Visible = viewing;

            viewProfileBrowser.Visible = viewing && settings.ShowProfileLinks;
            viewProfileSteam.Visible = viewing && settings.ShowProfileLinks;
            
            labelLooking.Visible = !viewing;
        }

        private void SetEditingNote(bool editing, bool setViewing = true)
        {
            _isEditingNote = editing;

            saveNote.Enabled = editing;
            cancelNote.Enabled = editing;
            noteNotice.Visible = editing;

            if (!editing && setViewing)
            {
                SetViewingProfile(false);
            }
        }

        private void SetViewingProfile(bool handleNote = true, bool doNotUpdateNoteBox = false)
        {
            _viewingProfile = _activeProfile;

            if (!settings.HideProfiles)
            {
                profileName.Text = _viewingProfile.ProfileName;
                profilePicture.ImageLocation = _viewingProfile.ProfilePictureUrl;

                if (_viewingProfile.Private)
                {
                    profileRealName.ForeColor = Color.Red;
                    profileRealName.Text = "This profile is private.";
                    profileLocation.Text = string.Empty;
                }
                else
                {
                    profileRealName.ForeColor = Color.Black;
                    profileRealName.Text = _viewingProfile.RealName;
                    profileLocation.Text = _viewingProfile.Location;
                }
            }

            string note = NoteManager.GetNote(_viewingProfile.SteamID64);

            if (!doNotUpdateNoteBox)
            {
                textBoxNotes.Text = note;
            }

            if (handleNote)
            {
                SetEditingNote(false, false);

                if (settings.NotifyOnNotedHost && !string.IsNullOrWhiteSpace(note))
                {
                    FlashWindow.Flash(this);

                    if (File.Exists("Notification.wav"))
                    {
                        SoundPlayer player = new SoundPlayer("Notification.wav");

                        player.Play();
                    }
                }
            }
        }

        // Event Handlers
        private void OnNewHost(object sender, SteamUser user)
        {
            if (user != null)
            {
                Invoke(new Action(() => SetActiveProfile(user)));
            }
        }
    }
}