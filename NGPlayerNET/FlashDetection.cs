using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;

namespace NGPlayerNET
{
    class FlashDetection
    {
        public static Version GetFlashVersion(string path)
        {
            if (path == null)
            {
                return null;
            }

            try
            {
                FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path);
                return new Version(ver.FileVersion.Replace(',', '.'));
            }
            catch
            {
                return null;
            }
        }

        public static string GetInstalledFlashPath()
        {
            RegistryKey rk = Registry.ClassesRoot.OpenSubKey(@"CLSID\{D27CDB6E-AE6D-11cf-96B8-444553540000}\InprocServer32");
            if (rk == null)
                return null;
            return (string)rk.GetValue("");
        }
    }
}
