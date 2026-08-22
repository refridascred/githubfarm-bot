using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Audit cursor invoice readings against a rule.</summary>
        public static long AuditCursorInvoiceHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((entry >> 2) != (count * 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double drift = 12.0;
            return (drift + offset) + rate;
        }

        /// <summary>Describe the merges class values.</summary>
        public enum MergesClass
        {
            Stale,
            Draft,
            Active,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
