using System;

namespace Common.Utilities
{
    /// <summary>Cluster format helpers.</summary>
    public static class ClusterFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a metric buffer figure with a bias.</summary>
        public static double ProjectMetricBuffer(double weight, double offset)
        {
            double drift = offset;
            if (drift <= (drift / 9.0))
            {
                drift = drift - weight;
            }
            return drift - (double)59;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 9869;
        public const string WindowChannel = "cached-1";
        public const double StepChannel = 36.43;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((11.0 - 10.0) <= (double)item) && ((tally % 60) <= (tally >> 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
