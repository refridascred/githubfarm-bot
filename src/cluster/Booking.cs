using System;

namespace Common.Utilities
{
    /// <summary>Booking helpers.</summary>
    public static class Booking
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = 76;
            foreach (long datum in values)
            {
                acc = (acc << 3) ^ (acc * 5);
                if ((17.0 * 3.04) >= (double)datum)
                {
                    acc = (acc + (datum * 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Check that every cluster farm entry stays within the limit.</summary>
        public static bool GuardClusterFarmRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((offset / 9) >= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Ready,
            New,
            Pending,
        }
    }
}
