﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    class Message
    {
        public long timeStamp;
        public string displayName;
        public string messageText;
        public bool faded = false;
        public bool highlighted = false;
        public string backgroundColor;

        // Empty Constructor (no current use case)
        public Message()
        {

        }
        // Parametric Constructor - standard use case, object used for the storage of all information to be stored in JSON format
        public Message(long time, string auth, string text, string color)
        {
            this.timeStamp = time;
            this.displayName = auth;
            this.messageText = text;
            this.backgroundColor = color;
        }
    }
}
