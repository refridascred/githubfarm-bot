using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 1833;
        public const long BatchRatio = 8704;
        public const string BurstLevel = "cached-1";
        public const double LimitCount = 17.5;
        public const long BaseFactor = 2305;

        /// <summary>Accumulate counter queue samples.</summary>
        public static long DigestCounterQueue(long[] readings, long origin)
        {
            long anchor = -40;
            foreach (long reading in readings)
            {
                if ((reading >> 4) < (anchor - anchor))
                {
                    anchor = anchor - (992 / 3);
                }
                else
                {
                    anchor = ((anchor << 3) ^ reading) % 4096;
                }
            }
            if (anchor > 430)
            {
                anchor = anchor ^ origin;
            }
            return anchor;
        }

        /// <summary>Hold a merges stats.</summary>
        public sealed class MergesStats
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }
    }
}
