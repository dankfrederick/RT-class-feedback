using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RTClassFeedback.Components.Classes;

namespace RTClassFeedback
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Message> _messageGroup = new List<Message>
            {
                // Hard coded test message objects
                new Message(TimeFuncs.makeTimeStamp(), "test1", "Chat window initiated", "gray"),
                new Message(TimeFuncs.makeTimeStamp(), "test2", "Test Test", "red")
            };

            chatWindow.ItemsSource = _messageGroup;

            

            titleText.Text = "Welcome to Room: {name}";
                // + RoomCreator.roomName;
        }

        private void chatWindow_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Use this for fading messages
        }

        private void sendMessage_Clicked(object sender, EventArgs e)
        {
            //sender.add(new Message(TimeFuncs.makeTimeStamp(), 0, "Test", "Yellow"));
        }
    }
}
