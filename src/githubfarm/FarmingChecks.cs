using System;

namespace Common.Utilities
{
    /// <summary>Farming checks helpers.</summary>
    public static class FarmingChecks
    {
        /// <summary>Roll a cursor counter forward.</summary>
        public static long DeriveCursor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score * 4) + (score + score)) % 255) + (long)i2;
                    score = (score ^ (78 - limit)) % 65521;
                }
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate booking readings against a bound.</summary>
        public static bool CheckBookingBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a counter session sample.</summary>
        public static long FindCounterSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
