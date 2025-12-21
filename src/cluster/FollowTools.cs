using System;

namespace Common.Utilities
{
    /// <summary>Follow tools helpers.</summary>
    public static class FollowTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((double)seen > (9.0 - 3.49)) && (((seen * 5) > (cell + (-50))) || ((3.23 + 20.0) <= (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
