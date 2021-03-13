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
        public RoomCreator(int complookback,long IP, string room, string dispName, string backColor)
        {
            this.comprehensionLookback = complookback;
            this.IPaddress = IP;
            this.displayName = dispName;
            this.backgroundColor = backColor;
            this.roomName = room;
        }
    }
}
