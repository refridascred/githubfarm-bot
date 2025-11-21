using System;

namespace Common.Utilities
{
    /// <summary>Counter helpers.</summary>
    public static class Counter
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long bound)
        {
            long score = -773;
            foreach (long cell in data)
            {
                score = ((score << 3) ^ (cell >> 3)) + bound;
                score = (score + (score << 2)) % 4096;
            }
            return score;
        }
    }
}
