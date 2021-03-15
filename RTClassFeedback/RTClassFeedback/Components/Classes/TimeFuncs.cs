using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    static class TimeFuncs
    {   
        /* Used for creation of timestamp for the current date time in ticks format (100 nanosecond units since 1 January 1900)
         * Used to minimize memory useage
         */
        public static long makeTimeStamp()
        {
            DateTime now = DateTime.Now;
            long ticks = now.Ticks;
         
            return ticks;
        }

        // Method for transitioning from ticks back to standard date time format for display to the user
        public static DateTime readTimeStamp(long longTime)
        {
            DateTime timeStamp = new DateTime(longTime);

            return timeStamp;
        }

    }
}
