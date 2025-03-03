using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NGPlayerNET
{
    public class NoFlashTimebomb
    {
        [DllImport("NoFlashTimebomb.dll")]
        public static extern int PatchFlashTimebombW([MarshalAs(UnmanagedType.LPWStr)] string szModuleName);

        [DllImport("NoFlashTimebomb.dll")]
        public static extern int PatchFlashTimebombHandle(IntPtr hModule);

        public static bool NeedsTimebombPatch(Version flashVersion)
        {
            if (flashVersion == null)
                return false;

            return flashVersion.Major == 32 && flashVersion.Revision >= 387;
        }
    }
}
