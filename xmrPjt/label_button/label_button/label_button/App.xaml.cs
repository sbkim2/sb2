using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace label_button
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new button();
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
