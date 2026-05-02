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

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long CountCommandChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
