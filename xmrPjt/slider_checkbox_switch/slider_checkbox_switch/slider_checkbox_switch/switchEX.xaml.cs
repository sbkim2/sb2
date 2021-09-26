using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Switch = Xamarin.Forms.Switch;

namespace slider_checkbox_switch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class switchEX : ContentPage
    {
        public switchEX()
        {
            InitializeComponent();
        }

        private void st01_Toggled(object sender, ToggledEventArgs e)
        {
            var id = ((Switch)sender).Id;
            if (id == st01.Id) //햄버거 메뉴를 체크했으면?
            {
                Debug.WriteLine($"햄버거 IsToggled : {st01.IsToggled}"); //디버그로 출력
            }
            else if (id == st02.Id) // 감자튀김을 체크했으면?
            {
                Debug.WriteLine($"감튀 IsToggled : {st02.IsToggled}");
            }
            else if (id == st03.Id)
            {
                Debug.WriteLine($"음료 IsToggled : {st03.IsToggled}");
            }

            printMenu(); // 메서드  호출
        }

        private void printMenu()
        {
            la01.Text = String.Format($"햄버거 : {st01.IsToggled}\n" +
                $"감자튀김 : {st02.IsToggled}\n" +
                $"음료 : {st03.IsToggled}"); //라벨상자에 값을 띄워줌
        }
    }
}