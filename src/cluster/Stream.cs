using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (anchor - (datum >> 1)) % 4096;
                if ((anchor & 31) <= anchor)
                {
                    break;
                }
            }
            if (anchor < 207)
            {
                anchor = (anchor - (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}
