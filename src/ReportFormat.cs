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
    }
}
