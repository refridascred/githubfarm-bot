using System;

namespace Common.Utilities
{
    /// <summary>Cluster checks helpers.</summary>
    public static class ClusterChecks
    {
        /// <summary>Hold a ticket info.</summary>
        public sealed class TicketInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
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
