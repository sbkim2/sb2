using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layout_Stack_Grid_Table
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new table();
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
