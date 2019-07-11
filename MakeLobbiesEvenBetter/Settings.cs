using Newtonsoft.Json;
using System.IO;

namespace MakeLobbiesEvenBetter
{
    public class Settings
    {
        public bool HideProfiles { get; set; }
        public bool ShowProfilePictures { get; set; }
        public bool ShowProfileLinks { get; set; }
        public bool NotifyOnNotedHost { get; set; }

        public void SetHideProfiles(bool enabled)
        {
            HideProfiles = enabled;
            SaveSettings(this);
        }

        public void SetShowProfilePictures(bool enabled)
        {
            ShowProfilePictures = enabled;
            SaveSettings(this);
        }

        public void SetShowProfileLinks(bool enabled)
        {
            ShowProfileLinks = enabled;
            SaveSettings(this);
        }

        public void SetNotifyOnNotedHost(bool enabled)
        {
            NotifyOnNotedHost = enabled;
            SaveSettings(this);
        }

        public Settings()
        {
            HideProfiles = false;
            ShowProfilePictures = true;
            ShowProfileLinks = true;
            NotifyOnNotedHost = true;
        }

        public static Settings LoadSettings()
        {
            if (File.Exists("Settings.json"))
            {
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Settings.json"));
            }
            else
            {
                Settings settings = new Settings();

                SaveSettings(settings);

                return settings;
            }
        }

        private static void SaveSettings(Settings settings)
        {
            File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
