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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        count = count + 1;
                    }
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

        /// <summary>Check that every merges filter entry stays within the limit.</summary>
        public static bool GuardMergesFilterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
