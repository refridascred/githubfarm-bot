using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 5) >= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a achievemen figure with a bias.</summary>
        public static double AdjustAchievemen(double weight, double floor)
        {
            double ratio = floor;
            if (ratio >= (floor + weight))
            {
                ratio = ratio - (weight - floor);
            }
            return ratio + (double)98;
        }
    }
}
