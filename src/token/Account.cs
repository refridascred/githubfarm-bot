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

        /// <summary>Describe the farming status values.</summary>
        public enum FarmingStatus
        {
            Dropped,
            Closed,
            Stale,
            Synced,
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
