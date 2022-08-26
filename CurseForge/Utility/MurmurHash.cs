/*
 * Original class from https://github.com/jitbit/MurmurHash.net
 */

using System.Linq;
using System.Text;

namespace CurseForge.Utility;

internal static class MurmurHash2
{
    private const uint m = 0x5bd1e995;
    private const int r = 24;

    public static uint Hash(string data)
    {
        return Hash(Encoding.UTF8.GetBytes(data));
    }

    public static uint Hash(byte[] data)
    {
        return Hash(data, 1);
    }

    public static uint Hash(byte[] data, uint seed)
    {
        var length = data.Length;
        if (length == 0)
            return 0;

        var h = seed ^ (uint)length;
        var currentIndex = 0;
        while (length >= 4)
        {
            var k = (uint)(data[currentIndex++] | data[currentIndex++] << 8 | data[currentIndex++] << 16 | data[currentIndex++] << 24);
            k *= m;
            k ^= k >> r;
            k *= m;

            h *= m;
            h ^= k;
            length -= 4;
        }

        switch (length)
        {
            case 3:
                h ^= (ushort)(data[currentIndex++] | data[currentIndex++] << 8);
                h ^= (uint)(data[currentIndex] << 16);
                h *= m;
                break;
            case 2:
                h ^= (ushort)(data[currentIndex++] | data[currentIndex] << 8);
                h *= m;
                break;
            case 1:
                h ^= data[currentIndex];
                h *= m;
                break;
        }

        h ^= h >> 13;
        h *= m;
        h ^= h >> 15;

        return h;
    }

    public static byte[] Normalize(byte[] data) => data.Where(b => b is 9 or 10 or 13 or 32).ToArray();
}