using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace style_implicit_dynamic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new style_dynamic();
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
