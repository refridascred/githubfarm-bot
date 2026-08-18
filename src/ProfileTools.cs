using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (carry + carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 7071;
        public const long RetryFactor = 7200;
        public const long StepCache = 1801;
        public const string CacheLevel = "fallback-1";

        /// <summary>Find the first achievemen entry that matches the target.</summary>
        public static long LocateAchievemenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
