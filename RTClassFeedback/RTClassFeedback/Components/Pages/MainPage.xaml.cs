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

            chatWindow.ItemsSource = new List<Message>
            {
                new Message(TimeFuncs.makeTimeStamp(), 0, "Chat window initiated", "gray")
            };

            titleText.Text = "Welcome to Room: {name}";
                // + RoomCreator.roomName;
        }

        private void chatWindow_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void sendMessage_Clicked(object sender, EventArgs e)
        {
            new Message(TimeFuncs.makeTimeStamp(), 0, "Test", "Yellow");
        }
    }
}
