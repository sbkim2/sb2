using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace picker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class timepickerEX : ContentPage
    {
        public timepickerEX()
        {
            InitializeComponent();
        }

        private void tp01_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) // 속성이 변하면 발동하는 핸들러다
        {
            var id = ((TimePicker)sender).Id;
            if (id == tp01.Id) // 해당 id가 tp01의 아이디이면?
            {
                if (e.PropertyName == "Time") // e의 속성이 시간이면?
                {
                    //label01.Text = tp01.Time.ToString();

                    int h = tp01.Time.Hours;
                    int m = tp01.Time.Minutes;
                    int s = tp01.Time.Seconds;
                    label01.Text = $"{h}시 {m}분 {s}초"; // 시간의 시,분,초 를 인자로 따로따로 받아 출력해줌
                }
            }
        }
    }
}