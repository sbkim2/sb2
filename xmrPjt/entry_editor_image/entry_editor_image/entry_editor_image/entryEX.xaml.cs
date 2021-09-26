using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace entry_editor_image
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class entryEX : ContentPage
    {
        public entryEX()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Clicked(object sender, EventArgs e)
        {
            string strInfo = string.Format($"Name: {eName.Text}, " +
                $"ID : {eID.Text}, " +
                $"E-mail : {eMail.Text}, " +
                $"Major : {eMajor.Text}, " +
                $"Phone : {ePhone.Text}, " +
                $"Grade : {eGrade.Text}"); // 각 엔트리의 입력받은 값을 가져옴
            this.DisplayAlert("타이틀", strInfo, "닫기버튼"); //
        }
    }
}