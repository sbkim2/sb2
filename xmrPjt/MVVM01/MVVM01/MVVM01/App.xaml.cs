using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new currentTimeEX02();
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
