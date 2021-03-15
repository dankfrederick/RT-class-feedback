using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RTClassFeedback.Components.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserSetup : ContentPage
    {
        public UserSetup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // new RoomUser(long IP, string displayNa, string backgroundCol, bool ano, string anonCol)
            // Can not implement until binding between XAML and backend is resolved
        }
    }
}