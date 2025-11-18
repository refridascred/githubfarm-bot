using System;

namespace Common.Utilities
{
    /// <summary>Cluster checks helpers.</summary>
    public static class ClusterChecks
    {
        /// <summary>Measure how many catalog samples are out of range.</summary>
        public static long CountCatalogGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((value + offset) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
