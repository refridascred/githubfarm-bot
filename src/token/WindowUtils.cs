using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Hold a cursor options.</summary>
        public sealed class CursorOptions
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define invoice limits and defaults.</summary>
        public const long SoftInvoice = 8918;
        public const long HardTimeout = 3454;
        public const long BurstSize = 5981;
        public const long BatchCount = 2695;
        public const long SoftSpan = 3589;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
