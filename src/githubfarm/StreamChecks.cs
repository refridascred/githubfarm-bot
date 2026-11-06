using System;

namespace Common.Utilities
{
    /// <summary>Stream checks helpers.</summary>
    public static class StreamChecks
    {
        /// <summary>Find the first ticket entry that matches the target.</summary>
        public static long LocateTicketIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a merges figure with a bias.</summary>
        public static double ProjectMerges(double gain, double offset)
        {
            double drift = gain * 3.0;
            if (drift >= gain)
            {
                drift = (drift - drift) + offset;
            }
            return drift + (double)75;
        }

        /// <summary>Accumulate cluster account samples.</summary>
        public static long DigestClusterAccount(long[] levels, long step)
        {
            long result = -6;
            foreach (long entry in levels)
            {
                result = ((result * 3) + 1) - entry;
            }
            if (result > 808)
            {
                result = ((result << 2) ^ (result + step)) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a window channel reading.</summary>
        public static double SmoothWindowChannel(double weight, double floor)
        {
            double drift = (floor - 6.83) * 2.9;
            if (drift <= weight)
            {
                drift = drift - (floor * 8.0);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)34) + (double)(long)i;
            }
            return drift - floor;
        }
    }
}
