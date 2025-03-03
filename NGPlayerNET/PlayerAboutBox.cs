using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace NGPlayerNET
{
    public partial class PlayerAboutBox : Form
    {
        public PlayerAboutBox(int flashVersionInt, string moviePath = null, PortalSWFMeta swfMeta = null, string localFlashVersion = null)
        {
            InitializeComponent();

            playerVersionLabel.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // populate the OS version
            OperatingSystem osVersion = Environment.OSVersion;
            string osNameFormat = "Windows {0}.{1} (build {2})";
            if (osVersion.Platform == PlatformID.Win32Windows)
            {
                osNameFormat = "Windows 9x ({0}.{1}.{2})";
                if (osVersion.Version.Minor == 0)
                    osNameFormat = "Windows 95 ({0}.{1}.{2})";
                else if (osVersion.Version.Minor == 10)
                    osNameFormat = "Windows 98 ({0}.{1}.{2})";
                else if (osVersion.Version.Minor == 90)
                    osNameFormat = "Windows ME ({0}.{1}.{2})";
            }
            else if (osVersion.Platform == PlatformID.Win32NT)
            {
                osNameFormat = "Windows NT {0}.{1} (build {2})";
                if (osVersion.Version.Major == 5 && osVersion.Version.Minor == 0)
                    osNameFormat = "Windows 2000 ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 5 && osVersion.Version.Minor == 1)
                    osNameFormat = "Windows XP ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 5 && osVersion.Version.Minor == 2)
                    osNameFormat = "Windows x64/2003 ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 6 && osVersion.Version.Minor == 0)
                    osNameFormat = "Windows Vista ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 6 && osVersion.Version.Minor == 1)
                    osNameFormat = "Windows 7 ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 6 && osVersion.Version.Minor == 2)
                    osNameFormat = "Windows 8 ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 6 && osVersion.Version.Minor == 3)
                    osNameFormat = "Windows 8.1 ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 10 && osVersion.Version.Build < 22000)
                    osNameFormat = "Windows 10 ({0}.{1}.{2})";
                else if (osVersion.Version.Major == 10)
                    osNameFormat = "Windows 11 ({0}.{1}.{2})";
            }
            // Win32S will use the default and populate to "Windows 3.1" which is correct
            else if (osVersion.Platform != PlatformID.Win32S)
            {
                osNameFormat = osVersion.Platform.ToString() + " ({0}.{1}.{2})";
            }
            // mask off the lower 16 bits- win9x populates the value slightly wrong
            string osName = string.Format(osNameFormat, osVersion.Version.Major, osVersion.Version.Minor, osVersion.Version.Build & 0xFFFF);

            // populate the clr version
            Version clrVersion = Environment.Version;
            string clr = string.Format("{0}.{1}.{2}", clrVersion.Major, clrVersion.Minor, clrVersion.Build);

            // set the info label
#if ARCH_X64
            osInfoLabel.Text = string.Format("Running on 64-bit {0}, .NET {1}", osName, clr);
#else
            osInfoLabel.Text = string.Format("Running on {0}, .NET Framework {1}", osName, clr);
#endif

            // get the flash version
            int flashMajorVersion = ((flashVersionInt >> 16) & 0x7FFF);
            string flashBrandName = flashMajorVersion < 9 ? "Macromedia" : "Adobe";
            string flashVersionFormat = "{0} Flash Player version {1}";
            string flashVersionRegistry = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Macromedia\FlashPlayer", "CurrentVersion", null);
            Version flashVersionInstalled = FlashDetection.GetFlashVersion(FlashDetection.GetInstalledFlashPath());
            string flashVersion;
            if (localFlashVersion != null)
            {
                flashVersion = string.Format(flashVersionFormat, flashBrandName, localFlashVersion + " (included)");
            }
            else if (flashVersionInstalled != null)
            {
                flashVersion = string.Format(flashVersionFormat, flashBrandName, flashVersionInstalled);
            }
            // Flash 10.x and 11.x do this
            else if ((flashVersionInt & 0xFFFF) > 0 && flashVersionRegistry == null)
            {
                int flashMinorVersion = ((flashVersionInt) & 0x7FFF);
                string flashVersionString = string.Format("{0}.{1}", flashMajorVersion, flashMinorVersion);
                flashVersion = string.Format(flashVersionFormat, flashBrandName, flashVersionString);
            }
            else if (flashVersionRegistry == null)
            {
                flashVersion = string.Format(flashVersionFormat, flashBrandName, flashMajorVersion);
            }
            else
            {
                flashVersion = string.Format(flashVersionFormat, flashBrandName, flashVersionRegistry.Replace(',', '.'));
            }
            flashInfoLabel.Text = flashVersion;

            // populate the movie information
            playingURLLabel.Text = moviePath;
            // if no movie
            if (moviePath == null || moviePath == "")
            {
                playingStatusLabel.Text = "No movie loaded";
                playingURLLabel.Visible = false;
            }
            // if ng movie
            else if (swfMeta != null)
            {
                playingStatusLabel.Text = string.Format("Playing NG movie {0}: \"{1}\"", swfMeta.id, swfMeta.title);
            }
            // if local movie
            else
            {
                playingStatusLabel.Text = string.Format("Playing local movie: \"{0}\"", Path.GetFileNameWithoutExtension(moviePath));
            }

            // disable the github url if we're on an OS that has no chance of loading it
            if (osVersion.Version.Major < 6 && // below windows vista
                // xp service pack 3 can probably do it these days
                !(osVersion.Version.Major == 5 && osVersion.Version.Minor == 1 && osVersion.Version.MajorRevision == 3))
            {
                playerSourceLinkLabel.Enabled = false;
            }
        }

        private void playerSourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/InvoxiPlayGames/NGPlayerNET");
        }
    }
}
