using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4236;
        public const long BurstCount = 1529;
        public const string BatchChannel = "local";

        /// <summary>Compare every pair of cluster repos readings.</summary>
        public static long MatchClusterReposCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter invoice entries.</summary>
        public static long TallyCounterInvoice(long[] levels)
        {
            long anchor = 30;
            foreach (long cell in levels)
            {
                if ((anchor + cell) == (cell - cell))
                {
                    anchor = (anchor + anchor) % 4096;
                }
            }
            if (anchor < 190)
            {
                anchor = ((anchor << 2) ^ (anchor / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Dropped,
            Stale,
            Draft,
        }
    }
}
