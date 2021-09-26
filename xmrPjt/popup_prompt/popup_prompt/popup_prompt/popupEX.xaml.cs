using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace popup_prompt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class popupEX : ContentPage
    {
        public popupEX()
        {
            InitializeComponent();
        }

        private async void btn01_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;
            if (id == btn01.Id)
            {
                await DisplayAlert("타이틀", "버튼을 눌렀따!", "닫기"); // await 는 비동기식 처리
            }
            else if (id == btn02.Id)
            {
                bool resultBool = await DisplayAlert("선택 타이틀", "앱을 종료할래??", "응", "아니요"); // 인자가 4개이면 선택값이 두개임, 이때 반환이 bool값이다
                Debug.WriteLine($"result : {resultBool}");
            }
            else if (id == btn03.Id)
            {
                string resultStr = await DisplayActionSheet("Choose your language.", "cancel", null, "korea", "japan", "china", "english"); // DisplayActionSheet는 여러 항목중 하나를 고르개하는것
                Debug.WriteLine($"action : {resultStr}");
            }
        }
    }
}