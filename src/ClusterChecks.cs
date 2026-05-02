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

        /// <summary>Define repos limits and defaults.</summary>
        public const string HardRatio = "local-edge";
        public const long MaxScore = 4461;
        public const string SoftWidth = "strict-edge";
        public const double RetryWidth = 50.61;
        public const long BurstWidth = 1719;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
