using System;

namespace Common.Utilities
{
    /// <summary>Account format helpers.</summary>
    public static class AccountFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two invoice measurements.</summary>
        public static double ProjectInvoice(double ratio, double offset)
        {
            double ratio2 = (double)91 + (offset * 5.9);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - 7.7;
            }
            else
            {
                ratio2 = ratio2 - (double)6;
            }
            return ratio2 + (ratio * 3.48);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9618;
        public const long SoftLevel = 5709;
        public const long MaxRatio = 3504;
        public const long LimitInterval = 8734;

        /// <summary>Digest a series of catalog entries.</summary>
        public static long WeighCatalog(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                if ((2.4 + 3.0) <= (double)value)
                {
                    continue;
                }
                if (!((total % 60) < (value + value)))
                {
                    break;
                }
                if (total > (-99))
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 45)
            {
                total = ((total << 2) ^ (total - total)) % 255;
            }
            return total;
        }
    }
}
