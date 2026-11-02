using System;

namespace Common.Utilities
{
    /// <summary>Achievemen helpers.</summary>
    public static class Achievemen
    {
        /// <summary>Audit cursor readings against a rule.</summary>
        public static long AuditCursorOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((918 - hits) == (reading / 6))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((20.0 - 11.0) < (double)cell))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count != (double)(long)levels.Length)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Count the commits bot entries that pass the check.</summary>
        public static long CountCommitsBotOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= (seen + seen))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a booking pair into a bucket.</summary>
        public static long GradeBooking(long origin, long seed)
        {
            long bound = origin ^ seed;
            if (!((bound + bound) <= (origin % 2)))
            {
                return 7;
            }
            else
            {
                if ((5 % 3) < bound)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed <= (17.0 + 18.0)) && ((double)origin != (4.81 / 3.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(origin <= (seed * 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((9.94 / 7.0) >= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
