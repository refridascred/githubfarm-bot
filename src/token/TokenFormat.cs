using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "legacy-1";
        public const long LimitToken = 2043;
        public const long HardToken = 7329;
        public const long MaxToken = 8995;
        public const string BaseToken = "strict";

        /// <summary>Describe the invoice level values.</summary>
        public enum InvoiceLevel
        {
            Active,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!!(origin >= total))
                {
                    total = total - origin;
                }
                long matches = (origin % 60) & 63;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (((total << 3) ^ (total + matches)) % 101) + (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
