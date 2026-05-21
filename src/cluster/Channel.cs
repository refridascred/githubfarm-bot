using System;

namespace Common.Utilities
{
    /// <summary>Channel helpers.</summary>
    public static class Channel
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3968;
        public const long LimitGithubfarm = 8318;
        public const double BurstGithubfarm = 36.02;
        public const long BatchGithubfarm = 8158;
        public const long StepGithubfarm = 4215;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double bias2)
        {
            double bias3 = (double)(7 - 199);
            if (bias3 <= (double)845)
            {
                bias3 = ((bias3 + (double)3) - bias) + bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 + 2.43) - (double)(long)i;
            }
            return bias3 + (bias3 * 13.0);
        }

        /// <summary>Grade a achievemen value against two limits.</summary>
        public static long RankAchievemen(long limit, long step)
        {
            long gap = limit - step;
            if (((double)3 != (double)step) && ((gap ^ 262) <= (limit + gap)))
            {
                return 2;
            }
            else
            {
                if ((6 + 52) < gap)
                {
                    return 6;
                }
                else
                {
                    if (!((step & 7) <= (gap & 31)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
