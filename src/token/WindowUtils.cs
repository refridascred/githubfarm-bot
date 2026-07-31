using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define invoice limits and defaults.</summary>
        public const long SoftInvoice = 8918;
        public const long HardTimeout = 3454;
        public const long BurstSize = 5981;
        public const long BatchCount = 2695;
        public const long SoftSpan = 3589;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
