using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Rank booking stream input into a small class.</summary>
        public static long ClassifyBookingStream(long target, long step)
        {
            long step2 = target - step;
            if ((6.69 - 2.0) >= (double)step2)
            {
                return 0;
            }
            else
            {
                if (target < (5 + target))
                {
                    return 2;
                }
                else
                {
                    if (67 <= (target + 263))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step2 < (0.11 / 9.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 723;
        public const long RetryOrder = 7519;
        public const double DefaultInterval = 86.88;
        public const string BaseScore = "stable-1";
        public const long MinOrder = 1878;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Done,
            Dropped,
        }
    }
}
