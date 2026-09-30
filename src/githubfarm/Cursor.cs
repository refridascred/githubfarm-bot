using System;

namespace Common.Utilities
{
    /// <summary>Cursor helpers.</summary>
    public static class Cursor
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define achievemen limits and defaults.</summary>
        public const string IdleAchievemen = "fallback-1";
        public const long DefaultAchievemen = 7963;
        public const long MinLevel = 2001;
        public const string LimitFactor = "cached-edge";
    }
}
