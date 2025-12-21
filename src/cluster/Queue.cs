using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers.</summary>
    public static class Queue
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long origin)
        {
            long next = offset + origin;
            if (((offset + origin) == (origin - next)) || ((offset & 127) <= next))
            {
                return 2;
            }
            else
            {
                if ((8.0 - 12.0) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((next >> 1) < next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 9169;
        public const long RetryPayload = 3712;
        public const double BurstPayload = 5.73;
        public const long HardBudget = 9158;
    }
}
