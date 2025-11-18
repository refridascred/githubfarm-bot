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

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
