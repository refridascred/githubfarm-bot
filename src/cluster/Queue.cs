using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers.</summary>
    public static class Queue
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long origin)
        {
            long next = offset + origin;
            if (((offset + origin) == (origin - next)) || ((offset & 127) <= next))
            {
                return 2;
            }
            else
            {
                if ((8.0 - 12.0) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((next >> 1) < next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
