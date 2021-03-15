using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    class RoomUser : Users
    {
        bool anon = false;
        string anonColor;

        public RoomUser()
        {
            // Set to gray as placeholder, future update will assign to a random color from a list of possibles
            anonColor = "gray";
        }

        public RoomUser(long IP, string displayNa, string backgroundCol, bool ano, string anonCol)
        {
            // this.IPaddress = IP;  -- Future implimentation
            this.displayName = displayNa;
            this.backgroundColor = backgroundCol;
            this.anon = ano;
            this.anonColor = anonCol;
        }   

        //Method for sending messages from Users who have the option of sending messages anonymously
        public void sendMessage(string mess, bool anon)
        {
            if (anon == true)
            {
                new Message(TimeFuncs.makeTimeStamp(), this.displayName, mess, anonColor);
                // Future Implementation of write to JSON file on web server through REST post
            }
            else
            {
                new Message(TimeFuncs.makeTimeStamp(), this.displayName, mess, backgroundColor);
                // Future Implementation of write to JSON file on web server through REST post
            }
        }

    }
}
