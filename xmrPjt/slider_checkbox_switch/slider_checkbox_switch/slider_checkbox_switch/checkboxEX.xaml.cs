using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace slider_checkbox_switch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class checkboxEX : ContentPage
    {
        public checkboxEX()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var id = ((CheckBox)sender).Id; //센더를 체크박스 형으로 캐스팅함
            if (id == chbHamburger.Id) //체크된것이 햄버거체크 박스라면
            {
                Debug.WriteLine($"햄버거는  {chbHamburger.IsChecked}"); //디버그로 찍어줌
            }
            else if (id == chbFenchfries.Id)
            {
                Debug.WriteLine($"감자튀김은  {chbFenchfries.IsChecked}");
            }
            else if (id == chbDrink.Id)
            {
                Debug.WriteLine($"음료는  {chbDrink.IsChecked}");
            }

            printCheckedMenu(); // 호출하여 아래 메서드를 호출
        }

        private void printCheckedMenu()
        {
            labelMenu.Text = $"Hamburger : {chbHamburger.IsChecked},\n" +
                $"Fenchfries : {chbFenchfries.IsChecked},\n" +
                $"Drink : {chbDrink.IsChecked}"; 
        }

    }
}