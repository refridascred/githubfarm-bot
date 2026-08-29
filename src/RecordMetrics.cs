using System;

namespace Common.Utilities
{
    /// <summary>Record metrics helpers.</summary>
    public static class RecordMetrics
    {
        /// <summary>Define farming limits and defaults.</summary>
        public const string LimitFarming = "staging";
        public const long BatchFarming = 2014;
        public const long HardFarming = 7285;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long target)
        {
            long mix = 53;
            foreach (long sample in readings)
            {
                if (!((mix * 3) < (sample + 3)))
                {
                    mix = (mix - (target + sample)) % 255;
                }
            }
            if (mix > 33)
            {
                mix = ((mix * 2) + (target + target)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 7.73;
        public const long BurstLayout = 8111;
        public const long HardInterval = 6925;
        public const string WindowLayout = "fallback-edge";
        public const long SoftLayout = 3652;
    }
}
