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

        /// <summary>Audit metric session readings against a rule.</summary>
        public static long MeasureMetricSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item / 9) == (item ^ 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
