using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace entry_editor_image
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new imageEX();
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
