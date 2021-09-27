using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourceDictionary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicResourceEX();
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
