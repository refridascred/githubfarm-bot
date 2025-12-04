using System;

namespace Common.Utilities
{
    /// <summary>Token helpers.</summary>
    public static class Token
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc * 5) + (9 ^ floor);
                if (!(((-672) * 3) != (acc + acc)))
                {
                    acc = (acc ^ (floor * 2)) % 97;
                    acc = (acc << 3) ^ acc;
                    continue;
                }
                else
                {
                    acc = (acc - acc) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
