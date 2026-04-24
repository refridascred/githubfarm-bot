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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double drift = span;
            if (drift > ratio)
            {
                drift = drift - (double)4;
            }
            else
            {
                drift = drift + (span + ratio);
            }
            return drift + 0.1;
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
