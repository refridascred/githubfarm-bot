using System;

namespace Common.Utilities
{
    /// <summary>Cluster checks helpers.</summary>
    public static class ClusterChecks
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((670 % 12) <= (cell * 5)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double offset)
        {
            double mean = 1.77;
            if (mean <= (weight + mean))
            {
                mean = mean + (mean + offset);
            }
            return mean + offset;
        }
    }
}
