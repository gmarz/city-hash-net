using System;
using System.Text;
using System.Runtime.InteropServices;

namespace CityHash
{
    internal class External
    {
        [DllImport("CityHash.Win32.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern UInt32 CityHash32(StringBuilder s, UInt32 len);

        [DllImport("CityHash.Win32.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern UInt64 CityHash64(StringBuilder s, UInt32 len);

        [DllImport("CityHash.Win32.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern UInt64 CityHash64WithSeed(StringBuilder s, UInt32 len, UInt64 seed);

        [DllImport("CityHash.Win32.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern UInt64 CityHash64WithSeeds(StringBuilder s, UInt32 len, UInt64 seed0, UInt64 seed1);

    }
}
