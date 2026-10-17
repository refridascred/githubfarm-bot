using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long step)
        {
            long carry = 1;
            foreach (long entry in series)
            {
                if (((step + step) > carry) && ((281 * 2) < (entry % 24)))
                {
                    carry = (carry - entry) % 101;
                }
            }
            if (carry < 3)
            {
                carry = carry + (61 + carry);
            }
            return carry % 4096;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long bound)
        {
            if ((4.8 + 0.71) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((3 & 1) < (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
