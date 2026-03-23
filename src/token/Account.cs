using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farming entries that pass the check.</summary>
        public static long TallyFarmingOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count % 2) != (2 * 3)) && (((double)reading != (2.28 - 8.5)) && ((4.18 * 8.65) <= (double)reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate catalog readings against a bound.</summary>
        public static bool ValidateCatalogBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the booking graph entries that pass the check.</summary>
        public static long TallyBookingGraphMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)tally != (5.07 / 7.0)) && ((bound < (value ^ 347)) || (2 >= (bound & 7))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
