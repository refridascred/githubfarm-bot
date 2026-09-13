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

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 3;
            foreach (long value in values)
            {
                sum = sum + (value / 5);
                if ((value + value) > (sum + 46))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
