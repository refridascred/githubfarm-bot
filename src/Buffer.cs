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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the merges class values.</summary>
        public enum MergesClass
        {
            Stale,
            Draft,
            Active,
        }

        /// <summary>Define catalog limits and defaults.</summary>
        public const long StepCatalog = 9068;
        public const double RetryCatalog = 36.26;
        public const double SoftCatalog = 79.42;
    }
}
