using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourceDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicResourceEX : ContentPage
    {
        public DynamicResourceEX()
        {
            InitializeComponent();
        }

        private void onBtnClicked(object sender, EventArgs e) 
        {
            var id = ((Button)sender).Id;
            //백그라운드 컬러 변경
            if (id == ChangeColorRed.Id)
            {
                label01.BackgroundColor = (Color)this.Resources["ColorRed"];
            }
            else if(id==ChangeColorGreen.Id)
            {
                label01.BackgroundColor = (Color)this.Resources["ColorGreen"];

            }
            else if (id == ChangeColorBlue.Id)
            {
                label01.BackgroundColor = (Color)this.Resources["Colorblue"]; 
            }
            
            //패딩크기 변경.  패딩은 Thickness 형임
            if (id == ChangePaddingBig.Id)
            {
                label01.Padding = new Thickness((double)this.Resources["outPjtPaddingBig"]);
                
            }
            else if (id == ChangePaddingNomal.Id)
            {
                label01.Padding = new Thickness((double)this.Resources["outPjtPaddingNomal"]);


            }
            else if (id == ChangePaddingSmall.Id)
            {
                label01.Padding = new Thickness((double)this.Resources["outPjtPaddingSmall"]);

            }

            //폰트사이즈
            if (id == ChangeFontSizeBig.Id)
            {
                label01.FontSize = (double)this.Resources["outPjtFontBig"];

            }
            else if (id == ChangeFontSizeNomal.Id)
            {
                label01.FontSize = (double)this.Resources["outPjtFontnomal"];


            }
            else if (id == ChangeFontSizeSmall.Id)
            {
                label01.FontSize = (double)this.Resources["outPjtFontSmall"];

            }
        }
    }
}