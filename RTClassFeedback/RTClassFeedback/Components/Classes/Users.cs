using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    abstract class Users
    {
        public long IPaddress;
        public string displayName;
        public string backgroundColor;
        public List<string> availColors = new List<string>
        {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Indigo",
            "Violet"
        };

        //Method for sending messages from 
        public void sendMessage(string mess, bool anon)
        {

        }

        public void sendMessage(string mess)
        {

        }
    }
}
