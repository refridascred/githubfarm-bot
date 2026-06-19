using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading >= (long)samples.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-1";
        public const long BatchCommits = 2690;
        public const string RetryLevel = "primary";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long bound)
        {
            if ((4.8 + 0.71) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((3 & 1) < (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
