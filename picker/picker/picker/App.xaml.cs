﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace picker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new timepickerEX();
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
