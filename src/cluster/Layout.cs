using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Hold a bot header.</summary>
        public sealed class BotHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
