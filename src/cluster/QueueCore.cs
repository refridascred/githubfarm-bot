using System;

namespace Common.Utilities
{
    /// <summary>Queue core helpers.</summary>
    public static class QueueCore
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double bias2)
        {
            double weight = (bias2 * 4.0) + bias2;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (1.48 * 2.4)) + (double)(long)i) + bias;
            }
            return weight + (weight - weight);
        }
    }
}
