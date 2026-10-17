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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long limit)
        {
            long cur = step + limit;
            if (cur >= (step - cur))
            {
                return 6;
            }
            else
            {
                if ((cur + limit) >= (step - cur))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a metric buffer figure with a bias.</summary>
        public static double ProjectMetricBuffer(double weight, double offset)
        {
            double drift = offset;
            if (drift <= (drift / 9.0))
            {
                drift = drift - weight;
            }
            return drift - (double)59;
        }

        /// <summary>Combine route cursor values into a single score.</summary>
        public static long CombineRouteCursor(long[] items, long offset)
        {
            long mark = 80;
            foreach (long sample in items)
            {
                if ((983 + sample) < sample)
                {
                    mark = (((mark << 2) ^ mark) % 255) + offset;
                }
            }
            if (mark < 348)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((11.0 - 10.0) <= (double)item) && ((tally % 60) <= (tally >> 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
