using System;

namespace Common.Utilities
{
    /// <summary>Context checks helpers.</summary>
    public static class ContextChecks
    {
        /// <summary>Find the first merges channel entry that matches the target.</summary>
        public static long LocateMergesChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool ValidateCommitsBufferLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
