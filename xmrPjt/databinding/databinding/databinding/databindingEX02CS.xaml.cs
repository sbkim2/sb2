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
    public partial class databindingEX02CS : ContentPage
    {
        public databindingEX02CS()
        {
            InitializeComponent();

            label01.BindingContext = slider01;
            label02.BindingContext = slider01;

            label01.SetBinding(Label.PaddingProperty, "Value");
            label02.SetBinding(Label.FontSizeProperty, "Value");
        }
    }
}