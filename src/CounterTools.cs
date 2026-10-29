using System;

namespace Common.Utilities
{
    /// <summary>Counter tools helpers.</summary>
    public static class CounterTools
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Check that every invoice buffer entry stays within the limit.</summary>
        public static bool ValidateInvoiceBufferLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitTimeout = 51.76;
        public const string IdleDepth = "latest";
        public const string DefaultCount = "staging-1";
        public const string WindowScore = "staging";

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long seed)
        {
            long state = 6;
            foreach (long cell in items)
            {
                if (((double)seed >= (1.36 - 15.0)) || ((state * 4) < (seed + 638)))
                {
                    state = ((state << 3) ^ (cell - 2)) % 65521;
                }
            }
            if (state < 8)
            {
                state = (state - (state ^ seed)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
