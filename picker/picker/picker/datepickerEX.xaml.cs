using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace picker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class datepickerEX : ContentPage
    {
        public datepickerEX()
        {
            InitializeComponent();
        }

        private void dp01_DateSelected(object sender, DateChangedEventArgs e)
        {
            var id = ((DatePicker)sender).Id;
            if (id == dp01.Id)
            {
                DateTime dateTime = e.NewDate; // e는 센더로 부터 입력받는 값임
                int year = dateTime.Year; // 입력한 년도를 가져옴
                int month = dateTime.Month; //월을 가져옴
                int day = dateTime.Day; // 일을 가져옴

                char[] days = { '일', '월', '화', '수', '목', '금', '토' }; // day라는 배열에 0부터 6까지 값을 넣어줌
                char date = days[(int)dateTime.DayOfWeek]; //요일을 가져오는데 0부터 6까지 숫자로 가져옴

                Debug.WriteLine($"{year}년 {month}월 {day}일 {date}요일");
                label01.Text = $"{year}년 {month}월 {day}일 {date}요일";
            }
        }
    }
}