using System;
using System.Text;

namespace CityHash
{
    public class CityHash
    {
        public static UInt32 Hash32(string value)
        {
            return External.CityHash32(new StringBuilder(value), (UInt32)value.Length);
        }

        public static UInt64 Hash64(string value)
        {
            return External.CityHash64(new StringBuilder(value), (UInt32)value.Length);
        }

        public static UInt64 Hash64(string value, UInt64 seed)
        {
            return External.CityHash64WithSeed(new StringBuilder(value), (UInt32)value.Length, seed);
        }

        public static UInt64 Hash64(string value, UInt64 seed0, UInt64 seed1)
        {
            return External.CityHash64WithSeeds(new StringBuilder(value), (UInt32)value.Length, seed0, seed1);
        }
    }
}
