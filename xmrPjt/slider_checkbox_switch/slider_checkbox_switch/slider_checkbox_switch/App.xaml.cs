using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace slider_checkbox_switch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new switchEX();
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
