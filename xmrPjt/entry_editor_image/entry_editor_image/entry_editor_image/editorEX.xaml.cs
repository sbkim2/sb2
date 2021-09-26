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
    public partial class editorEX : ContentPage
    {
        public editorEX()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.DisplayAlert("타이틀", eMSG.Text, "닫기버튼");
        }
    }
}