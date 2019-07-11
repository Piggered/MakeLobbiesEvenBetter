using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MakeLobbiesEvenBetter
{
    public partial class ToolboxWindow : Form
    {
        private MainWindow _mainWindow;
        private LogReader _logReader;
        private Settings _settings;

        private readonly string KILL_TITLE = "Kill Dead by Daylight";
        private readonly string KILL_MESSAGE = "Do you want to forcibly close Dead by Daylight?";
        private readonly string DBD_PROCESS_NAME = "DeadByDaylight-Win64-Shipping";

        private readonly string ABOUT_TITLE = "Open Program Repository";
        private readonly string ABOUT_MESSAGE = "Do you want to open the program's repository in your browser?";
        private readonly string ABOUT_URL = "https://github.com/Piggered/MakeLobbiesEvenBetter";

        public ToolboxWindow(MainWindow main, LogReader log, Settings settings)
        {
            InitializeComponent();

            _mainWindow = main;
            _logReader = log;
            _settings = settings;
        }

        private void UpdateButtonLabels()
        {
            hideProfiles.Text = "Hide Profiles: " + (_settings.HideProfiles ? "ON" : "OFF");
            showProfilePictures.Text = "Show Profile Pictures: " + (_settings.ShowProfilePictures ? "ON" : "OFF");
            showProfileLinks.Text = "Show Profile Links: " + (_settings.ShowProfileLinks ? "ON" : "OFF");
            notifyOnNotedHost.Text = "Notify on Noted Host: " + (_settings.NotifyOnNotedHost ? "ON" : "OFF");
        }

        private void ToolboxWindow_Load(object sender, EventArgs e)
        {
            UpdateButtonLabels();
        }

        private void CloseToolbox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ForceReload_Click(object sender, EventArgs e)
        {
            _logReader.ResetStream();

            Close();
        }

        private void KillDbd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(KILL_MESSAGE, KILL_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (Process process in Process.GetProcessesByName(DBD_PROCESS_NAME))
                {
                    process.Kill();
                }

                Close();
            }
        }

        private void AboutThisProgram_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(ABOUT_MESSAGE, ABOUT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(ABOUT_URL);
            }
        }

        private void HideProfiles_Click(object sender, EventArgs e)
        {
            _mainWindow.ToggleHidingProfiles();

            UpdateButtonLabels();
        }

        private void ShowProfilePictures_Click(object sender, EventArgs e)
        {
            _mainWindow.ToggleShowProfilePictures();

            UpdateButtonLabels();
        }

        private void ShowProfileLinks_Click(object sender, EventArgs e)
        {
            _mainWindow.ToggleShowProfileLinks();

            UpdateButtonLabels();
        }

        private void NotifyOnNotedHost_Click(object sender, EventArgs e)
        {
            _settings.SetNotifyOnNotedHost(!_settings.NotifyOnNotedHost);

            UpdateButtonLabels();
        }
    }
}
