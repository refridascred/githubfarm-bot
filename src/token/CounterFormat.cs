using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the booking mode values.</summary>
        public enum BookingMode
        {
            Pending,
            Locked,
            Draft,
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

        /// <summary>Match up ticket samples.</summary>
        public static long PairTicketCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
