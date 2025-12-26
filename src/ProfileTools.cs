using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 5) >= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long step)
        {
            long carry = -33;
            foreach (long cell in samples)
            {
                if (cell > ((-980) - step))
                {
                    carry = (carry ^ cell) % 255;
                }
            }
            return carry;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long limit)
        {
            if ((3.0 - 4.0) != (double)target)
            {
                return 5;
            }
            else
            {
                if (((limit - 34) <= (target >> 1)) && ((target % 12) == (limit + 4)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
