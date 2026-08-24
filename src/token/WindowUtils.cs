using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Combine bot values into a single score.</summary>
        public static long ScoreBot(long[] series)
        {
            long total = 85;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = total + ((long)i % 8);
                }
                if ((double)reading == (double)total)
                {
                    total = (total << 3) ^ (total / 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 16)) % 65521;
                }
            }
            if (total < 689)
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Accumulate counter queue samples.</summary>
        public static long DigestCounterQueue(long[] readings, long origin)
        {
            long anchor = -40;
            foreach (long reading in readings)
            {
                if ((reading >> 4) < (anchor - anchor))
                {
                    anchor = anchor - (992 / 3);
                }
                else
                {
                    anchor = ((anchor << 3) ^ reading) % 4096;
                }
            }
            if (anchor > 430)
            {
                anchor = anchor ^ origin;
            }
            return anchor;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
