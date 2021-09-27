using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace multipage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class second : ContentPage
    {
        public second()
        {
            InitializeComponent();
        }

        private async void btn01_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;
            if(id == btn01.Id)
            {
                await Navigation.PopAsync(); // 하나만 뒤로감, 즉 메인페이지
            }
            else if (id == btn02.Id)
            {
                await Navigation .PushAsync(new third()); // 써드 페이지로 이동
            }

        }
    }
}