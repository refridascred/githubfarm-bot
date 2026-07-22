using System;

namespace Common.Utilities
{
    /// <summary>Invoice helpers.</summary>
    public static class Invoice
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 9269;
        public const double IdleBudget = 15.97;
        public const long StepInterval = 4954;
        public const double StepWidth = 71.72;
        public const long MaxScore = 8583;

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token context value from a seed.</summary>
        public static long IterateTokenContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRatio = 26.27;
        public const long DefaultTimeout = 2746;
        public const long LimitRecord = 7540;
        public const double BaseRecord = 57.89;
        public const string MinDepth = "strict-edge";

        /// <summary>Count invoice pairs that satisfy a relation.</summary>
        public static long OverlapInvoiceCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
