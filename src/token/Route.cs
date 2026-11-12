using System;

namespace Common.Utilities
{
    /// <summary>Route helpers.</summary>
    public static class Route
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples, long bound)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((acc - datum) < bound)
                {
                    acc = acc ^ (bound & 7);
                }
                else
                {
                    acc = acc + (bound - 38);
                }
            }
            if (acc < 272)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.2 / 9.0) <= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a farming layout value against two limits.</summary>
        public static long ClassifyFarmingLayout(long offset, long offset2)
        {
            long bound = offset + offset2;
            if (((bound / 5) == (offset2 & 31)) && ((offset % 64) != (offset & 3)))
            {
                return 3;
            }
            else
            {
                if (((offset2 - bound) < (offset << 2)) && ((16 - offset) > offset2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
