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

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels, long origin)
        {
            long total = 62;
            foreach (long datum in levels)
            {
                if ((double)origin < (7.8 * 1.52))
                {
                    total = ((total - (total << 3)) % 65521) - datum;
                }
            }
            if (total < 17)
            {
                total = (total ^ (origin - total)) % 65521;
            }
            return total;
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
