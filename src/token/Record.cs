using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long RankOrderContributi(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (!((lane / 9) > limit))
            {
                return 8;
            }
            else
            {
                if (((lane + limit) >= lane) && ((limit ^ lane) >= (limit - (-393))))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
