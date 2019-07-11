using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace MakeLobbiesEvenBetter
{
    public class ProfileCrawler
    {
        // Utilities Methods
        private static HtmlDocument GetDocument(string url)
        {
            HtmlWeb web = new HtmlWeb();

            return web.Load(url);
        }

        private static bool ContainsQuery(HtmlDocument document, string css)
        {
            IEnumerable<HtmlNode> enumerable = document.DocumentNode.QuerySelectorAll(css);

            return enumerable.Count() != 0;
        }

        // Info Fetch Methods
        private static string GetProfileName(HtmlDocument document)
        {
            HtmlNode node = document.DocumentNode.QuerySelectorAll(".profile_header_centered_persona").Single();

            string data = node.SelectSingleNode("div/span").InnerText;

            return HttpUtility.HtmlDecode(data);
        }

        private static string GetRealName(HtmlDocument document)
        {
            HtmlNode node = document.DocumentNode.QuerySelectorAll(".header_real_name").Single();

            string data = node.SelectSingleNode("bdi").InnerText;

            return HttpUtility.HtmlDecode(data);
        }

        private static bool IsPrivateProfile(HtmlDocument document)
        {
            return ContainsQuery(document, ".profile_private_info");
        }

        private static string GetProfilePictureUrl(HtmlDocument document)
        {
            HtmlNode node = document.DocumentNode.QuerySelectorAll(".playerAvatarAutoSizeInner").Single();

            string data = node.SelectSingleNode("img").Attributes["src"].Value;

            return HttpUtility.HtmlDecode(data);
        }

        private static string GetProfileLocation(HtmlDocument document)
        {
            if (!ContainsQuery(document, ".profile_flag"))
            {
                return "";
            }

            HtmlNode node = document.DocumentNode.QuerySelectorAll(".profile_flag").Single();

            string data = node.SelectSingleNode("following-sibling::text()[1]").InnerText.Trim();

            return HttpUtility.HtmlDecode(data);
        }

        // Public Method
        public static SteamUser GetUser(long steamID64)
        {
            HtmlDocument document = GetDocument("https://steamcommunity.com/profiles/" + steamID64.ToString());

            if (!ContainsQuery(document, ".profile_page"))
            {
                return null;
            }

            SteamUser user = new SteamUser(steamID64);
            user.SetProfileName(GetProfileName(document));
            user.SetProfilePictureUrl(GetProfilePictureUrl(document));
            user.SetPrivacy(IsPrivateProfile(document));
            user.SetRealName(user.Private ? "" : GetRealName(document));
            user.SetLocation(user.Private ? "" : GetProfileLocation(document));
            
            return user;
        }
    }
}
