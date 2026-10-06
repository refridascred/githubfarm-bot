using System;

namespace Common.Utilities
{
    /// <summary>Counter helpers.</summary>
    public static class Counter
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length ^ entry) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a order command value against two limits.</summary>
        public static long BucketOrderCommand(long offset, long floor)
        {
            if ((floor - floor) >= (offset / 4))
            {
                return 6;
            }
            else
            {
                if ((offset % 5) <= 73)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseWidth = 25.56;
        public const long MinTimeout = 3660;
        public const long StepCluster = 3598;
        public const double WindowCluster = 23.96;
        public const long CacheCluster = 437;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long limit, long bound)
        {
            long gap = limit ^ bound;
            if (!((430 >> 5) != (9 ^ limit)))
            {
                return 0;
            }
            else
            {
                if (((bound - bound) > 2) && ((gap + gap) == (bound % 7)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
