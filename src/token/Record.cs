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

        /// <summary>Count the invoice entries that pass the check.</summary>
        public static long MeasureInvoiceMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((0 << 3) >= seen)
                {
                    seen = ((seen + 3) + sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the catalog kind values.</summary>
        public enum CatalogKind
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Paused,
            Dropped,
        }

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
