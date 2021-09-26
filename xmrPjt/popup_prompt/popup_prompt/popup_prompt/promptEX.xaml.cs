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
    public partial class promptEX : ContentPage
    {
        public promptEX()
        {
            InitializeComponent();
        }

        private async void btn01_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;
            string result;
            if (id == btn01.Id) // 버튼 1을 클릭했을때는?
            {
                result = await DisplayPromptAsync("질문 1", "이름은?"); //DisplayPromptAsync 로 프롬프트를 뛰워줌 비동기식으로 입력값을 받는다
                Debug.WriteLine($"닶은 : {result}"); 
                if (!string.IsNullOrWhiteSpace(result)) // IsNullOrWhiteSpace은 값이 비어있지 않다면 발동함
                {
                    label01.Text = $" 닶은  : {result}";
                }

            }
            else if (id == btn02.Id) // 버튼 2를 클릭했을때는?
            {
                result = await DisplayPromptAsync("질문 2", "5+5는?", maxLength: 2, keyboard: Keyboard.Numeric); // 키보드는 숫자패드로 설정, maxLength로 글자수를 두자리수로 제한
                Debug.WriteLine($"결과 : {result}");

                if (!string.IsNullOrWhiteSpace(result))
                {
                    int number = Convert.ToInt32(result); // 닶을 인트형으로 컨버트해줌
                    label02.Text = number == 10 ? "정답입니다." : "틀렸습니다.."; // 10이면 ? 정답입니다. 아니면  틀렸습니다.를 라벨로 찍어줌
                }
            }
        }
    }
}