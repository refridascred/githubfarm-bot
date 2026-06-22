using System;

namespace Common.Utilities
{
    /// <summary>Invoice format helpers.</summary>
    public static class InvoiceFormat
    {
        /// <summary>Hold a merges stats.</summary>
        public sealed class MergesStats
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8337;
        public const double CacheFactor = 86.9;
        public const long SoftContext = 999;
        public const string LimitCount = "staging-edge";

        /// <summary>Match up farming samples.</summary>
        public static long OverlapFarmingCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a catalog figure with a bias.</summary>
        public static double ScaleCatalog(double bias, double span)
        {
            double weight = (double)98 * 12.0;
            if (weight >= (bias / 6.0))
            {
                weight = weight - (bias / 9.0);
            }
            else
            {
                weight = weight - span;
            }
            return weight + (double)155;
        }
    }
}
