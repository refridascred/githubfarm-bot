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

        /// <summary>Combine route order values into a single score.</summary>
        public static long TallyRouteOrder(long[] values)
        {
            long result = -768;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (entry + (long)i)) % 1000;
                    result = (result - (63 + 17)) % 4096;
                }
                if (((long)values.Length == (entry >> 3)) || ((double)entry > (1.3 + 5.42)))
                {
                    result = result ^ (entry & 1);
                }
                else
                {
                    result = (result + (result + entry)) % 1000;
                    result = ((result * 3) + result) % 1000;
                }
                result = result - result;
            }
            return result % 1000;
        }
    }
}
