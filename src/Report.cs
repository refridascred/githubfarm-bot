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
    }
}
