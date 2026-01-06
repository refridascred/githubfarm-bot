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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a cursor sample.</summary>
        public static long LocateCursorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
