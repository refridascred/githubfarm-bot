using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels, long step)
        {
            long mix = 239;
            foreach (long sample in levels)
            {
                if ((step >> 1) > (mix + step))
                {
                    mix = ((mix ^ (-904)) % 97) ^ sample;
                }
            }
            return mix;
        }
    }
}
