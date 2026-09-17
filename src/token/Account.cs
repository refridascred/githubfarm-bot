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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long mark = 41;
            foreach (long value in levels)
            {
                if ((origin + 458) > value)
                {
                    mark = (mark - (3 << 2)) % 255;
                }
                else
                {
                    mark = mark - (value >> 5);
                }
            }
            return mark;
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

        /// <summary>Combine booking command values into a single score.</summary>
        public static long DigestBookingCommand(long[] data, long seed)
        {
            long sum = 21;
            foreach (long entry in data)
            {
                if ((sum >> 5) != (87 + seed))
                {
                    sum = (((sum * 3) + (-68)) % 101) ^ entry;
                }
            }
            if (sum < 0)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
