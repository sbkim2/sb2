using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lec07Pjt0001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RelativeEx(); // 메인 페이지에서 실행할 AbsoluteEx
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
