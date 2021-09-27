using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace databinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class databindingEX : ContentPage
    {
        public databindingEX()
        {
            InitializeComponent();
            initproperty();
        }

       

        private void slider01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var id = ((Slider)sender).Id;

            if (id == slider01.Id)
            {
                label01.Padding = (int)slider01.Value;
                label02.FontSize = (int)slider01.Value;
            }
        }

        private void initproperty() // 처음 슬라이더 변경시 버벅임없게 초기 슬라이더 값을 가져옴
        {
            label01.Padding = (int)slider01.Value;
            label02.FontSize = (int)slider01.Value;
        }
    }
}