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
    public partial class databindingEX03CS : ContentPage
    {
        public databindingEX03CS()
        {
            InitializeComponent();
        

            StackLayout stackLayout = new StackLayout()
            {
                Padding = 20,
                BackgroundColor = Color.FromHex("f88")
            };

            Label label01 = new Label()
            {
                Text = "hello",
                BackgroundColor=Color.FromHex("#fff"),
                HorizontalTextAlignment = TextAlignment.Center
            };
            Label label02 = new Label()
            {
                Text = "자마린",
                BackgroundColor = Color.FromHex("#fff"),
                HorizontalTextAlignment = TextAlignment.Center
            };

            Slider slider = new Slider
            {
                Maximum = 40,
                Minimum = 10
            };

            stackLayout.Children.Add(label01);
            stackLayout.Children.Add(label02);
            stackLayout.Children.Add(slider);

            this.Content = stackLayout;

            Binding binding;

            binding = new Binding
            {
                Source = slider,
                Path = "Value"

            };
            label01.SetBinding(Label.PaddingProperty, binding);


            
             binding = new Binding
             {
                Source = slider,
                Path = "Value"

            };
            label02.SetBinding(Label.FontSizeProperty, binding);


        }
    }
}