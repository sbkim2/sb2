using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Style_xaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new stylePartitialChangeEX();
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
