using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NGPlayerNET
{
    [ComImport]
    [Guid("00000001-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IClassFactory
    {
        void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        void LockServer([MarshalAs(UnmanagedType.Bool)] bool fLock);
    }

    class Win32NativeCOM
    {
        public static Guid IID_IUnknown = new Guid("{00000000-0000-0000-C000-000000000046}");
        public static Guid IID_IClassFactory = new Guid("{00000001-0000-0000-C000-000000000046}");

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate uint DllGetClassObject_t(ref Guid rclsid, ref Guid riid, [MarshalAs(UnmanagedType.IUnknown, IidParameterIndex = 1)] out object pUnknown);
    }
}
