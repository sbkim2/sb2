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
    public partial class sliderEX : ContentPage
    {
        public sliderEX()
        {
            InitializeComponent();
        }

        private void slider01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var id = ((Slider)sender).Id; // 센더를 slider로 캐스팅하여 id를 뽑아냄
            if (id == slider01.Id)
            {
                Debug.WriteLine(slider01.Value.ToString());
                entry01.Text = $"Slider1 Value : {slider01.Value}"; // 엔트리에 값을 찍어냄
            }
            else if (id == slider02.Id)
            {
                Debug.WriteLine(slider02.Value.ToString());
                entry02.Text = $"Slider2 Value : {slider02.Value}";
            }
        }
    }
}