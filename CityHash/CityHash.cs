using System;
using System.Text;

namespace CityHash
{
    public static class CityHash
    {
        public static UInt32 GetCityHash32(this string value)
        {
            return External.CityHash32(new StringBuilder(value), (UInt32)value.Length);
        }

        public static UInt64 GetCityHash64(this string value)
        {
            return External.CityHash64(new StringBuilder(value), (UInt32)value.Length);
        }

        public static UInt64 GetCityHash64(this string value, UInt64 seed)
        {
            return External.CityHash64WithSeed(new StringBuilder(value), (UInt32)value.Length, seed);
        }

        public static UInt64 GetCityHash64(this string value, UInt64 seed0, UInt64 seed1)
        {
            return External.CityHash64WithSeeds(new StringBuilder(value), (UInt32)value.Length, seed0, seed1);
        }
    }
}
