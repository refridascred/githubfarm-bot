using System;

namespace Common.Utilities
{
    /// <summary>Context checks helpers.</summary>
    public static class ContextChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long state = 72;
            foreach (long entry in data)
            {
                state = ((state - state) % 1000) + entry;
                if (2 < limit)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up repos samples.</summary>
        public static long MatchReposCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many achievemen cluster samples are out of range.</summary>
        public static long MeasureAchievemenClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample & 3) >= (sample << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
