using System;

namespace Common.Utilities
{
    /// <summary>Record helpers helpers.</summary>
    public static class RecordHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (target <= (hits + hits))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster channel entry stays within the limit.</summary>
        public static bool GuardClusterChannelLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long acc = 143;
            foreach (long reading in series)
            {
                if ((reading + acc) < (reading * 3))
                {
                    acc = (acc + (reading - reading)) % 65521;
                }
                else
                {
                    acc = (acc - (reading - acc)) % 4096;
                }
                if ((acc < (reading * 4)) && ((acc / 2) >= reading))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc + 71) % 65521;
            }
            return acc;
        }
    }
}
