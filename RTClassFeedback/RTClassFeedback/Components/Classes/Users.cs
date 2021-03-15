using System;
using System.Collections.Generic;
using System.Text;

namespace RTClassFeedback.Components.Classes
{
    abstract class Users
    {
        // public long IPaddress;   Future Implimentation
        public string displayName;
        public string backgroundColor;
        private const string RESTURL = "https;//jsonplaceholder.typicode.com/posts";
        public List<string> availColors = new List<string>        
        {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Indigo",
            "Violet",
            "gray"
        };
    }
}
