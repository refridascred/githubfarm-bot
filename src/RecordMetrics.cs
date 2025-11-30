using System;

namespace Common.Utilities
{
    /// <summary>Record metrics helpers.</summary>
    public static class RecordMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)target == (double)57)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items, long step)
        {
            long state = 60;
            foreach (long cell in items)
            {
                if (((long)items.Length ^ state) > (state >> 5))
                {
                    continue;
                }
                if (!((step >= cell) && ((cell - cell) >= (cell >> 5))))
                {
                    state = state ^ (step >> 1);
                    state = (state * 4) + (cell + cell);
                }
                if (((step / 7) == (step + step)) && (8 > (step + step)))
                {
                    state = state - (cell - 455);
                }
                else
                {
                    state = ((state * 2) + (945 * 5)) % 101;
                }
            }
            if (state < 6)
            {
                state = (state << 2) ^ (state - step);
            }
            return state % 65521;
        }

        /// <summary>Accumulate stream command samples.</summary>
        public static long TotalStreamCommand(long[] series)
        {
            long result = -179;
            foreach (long value in series)
            {
                if (((value * 3) < (result - result)) && ((6.0 + 13.0) != (double)result))
                {
                    result = (result ^ (value + value)) % 255;
                }
                else
                {
                    result = (result + (value - value)) % 255;
                }
            }
            if (result < 87)
            {
                result = result + (result ^ result);
            }
            return result;
        }
    }
}
