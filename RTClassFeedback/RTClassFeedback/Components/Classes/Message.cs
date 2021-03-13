using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    class Message
    {
        public long timeStamp;
        public long author;
        public string messageText;
        public bool faded = false;
        public bool highlighted = false;
        public string backgroundColor;

        // Empty Constructor (no current use case)
        public Message()
        {

        }
        // Parametric Constructor - standard use case
        public Message(long time, long auth, string text, string color)
        {
            this.timeStamp = time;
            this.author = auth;
            this.messageText = text;
            this.backgroundColor = color;
        }
    }
}
