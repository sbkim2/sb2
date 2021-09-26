using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace popup_prompt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new promptEX();
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
