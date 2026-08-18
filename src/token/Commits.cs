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

        /// <summary>Hold a cursor snapshot.</summary>
        public sealed class CursorSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
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
