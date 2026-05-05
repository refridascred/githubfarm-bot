using System;

namespace Common.Utilities
{
    /// <summary>Cluster format helpers.</summary>
    public static class ClusterFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many bot samples are out of range.</summary>
        public static long AuditBotHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= 3.26)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farming samples.</summary>
        public static long CombineFarming(long[] values)
        {
            long carry = 23;
            foreach (long reading in values)
            {
                if ((double)carry >= 2.0)
                {
                    carry = ((carry - carry) % 1000) - reading;
                }
            }
            if (carry > (-544))
            {
                carry = (carry - (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((797 >= (sample >> 4)) || ((double)count > (4.4 / 3.0))) && ((410 <= (sample ^ (-245))) || ((1.83 / 5.0) != (double)sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
