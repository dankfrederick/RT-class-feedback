using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RTClassFeedback
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Sets first page to Welcome Page at application launch. Navigation enabled to allow for page transition
            MainPage = new NavigationPage(new WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
