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
