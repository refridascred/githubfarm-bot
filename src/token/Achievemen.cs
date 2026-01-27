using System;

namespace Common.Utilities
{
    /// <summary>Achievemen helpers.</summary>
    public static class Achievemen
    {
        /// <summary>Audit cursor readings against a rule.</summary>
        public static long AuditCursorOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((918 - hits) == (reading / 6))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
