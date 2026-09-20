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

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = acc ^ (acc + (long)i);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
