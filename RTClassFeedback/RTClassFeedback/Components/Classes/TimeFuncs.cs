using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    static class TimeFuncs
    {
        public static long makeTimeStamp()
        {
            DateTime now = DateTime.Now;
            long ticks = now.Ticks;
         
            return ticks;
        }

        public static DateTime readTimeStamp(long longTime)
        {
            DateTime timeStamp = new DateTime(longTime);

            return timeStamp;
        }

    }
}
