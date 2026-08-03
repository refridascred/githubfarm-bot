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

        /// <summary>Validate booking readings against a bound.</summary>
        public static bool ValidateBookingBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
