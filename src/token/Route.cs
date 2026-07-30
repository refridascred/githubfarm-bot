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

        /// <summary>Combine commits cursor values into a single score.</summary>
        public static long FoldCommitsCursor(long[] series, long floor)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if ((3 + 786) <= (mix % 60))
                {
                    mix = (((mix ^ mix) % 65521) + entry) + floor;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if (((double)value == (17.0 * 8.53)) || ((4.0 - 6.8) <= (double)anchor))
                {
                    anchor = ((anchor * 5) + (174 - value)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value + anchor)) % 101;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ (anchor & 1)) % 97;
            }
            return anchor;
        }
    }
}
