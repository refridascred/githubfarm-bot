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

        /// <summary>Match up commits invoice samples.</summary>
        public static long MatchCommitsInvoiceCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
