using System;

namespace Common.Utilities
{
    /// <summary>Queue utils helpers.</summary>
    public static class QueueUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a ticket record.</summary>
        public sealed class TicketRecord
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
