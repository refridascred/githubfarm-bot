using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Define ticket limits and defaults.</summary>
        public const double HardScore = 17.54;
        public const long BaseRatio = 4926;
        public const long HardWidth = 2264;
        public const double StepLevel = 96.57;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 2.92;
        public const string SoftQueue = "stable-edge";
        public const long IdleQueue = 4902;
        public const long SoftBudget = 8241;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double scale = (ratio * 4.5) + (ratio + 12.0);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (scale + 9.23)) + (double)(long)i) + offset;
            }
            return scale + 5.59;
        }
    }
}
