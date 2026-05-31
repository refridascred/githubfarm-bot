using System;

namespace Common.Utilities
{
    /// <summary>Account format helpers.</summary>
    public static class AccountFormat
    {
        /// <summary>Combine merges schema values into a single score.</summary>
        public static long TallyMergesSchema(long[] data)
        {
            long mark = -16;
            foreach (long item in data)
            {
                mark = ((mark * 3) + (mark * 2)) ^ item;
            }
            if (mark > 51)
            {
                mark = ((mark * 2) + (mark & 31)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two invoice measurements.</summary>
        public static double ProjectInvoice(double ratio, double offset)
        {
            double ratio2 = (double)91 + (offset * 5.9);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - 7.7;
            }
            else
            {
                ratio2 = ratio2 - (double)6;
            }
            return ratio2 + (ratio * 3.48);
        }

        /// <summary>Match up ticket route samples.</summary>
        public static long OverlapTicketRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of catalog entries.</summary>
        public static long WeighCatalog(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                if ((2.4 + 3.0) <= (double)value)
                {
                    continue;
                }
                if (!((total % 60) < (value + value)))
                {
                    break;
                }
                if (total > (-99))
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 45)
            {
                total = ((total << 2) ^ (total - total)) % 255;
            }
            return total;
        }
    }
}
