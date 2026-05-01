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

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels, long origin)
        {
            long total = 62;
            foreach (long datum in levels)
            {
                if ((double)origin < (7.8 * 1.52))
                {
                    total = ((total - (total << 3)) % 65521) - datum;
                }
            }
            if (total < 17)
            {
                total = (total ^ (origin - total)) % 65521;
            }
            return total;
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
