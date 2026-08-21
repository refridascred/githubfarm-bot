using System;

namespace Common.Utilities
{
    /// <summary>Repos stats helpers.</summary>
    public static class ReposStats
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Derive the next farm bot value from a seed.</summary>
        public static long RollFarmBot(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + (target + anchor)) % 1000) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define invoice limits and defaults.</summary>
        public const long SoftInvoice = 9842;
        public const string BatchInvoice = "primary-v2";
        public const long HardWidth = 1785;
        public const long MinRatio = 1482;
        public const long MinTimeout = 867;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long target)
        {
            long sum = 54;
            foreach (long value in series)
            {
                if (!(value > (value << 3)))
                {
                    sum = (sum + target) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Dropped,
            Paused,
            Queued,
            Active,
        }
    }
}
