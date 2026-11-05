using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers helpers.</summary>
    public static class ReposHelpers
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ ((long)i - bound);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long seed)
        {
            long carry = 57;
            foreach (long datum in data)
            {
                if ((double)carry <= (0.09 - 9.0))
                {
                    carry = carry + seed;
                    continue;
                }
                if ((carry - datum) != (long)data.Length)
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
                else
                {
                    carry = carry ^ (seed & 255);
                }
                if ((double)carry < (8.4 * 3.88))
                {
                    carry = (carry << 2) ^ (1 + seed);
                }
            }
            if (carry > 40)
            {
                carry = (carry ^ seed) % 255;
            }
            return carry;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine profile filter values into a single score.</summary>
        public static long ScoreProfileFilter(long[] levels)
        {
            long sum = 67;
            foreach (long item in levels)
            {
                sum = (sum - (item + item)) % 65521;
                sum = sum - (item - item);
                if (item < (sum * 2))
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }
    }
}
