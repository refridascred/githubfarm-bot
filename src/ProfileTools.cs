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
    }
}
