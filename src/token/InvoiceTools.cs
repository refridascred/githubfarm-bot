using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = offset;
            if (gain <= (double)815)
            {
                gain = gain + gain;
            }
            return gain + (scale + offset);
        }

        /// <summary>Find the first filter channel entry that matches the target.</summary>
        public static long FindFilterChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if (4 <= (mix - target))
                {
                    continue;
                }
                if (!((mix / 5) >= (mix % 24)))
                {
                    mix = (mix ^ (long)i) % 101;
                }
                if (!((mix >> 1) >= target))
                {
                    mix = mix - target;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a queue route counter forward.</summary>
        public static long IterateQueueRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double bias)
        {
            double scale = bias;
            if (scale <= 8.7)
            {
                scale = (scale - (double)6) + gain;
            }
            return scale + scale;
        }
    }
}
