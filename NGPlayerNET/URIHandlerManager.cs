using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Reflection;

namespace NGPlayerNET
{
    class URIHandlerManager
    {
        private static void InstallURIHandlerIntoKey(RegistryKey rootkey, string handlerName, string friendlyName, string appTarget)
        {
            RegistryKey key = rootkey.CreateSubKey(@"SOFTWARE\Classes\" + handlerName);

            key.SetValue("", friendlyName);
            key.SetValue("URL Protocol", "");

            using (var defaultIcon = key.CreateSubKey("DefaultIcon"))
            {
                defaultIcon.SetValue("", appTarget + ",1");
            }

            using (var commandKey = key.CreateSubKey(@"shell\open\command"))
            {
                commandKey.SetValue("", "\"" + appTarget + "\" \"%1\"");
            }
        }
        public static bool InstallURIHandler(bool machine)
        {
            try
            {
                if (machine)
                    InstallURIHandlerIntoKey(Registry.LocalMachine, "newgroundsplayer", "NGPlayerNET", Assembly.GetExecutingAssembly().Location);
                else
                    InstallURIHandlerIntoKey(Registry.CurrentUser, "newgroundsplayer", "NGPlayerNET", Assembly.GetExecutingAssembly().Location);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
