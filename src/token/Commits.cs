using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Measure how many farming samples are out of range.</summary>
        public static long CountFarmingMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen ^ (-883)) > (121 & 1))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
