using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers.</summary>
    public static class Queue
    {
        /// <summary>Hold a invoice stats.</summary>
        public sealed class InvoiceStats
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the repos catalog entries that pass the check.</summary>
        public static long CountReposCatalogOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((1.32 * 9.4) > (double)count) && ((0 % 64) > (count % 12)))
                {
                    count = ((count + 2) ^ datum) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank merges cluster input into a small class.</summary>
        public static long GradeMergesCluster(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev + prev) > (offset << 3))
            {
                return 6;
            }
            else
            {
                if (!(prev < offset))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (floor >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
