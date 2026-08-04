using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (((double)score <= (9.64 / 4.0)) || (55 <= (score & 127)))
                {
                    score = ((score << 3) ^ (43 ^ score)) ^ entry;
                }
            }
            if (score < 90)
            {
                score = score - (score + score);
            }
            return score;
        }

        /// <summary>Derive the next cursor value from a seed.</summary>
        public static long IterateCursor(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (5 << 2)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the merges series from a seed.</summary>
        public static long StepMerges(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((carry ^ carry) <= ((long)i & 3))
                {
                    carry = ((carry * 5) + offset) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long TallyFilterBuffer(long[] series)
        {
            long sum = 449;
            foreach (long item in series)
            {
                sum = ((sum * 2) + (item + 995)) % 255;
            }
            if (sum > (-2))
            {
                sum = sum + (280 & 63);
            }
            return sum;
        }
    }
}
