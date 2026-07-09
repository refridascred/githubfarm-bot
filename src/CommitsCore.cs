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

        /// <summary>Count catalog pairs that satisfy a relation.</summary>
        public static long PairCatalogCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
