using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace label_button
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class button : ContentPage
    {
        public button()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) //버튼클릭시 실행될 이벤트 헨들러
        {
            Debug.WriteLine("디버그----> 버튼 1 클릭 !!");
            this.DisplayAlert("타이틀", "안녕 나는 김상범", "닫기버튼");
        }

        //private void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    Debug.WriteLine("디버그----> 버튼 2 클릭 !!");
        //    this.DisplayAlert("타이틀", "안녕 나는 상범", "닫기버튼");
        //}

        private void Button03_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("디버그----> 버튼 3 클릭 !!");
            this.DisplayAlert("타이틀", "안녕하다", "닫기버튼");
        }


        private void onClickBtn(object sender, EventArgs e)
        {
            var btnId = ((Button)sender).Id;
            if(btnId == btn2.Id)
            {
                Debug.WriteLine("디버그----> 버튼 2 클릭 !!");
                this.DisplayAlert("타이틀", "안녕 나는 상범 온클릭 핸들러", "닫기버튼");
            }
        }
    }
}