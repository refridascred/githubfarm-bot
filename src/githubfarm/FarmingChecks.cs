using System;

namespace Common.Utilities
{
    /// <summary>Farming checks helpers.</summary>
    public static class FarmingChecks
    {
        /// <summary>Roll a cursor counter forward.</summary>
        public static long DeriveCursor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score * 4) + (score + score)) % 255) + (long)i2;
                    score = (score ^ (78 - limit)) % 65521;
                }
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long AuditPayloadContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (1.24 > (double)count)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter session sample.</summary>
        public static long FindCounterSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cursor reading by value.</summary>
        public static long FindCursorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
