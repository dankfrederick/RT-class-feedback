using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RTClassFeedback.Components.Classes;

namespace RTClassFeedback.Components.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatorSetup : ContentPage
    {
        public CreatorSetup()
        {
            InitializeComponent();
        }

        async private void Create_Clicked(object sender, EventArgs e)
        {
            // RoomCreator creator = new RoomCreator((int) compSlider.GetValue(Value), long IP, string room, string dispName, string backColor));
            // Can not implement until binding issues between XAML and backend resolved
            await Navigation.PushAsync(new MainPage());
        }
    }
}