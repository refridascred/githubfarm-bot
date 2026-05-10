using System;

namespace Common.Utilities
{
    /// <summary>Cluster checks helpers.</summary>
    public static class ClusterChecks
    {
        /// <summary>Hold a ticket info.</summary>
        public sealed class TicketInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long limit)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state << 2) ^ (long)i) % 255;
                }
                state = ((state << 3) ^ (3 - sample)) % 65521;
                state = state ^ (limit % 5);
            }
            return state;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
