using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((item + matches) > matches) || ((item * 2) < (46 & 15))) && ((item >> 3) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of achievemen readings.</summary>
        public static long PairAchievemenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cursor measurements.</summary>
        public static double ProjectCursor(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)12)
            {
                bias2 = bias2 - (bias2 + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)7;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
