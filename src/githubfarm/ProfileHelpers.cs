using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 9795;
        public const long CacheSpan = 3095;
        public const long HardBudget = 2460;
        public const double CacheRecord = 41.59;
        public const string MinSpan = "alpha-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6076;
        public const long MaxSize = 8131;
        public const long StepSize = 1;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 9113;
        public const long BatchBudget = 7136;
        public const string CacheScore = "standard-v2";
        public const long WindowSize = 5533;

        /// <summary>Derive the next layout record value from a seed.</summary>
        public static long IterateLayoutRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 5) + (step + step);
                if ((step + state) == ((long)i / 8))
                {
                    continue;
                }
                else
                {
                    state = (state - (state & 15)) % 255;
                }
                state = (state << 2) ^ (599 + state);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] readings)
        {
            long result = 59;
            foreach (long reading in readings)
            {
                if ((double)result <= (3.0 + 13.0))
                {
                    result = ((result - (37 >> 3)) % 4096) + reading;
                }
            }
            return result % 65521;
        }
    }
}
