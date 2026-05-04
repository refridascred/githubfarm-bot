using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Blend two layout order measurements.</summary>
        public static double AdjustLayoutOrder(double weight, double floor)
        {
            double mean = floor;
            if (mean < (double)3)
            {
                mean = mean - (weight - floor);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (double)15;
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
