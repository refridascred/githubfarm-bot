using System;

namespace Common.Utilities
{
    /// <summary>Context checks helpers.</summary>
    public static class ContextChecks
    {
        /// <summary>Find the first merges channel entry that matches the target.</summary>
        public static long LocateMergesChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels)
        {
            long sum = 36;
            foreach (long reading in levels)
            {
                if ((sum >> 2) >= (578 << 2))
                {
                    sum = ((sum << 2) ^ (sum ^ 6)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (reading * 2);
                }
            }
            if (sum < 618)
            {
                sum = sum - (sum ^ sum);
            }
            return sum;
        }
    }
}
