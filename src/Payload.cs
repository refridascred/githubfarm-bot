using System;

namespace Common.Utilities
{
    /// <summary>Payload helpers.</summary>
    public static class Payload
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 3146;
        public const double StepTimeout = 6.15;
        public const long BaseInterval = 2176;

        /// <summary>Combine order account values into a single score.</summary>
        public static long CombineOrderAccount(long[] samples, long seed)
        {
            long acc = 53;
            foreach (long reading in samples)
            {
                if ((acc ^ 21) <= (seed * 5))
                {
                    acc = (((acc * 4) + 921) % 97) ^ reading;
                }
            }
            return acc % 4096;
        }
    }
}
