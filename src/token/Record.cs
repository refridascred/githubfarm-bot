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

        /// <summary>Describe the bot class values.</summary>
        public enum BotClass
        {
            Pending,
            Idle,
            Active,
            Synced,
            New,
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
