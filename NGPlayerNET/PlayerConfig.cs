using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NGPlayerNET
{
    class PlayerConfig
    {
        private const string INI_FILENAME = ".\\NGPlayerNET.ini";

        public static string DefaultQuality = "Medium";
        public static bool AlwaysUseHTTPMirror = false;
        public static bool DisallowHTTPMirror = false;
        //public static bool ResizeSWFToWindow = true;
        public static int DefaultExternalWidth = 550;
        public static int DefaultExternalHeight = 400;

        // dumb ini shit
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        private static string ReadINI(string section, string key)
        {
            StringBuilder str = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", str, 255, INI_FILENAME);
            if (i <= 0)
                return null;
            else
                return str.ToString();
        }

        private static bool WriteINI(string section, string key, string value)
        {
            return WritePrivateProfileString(section, key, value, INI_FILENAME);
        }

        public static bool LoadSettings()
        {
            string qual = ReadINI("Visual", "Quality");
            if (qual != null && (qual == "High" || qual == "Medium" || qual == "Low"))
                DefaultQuality = qual;

            string resW = ReadINI("Visual", "LocalResWidth");
            string resH = ReadINI("Visual", "LocalResHeight");
            int resWint = 0;
            int resHint = 0;
            if (int.TryParse(resW, out resWint) && int.TryParse(resH, out resHint))
            {
                DefaultExternalWidth = resWint;
                DefaultExternalHeight = resHint;
            }

            string alwaysHttp = ReadINI("Connection", "AlwaysUseHTTPMirror");
            string neverHttp = ReadINI("Connection", "DisallowHTTPMirror");
            if (neverHttp != null && neverHttp.ToLower() == "true")
            {
                AlwaysUseHTTPMirror = false;
                DisallowHTTPMirror = true;
            }
            else if (alwaysHttp != null && alwaysHttp.ToLower() == "true")
            {
                AlwaysUseHTTPMirror = true;
                DisallowHTTPMirror = false;
            }

            if (Program.IsSecureOperatingSystem())
            {
                AlwaysUseHTTPMirror = false;
                DisallowHTTPMirror = true;
            }

            return true;
        }

        public static void SaveSettings()
        {
            if (Program.IsSecureOperatingSystem())
            {
                AlwaysUseHTTPMirror = false;
                DisallowHTTPMirror = true;
            }

            WriteINI("Visual", "Quality", DefaultQuality);
            WriteINI("Visual", "LocalResWidth", DefaultExternalWidth.ToString());
            WriteINI("Visual", "LocalResHeight", DefaultExternalHeight.ToString());

            WriteINI("Connection", "AlwaysUseHTTPMirror", AlwaysUseHTTPMirror.ToString());
            WriteINI("Connection", "DisallowHTTPMirror", DisallowHTTPMirror.ToString());
        }
    }
}
