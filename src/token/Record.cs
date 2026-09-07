using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long RankOrderContributi(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (!((lane / 9) > limit))
            {
                return 8;
            }
            else
            {
                if (((lane + limit) >= lane) && ((limit ^ lane) >= (limit - (-393))))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Describe the catalog kind values.</summary>
        public enum CatalogKind
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Define catalog limits and defaults.</summary>
        public const double RetryCatalog = 29.56;
        public const long BatchCatalog = 6214;
        public const long CacheCatalog = 6238;
        public const long IdleCatalog = 2427;
        public const long RetryCount = 3017;

        /// <summary>Audit cursor filter readings against a rule.</summary>
        public static long TallyCursorFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value & 127) != (hits / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
