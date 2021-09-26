using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace label_button
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class labelCS : ContentPage
    {
        public labelCS()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("cccccc"), //16진수 노란색
                Orientation = StackOrientation.Vertical  //Orientation 은 기본적으로 버티칼임
            };

            Label label01 = new Label()
            {
                Text = "라벨01",
                Margin = 30,
                Padding = 10,
                BackgroundColor = Color.FromHex("ffff00"),
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("ff0000")
            };

            stackLayout.Children.Add(label01); // 스탟레이아웃에 라벨을 담음
            this.Content = stackLayout; // 콘텐츠 페이지에 이 컨텐츠c#을 담음
        }
    }
}