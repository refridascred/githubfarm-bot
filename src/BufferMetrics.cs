using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Compare every pair of catalog route readings.</summary>
        public static long OverlapCatalogRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long origin, long bound)
        {
            if ((bound / 8) < (32 - 99))
            {
                return 8;
            }
            else
            {
                if ((93 < origin) || ((bound * 4) != (bound ^ origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 4) > (2 + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound / 7) > (origin ^ bound)) && ((6 >> 5) >= (origin + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cursor counter forward.</summary>
        public static long StepCursor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i & 31) != ((long)i ^ seed))
                {
                    carry = ((carry * 5) + (carry - (long)i)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
