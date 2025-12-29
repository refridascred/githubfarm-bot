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
    }
}
