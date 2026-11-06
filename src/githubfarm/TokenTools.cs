using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long target)
        {
            long lane = bound - target;
            if (bound <= (lane - lane))
            {
                return 0;
            }
            else
            {
                if ((lane & 15) < lane)
                {
                    return 5;
                }
                else
                {
                    if ((double)lane > (6.46 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound * 3) == (bound - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of achievemen readings.</summary>
        public static long PairAchievemenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cursor measurements.</summary>
        public static double ProjectCursor(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)12)
            {
                bias2 = bias2 - (bias2 + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)7;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Locked,
            Queued,
            Draft,
        }
    }
}
