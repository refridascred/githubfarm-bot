using System;

namespace Common.Utilities
{
    /// <summary>Commits core helpers.</summary>
    public static class CommitsCore
    {
        /// <summary>Derive the next catalog value from a seed.</summary>
        public static long DeriveCatalog(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total + (bound + total);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits >= (hits ^ hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
