using System;

namespace Common.Utilities
{
    /// <summary>Invoice core helpers.</summary>
    public static class InvoiceCore
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - ratio;
            }
            return mean - (double)(-88);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a achievemen figure with a bias.</summary>
        public static double ProjectAchievemen(double bias, double bias2)
        {
            double load = bias / 3.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (bias - load)) - (double)(long)i) - bias2;
            }
            return load + (load + 0.4);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farming queue readings against a rule.</summary>
        public static long TallyFarmingQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)7 <= (double)datum)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
