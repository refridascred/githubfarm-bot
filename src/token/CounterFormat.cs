using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine ticket values into a single score.</summary>
        public static long ScoreTicket(long[] values, long limit)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                if ((acc - reading) == (acc * 4))
                {
                    acc = acc + (acc ^ 117);
                }
            }
            if (acc < 31)
            {
                acc = ((acc << 2) ^ (limit / 2)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Find the first commits account entry that matches the target.</summary>
        public static long LookupCommitsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the merges counter entries that pass the check.</summary>
        public static long MeasureMergesCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length - target) >= (9 / 8))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound - 982) < (total >> 4))
                {
                    total = (total + bound) % 65521;
                }
                total = (total + bound) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
