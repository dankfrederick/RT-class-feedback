using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    class RoomCreator : Users
    {
        public int comprehensionLookback = 600;
        public string roomName;

        //Default constructor
        public RoomCreator()
        {

        }

        //Parametric constructor - standard use case
        public RoomCreator(int complookback, long IP, string room, string dispName, string backColor)
        {
            this.comprehensionLookback = complookback;
            // this.IPaddress = IP;  Future Implementation
            this.displayName = dispName;
            this.backgroundColor = backColor;
            this.roomName = room;
        }

        //Method for sending messages from Users who have the option of sending messages anonymously
        public void sendMessage(string mess)
        {
            new Message(TimeFuncs.makeTimeStamp(), this.displayName, mess, backgroundColor);
            // Future Implementation of write to JSON file on web server through REST post
        }

        public void highlightMessage()
        {

        }
    }
}
