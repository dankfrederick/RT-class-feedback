using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    class Vote
    {
        public long timeStamp;
        public long author;
        public int comprehension; // -1 = no, 0 = neutral, 1 = good comprehension

        // Empty Constructor (no current use case)
        public Vote()
        {

        }
        // Parametric Constructor - standard use case, object used for the storage of all information to be stored in JSON format
        public Vote(long time, long auth, int comp)
        {
            this.timeStamp = time;
            this.author = auth;
            this.comprehension = comp;
        }
    }
}
