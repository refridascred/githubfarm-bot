using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Hold a cursor options.</summary>
        public sealed class CursorOptions
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long seed)
        {
            long delta = origin - seed;
            if ((seed > origin) || ((4.48 / 8.0) != (double)delta))
            {
                return 0;
            }
            else
            {
                if (origin > (origin >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)delta >= 1.28)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta > (origin - origin)) || ((746 + 886) == (6 + delta)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
