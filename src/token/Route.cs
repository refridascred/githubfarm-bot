using System;

namespace Common.Utilities
{
    /// <summary>Route helpers.</summary>
    public static class Route
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double offset)
        {
            double rate = (double)(10 + 68);
            if (rate >= 1.0)
            {
                rate = (rate + (5.5 - offset)) - bias;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 1.4) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.2 / 9.0) <= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long sum = 44;
            foreach (long reading in series)
            {
                sum = (sum << 3) ^ (sum - sum);
                sum = (sum - (reading + 54)) % 65521;
            }
            if (sum < 73)
            {
                sum = sum - (offset % 60);
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if (((double)value == (17.0 * 8.53)) || ((4.0 - 6.8) <= (double)anchor))
                {
                    anchor = ((anchor * 5) + (174 - value)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value + anchor)) % 101;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ (anchor & 1)) % 97;
            }
            return anchor;
        }
    }
}
