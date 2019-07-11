namespace MakeLobbiesEvenBetter
{
    public class SteamUser
    {
        public string ProfileName { get; private set; }
        public string RealName { get; private set; }
        public string ProfilePictureUrl { get; private set; }
        public string Location { get; private set; }
        public bool Private { get; private set; }
        public long SteamID64 { get; private set; }

        public SteamUser(long steamID64)
        {
            SteamID64 = steamID64;
        }

        public SteamUser(string profileName, string realName, string profilePictureUrl, string location, bool isPrivate, long steamID64)
        {
            ProfileName = profileName;
            RealName = realName;
            ProfilePictureUrl = profilePictureUrl;
            Location = location;
            Private = isPrivate;
            SteamID64 = steamID64;
        }

        public void SetProfileName(string profileName)
        {
            ProfileName = profileName;
        }

        public void SetRealName(string realName)
        {
            RealName = realName;
        }

        public void SetProfilePictureUrl(string profilePictureUrl)
        {
            ProfilePictureUrl = profilePictureUrl;
        }

        public void SetPrivacy(bool isPrivate)
        {
            Private = isPrivate;
        }

        public void SetLocation(string location)
        {
            Location = location;
        }
    }
}
