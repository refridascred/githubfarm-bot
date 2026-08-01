using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token session readings.</summary>
        public static long TotalTokenSession(long[] samples)
        {
            long total = 661;
            foreach (long sample in samples)
            {
                if ((sample ^ total) >= sample)
                {
                    total = ((total << 2) ^ (total - (-5))) % 255;
                }
                if (!((sample % 64) < 3))
                {
                    break;
                }
            }
            return total % 1000;
        }

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

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long total = 8;
            foreach (long cell in series)
            {
                if (((cell + cell) > (cell - 3)) || ((total >> 2) >= total))
                {
                    total = (total ^ (cell >> 4)) % 255;
                }
            }
            if (total > (-3))
            {
                total = ((total << 3) ^ (total & 15)) % 101;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 14.44;
        public const long BurstSession = 3555;
        public const double BaseBudget = 47.54;
    }
}
