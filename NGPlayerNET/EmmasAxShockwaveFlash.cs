using System;
using System.Collections.Generic;
using System.Text;
using AxShockwaveFlashObjects;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockwaveFlashObjects;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace NGPlayerNET
{
    class EmmasAxShockwaveFlash : AxShockwaveFlash
    {
        private static string LocalFlash_32_r465 = "Flash_32r465.ocx";
        private static string LocalFlash_32_r371 = "Flash_32r371.ocx";
        private static string LocalFlash_11_1_r102_55 = "Flash_11_1r102_55.ocx";
        private static string LocalFlash_9_r289 = "Flash_9r289.ocx";
        private static string LocalFlash_7_r73 = "Flash_7r73.ocx";

        private string loadedLocalFlash = null;

        public string GetLocalFlashVersion()
        {
            return loadedLocalFlash != null ? FlashDetection.GetFlashVersion(loadedLocalFlash).ToString() : null;
        }

        private string GetLocalFlashName()
        {
            int osMajorVersion = Environment.OSVersion.Version.Major;
            int osMinorVersion = Environment.OSVersion.Version.Minor;
            string cd = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";

            // Windows XP and later (5.1+)
            if ((osMajorVersion >= 6 || (osMajorVersion == 5 && osMinorVersion >= 1))
                && File.Exists(cd + LocalFlash_32_r371))
                return cd + LocalFlash_32_r371;
            if ((osMajorVersion >= 6 || (osMajorVersion == 5 && osMinorVersion >= 1))
                && File.Exists(cd + LocalFlash_32_r465))
                return cd + LocalFlash_32_r465;
            // Windows 2000
            if (osMajorVersion >= 5 && File.Exists(cd + LocalFlash_11_1_r102_55))
                return cd + LocalFlash_11_1_r102_55;
            // Windows 98/ME
            if (osMajorVersion >= 4 && (osMajorVersion >= 5 || osMinorVersion >= 10)
                && File.Exists(cd + LocalFlash_9_r289))
                return cd + LocalFlash_9_r289;
            // Windows 95
            if (osMajorVersion >= 4 && File.Exists(cd + LocalFlash_7_r73))
                return cd + LocalFlash_7_r73;

            return null;
        }

        protected override object CreateInstanceCore(Guid clsid)
        {
            // get the latest local flash version available to us, failing out if we don't have any
            string localFlash = GetLocalFlashName();
            if (localFlash == null)
            {
                return base.CreateInstanceCore(clsid);
            }

            // check if we already have a flash player installed
            string installedFlash = FlashDetection.GetInstalledFlashPath();
            if (installedFlash != null && installedFlash != "")
            {
                // if it's newer than the one we have pre-packaged, use that
                Version localVersion = FlashDetection.GetFlashVersion(localFlash);
                Version installedVersion = FlashDetection.GetFlashVersion(installedFlash);
                if (installedVersion.CompareTo(localVersion) >= 0)
                {
                    // really greasy - patch the timebomb even on installed copies of r387+
                    if (NoFlashTimebomb.NeedsTimebombPatch(installedVersion))
                    {
                        IntPtr installedModule = Win32NativeCOM.LoadLibrary(installedFlash);
                        if (NoFlashTimebomb.PatchFlashTimebombHandle(installedModule) == 0)
                        {
                            MessageBox.Show("Timebomb patch failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    return base.CreateInstanceCore(clsid);
                }
            }

            // load our local Flash Player ActiveX component and get DllGetClassObject
            IntPtr hModule = Win32NativeCOM.LoadLibrary(localFlash);
            IntPtr gcoProc = Win32NativeCOM.GetProcAddress(hModule, "DllGetClassObject");
            Win32NativeCOM.DllGetClassObject_t lpDllGetClassObject = Marshal.GetDelegateForFunctionPointer(gcoProc, typeof(Win32NativeCOM.DllGetClassObject_t)) as Win32NativeCOM.DllGetClassObject_t;

            // patch the timebomb if it has one
            if (NoFlashTimebomb.NeedsTimebombPatch(FlashDetection.GetFlashVersion(localFlash)))
            {
                if (NoFlashTimebomb.PatchFlashTimebombHandle(hModule) == 0)
                {
                    MessageBox.Show("Timebomb patch failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // create a class factory for the Flash Player class
            object objClassFactory = null;
            lpDllGetClassObject(ref clsid, ref Win32NativeCOM.IID_IClassFactory, out objClassFactory);
            IClassFactory iClassFactory = objClassFactory as IClassFactory;

            // create an instance of IShockwaveFlash using the class factory we just made
            Guid iid = typeof(IShockwaveFlash).GUID;
            object objShockwaveFlash = null;
            iClassFactory.CreateInstance(null, ref iid, out objShockwaveFlash);

            if (objShockwaveFlash != null)
            {
                loadedLocalFlash = localFlash;
            }

            return objShockwaveFlash;
        }
    }
}
