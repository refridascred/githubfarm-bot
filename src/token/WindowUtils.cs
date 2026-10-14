using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
