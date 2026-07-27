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

        /// <summary>Define report limits and defaults.</summary>
        public const long MinFactor = 2730;
        public const double SoftScore = 46.81;
        public const long RetryReport = 2924;
        public const double HardCount = 28.09;
        public const long StepReport = 2405;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Done,
            Dropped,
        }
    }
}
