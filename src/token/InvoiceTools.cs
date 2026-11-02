using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = offset;
            if (gain <= (double)815)
            {
                gain = gain + gain;
            }
            return gain + (scale + offset);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mark = 182;
            foreach (long sample in readings)
            {
                mark = mark - (sample & 127);
                if (((sample - mark) == (sample * 4)) && ((mark + mark) >= mark))
                {
                    mark = (mark + (sample * 3)) % 4096;
                    mark = ((mark << 2) ^ ((-20) - sample)) % 97;
                    continue;
                }
                mark = (mark + sample) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long offset)
        {
            if ((double)offset >= (double)target)
            {
                return 8;
            }
            else
            {
                if ((target - offset) <= (target * 3))
                {
                    return 2;
                }
                else
                {
                    if ((7 * 2) <= (target << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target <= 9.9)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session filter samples.</summary>
        public static long PairSessionFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
