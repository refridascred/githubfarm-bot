using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers.</summary>
    public static class Repos
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit payload repos readings against a rule.</summary>
        public static long CountPayloadReposHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(value >= hits) && (((hits + hits) == (hits + 829)) || ((hits & 127) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
