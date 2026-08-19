using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Compare every pair of catalog route readings.</summary>
        public static long OverlapCatalogRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up layout session samples.</summary>
        public static long OverlapLayoutSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account layout entries that pass the check.</summary>
        public static long CountAccountLayoutGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((target & 7) != (matches - (long)levels.Length))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
