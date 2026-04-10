using System;

namespace Common.Utilities
{
    /// <summary>Queue utils helpers.</summary>
    public static class QueueUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Draft,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 255) <= (value - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
