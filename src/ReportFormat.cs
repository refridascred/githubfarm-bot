using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Hold a repos header.</summary>
        public sealed class ReposHeader
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a ticket route sample.</summary>
        public static long SeekTicketRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Locked,
            Active,
            New,
        }

        /// <summary>Digest a series of merges entries.</summary>
        public static long TallyMerges(long[] items, long origin)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                if ((mark / 3) < 2)
                {
                    mark = ((mark - origin) % 255) + datum;
                }
                else
                {
                    mark = mark - origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long target)
        {
            long result = 532;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (((result + result) % 1000) ^ (long)i) - target;
                }
                result = (result - (item & 1)) % 255;
            }
            return result % 97;
        }
    }
}
