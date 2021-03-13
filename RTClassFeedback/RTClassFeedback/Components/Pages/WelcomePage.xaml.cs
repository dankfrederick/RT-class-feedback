using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RTClassFeedback.Components.Pages;

namespace RTClassFeedback
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async private void Create_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatorSetup());
        }

        async private void Join_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserSetup());
        }
    }
}