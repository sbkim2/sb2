using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class currentTimeEX02 : ContentPage
    {
        public currentTimeEX02()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), timer); //1초 마다 timer를 호출함
        }
        private bool timer()
        {
            label1.Text = $"{DateTime.Now}";
            label2.Text = $"이번 년도는 {DateTime.Now.Year}";
            label3.Text = $"이번 월은 {DateTime.Now.Month}";
            label4.Text = $"이번 일은 {DateTime.Now.Day}";
            label5.Text = $"시간은? {DateTime.Now.TimeOfDay}";

            return true;
        }
    }
}