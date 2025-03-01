using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Reflection;

namespace NGPlayerNET
{
    public class PortalError
    {
        public int code;
        public string msg;
    }

    public class PortalSWFMeta
    {
        public int id;
        public string title;
        public string width;
        public string height;
        public string author;
        public string swf;
        public string player_version;
        public string flashVars;
        public PortalError error;
    }

    class NGAPI
    {
        public const string NG_PORTAL_META = "https://www.newgrounds.com/portal/swf-player-meta/{0}";
        public const string NG_PORTAL_META_AUTH = NG_PORTAL_META + "_{1}";

        // we need more of these! or ideally we need some modern TLSv1.2 capabilities.
        public static string[] NG_PORTAL_META_MIRRORS = new string[]
        {
            "http://ipg.pw/experiments/newgrounds_relay.php?portal={0}"
        };

        private static string GetRandomMirror()
        {
            Random rng = new Random();
            int idx = rng.Next(NG_PORTAL_META_MIRRORS.Length);
            return NG_PORTAL_META_MIRRORS[idx];
        }

        private static int MakeHTTPRequest(string url, out string responseStr)
        {
            responseStr = "";

            // silly workaround for Windows 10/11 trying to use TLSv1...?
            // Windows 7 is using TLSv1.2 for this by default so idk what 10 got goin on
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "NGPlayerNET/" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            request.MaximumAutomaticRedirections = 1;
            request.KeepAlive = false;
            request.Timeout = 3000;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return (int)response.StatusCode;
                }

                using (StreamReader readStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    responseStr = readStream.ReadToEnd();
                }

                return 0;
            }
            catch (WebException ex)
            {
                return -1;
            }
            catch (ProtocolViolationException)
            {
                return -2;
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public static PortalSWFMeta GetMetadata(int portalId, string authentication = "")
        {
            string url = string.Format(NG_PORTAL_META, portalId);
            bool UsingHTTPMirror = false;

            if (authentication != null && authentication != "")
            {
                url = string.Format(NG_PORTAL_META_AUTH, portalId, authentication);
            }

            if (PlayerConfig.AlwaysUseHTTPMirror && !PlayerConfig.DisallowHTTPMirror)
            {
                UsingHTTPMirror = true;
                url = string.Format(GetRandomMirror(), portalId);
            }

            string respStr;
            int r = MakeHTTPRequest(url, out respStr);
            if (r != 0)
            {
                if (r == -1 && !PlayerConfig.DisallowHTTPMirror)
                {
                    Console.WriteLine("Request to {0} failed due to network error, trying again with new URL", url);
                    UsingHTTPMirror = true;
                    url = string.Format(GetRandomMirror(), portalId);
                    r = MakeHTTPRequest(url, out respStr);
                }
                if (r != 0)
                {
                    Console.WriteLine("Request to {0} failed ({1})", url, r);
                    return null;
                }
            }

            PortalSWFMeta meta = JsonConvert.DeserializeObject<PortalSWFMeta>(respStr);
            if (UsingHTTPMirror)
            {
                meta.swf = meta.swf.Replace("https://", "http://");
            }
            return meta;
        }

        public static int GetPortalIDFromURL(string url, out string authentication)
        {
            int id = 0;
            authentication = null;
            if (int.TryParse(url, out id))
                return id;

            if (url.StartsWith("newgroundsplayer:"))
            {
                string[] splits = url.Split(':')[1].Split('_');
                if (splits.Length != 3 || splits[2] != "1")
                    return 0;
                authentication = splits[1];
                if (!int.TryParse(splits[0], out id))
                    return 0;
                return id;
            }
            else if (url.StartsWith("https://") || url.StartsWith("http://"))
            {
                string[] splits = url.Split('?')[0].Split('/');
                if (splits.Length < 6)
                    return 0;
                if (splits[2] != "www.newgrounds.com" &&
                    splits[2] != "newgrounds.com")
                    return 0;
                if (splits[3] == "portal" && splits[4] == "view")
                {
                    if (!int.TryParse(splits[5], out id))
                        return 0;
                    return id;
                }
                return 0;
            }

            return 0;
        }
    }
}
