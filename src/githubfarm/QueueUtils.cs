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

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor - (anchor << 3);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
