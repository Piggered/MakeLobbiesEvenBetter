using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Process.Start("https://blog.piggered.me/makelobbiesevenbetter");
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
