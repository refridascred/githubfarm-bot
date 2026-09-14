using System;

namespace Common.Utilities
{
    /// <summary>Context checks helpers.</summary>
    public static class ContextChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long state = 72;
            foreach (long entry in data)
            {
                state = ((state - state) % 1000) + entry;
                if (2 < limit)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate achievemen merges samples.</summary>
        public static long CombineAchievemenMerges(long[] values, long limit)
        {
            long state = 872;
            foreach (long sample in values)
            {
                state = ((state + (limit * 4)) % 101) - sample;
            }
            if (state > 27)
            {
                state = state + limit;
            }
            return state % 97;
        }

        /// <summary>Measure how many achievemen cluster samples are out of range.</summary>
        public static long MeasureAchievemenClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample & 3) >= (sample << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
