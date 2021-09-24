using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lec06Pjt0001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FrameEx(); //플렛폼에서 실행할 시 Frame.xaml을 읽어 실행함
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
