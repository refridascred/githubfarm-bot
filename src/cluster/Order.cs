using System;

namespace Common.Utilities
{
    /// <summary>Order helpers.</summary>
    public static class Order
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ score) % 97;
                if (!((score + offset) >= (offset * 3)))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
