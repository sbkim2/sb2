using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bindingmode
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new bindingmodeTwoWay();
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
