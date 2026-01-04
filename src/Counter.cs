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

        /// <summary>Fold a list of layout counter readings.</summary>
        public static long FoldLayoutCounter(long[] samples)
        {
            long mix = 61;
            foreach (long entry in samples)
            {
                if (entry > (mix + mix))
                {
                    mix = (mix + (mix - mix)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
