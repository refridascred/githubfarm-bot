using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double scale = ratio - (floor - ratio);
            if (scale >= scale)
            {
                scale = scale + (double)31;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + 4.77;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Queued,
            Done,
            Idle,
        }
    }
}
