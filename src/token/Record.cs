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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum << 2) ^ 70) % 4096;
                sum = (sum + origin) % 1000;
                if ((origin & 7) >= 516)
                {
                    sum = ((sum << 2) ^ (4 - sum)) % 255;
                    continue;
                }
                else
                {
                    sum = ((sum * 2) + (origin * 4)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
