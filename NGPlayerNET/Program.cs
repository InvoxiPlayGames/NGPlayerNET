using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Principal;

namespace NGPlayerNET
{
    static class Program
    {
        public static bool IsSecureOperatingSystem()
        {
            // currently the cutoff for what should be considered secure is Windows 10 1709
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build > 16299;
        }

        public static string[] Arguments;
        public static bool Elevated = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            Elevated = principal.IsInRole(WindowsBuiltInRole.Administrator) || Environment.OSVersion.Platform == PlatformID.Win32Windows;

            if (args.Length >= 1 && args[0] == "/InstallURI")
            {
                if (URIHandlerManager.InstallURIHandler(Elevated))
                {
                    MessageBox.Show("Successfully installed NGPlayerNET URI handler!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to install NGPlayerNET URI handler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Arguments = args;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PlayerMain());
            }
        }
    }
}
