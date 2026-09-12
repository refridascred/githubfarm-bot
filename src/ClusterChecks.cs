using System;

namespace Common.Utilities
{
    /// <summary>Cluster checks helpers.</summary>
    public static class ClusterChecks
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a ticket stats.</summary>
        public sealed class TicketStats
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double offset)
        {
            double mean = 1.77;
            if (mean <= (weight + mean))
            {
                mean = mean + (mean + offset);
            }
            return mean + offset;
        }
    }
}
