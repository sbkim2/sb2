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
    public partial class imageEX : ContentPage
    {
        public imageEX()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout
            {
                BackgroundColor = Color.FromHex("ffff00")
            };

            Image image01 = new Image
            {
                BackgroundColor = Color.FromHex("ff0000"),
                Source = ImageSource.FromUri(new Uri("https://cdn.pixabay.com/photo/2021/07/13/11/34/cat-6463284_960_720.jpg")) // 웹주소로 이미지를 불러옴
            };

            Image image02 = new Image
            {
                BackgroundColor = Color.FromHex("ff0000"),
                Source = ImageSource.FromUri(new Uri("https://t1.daumcdn.net/liveboard/holapet/0e5f90af436e4c218343073164a5f657.JPG"))
            };


            Image image03 = new Image
            {
                BackgroundColor = Color.FromHex("ff0000"),
                Source = ImageSource.FromResource("entry_editor_image.image.kirin.jpg") // 로컬에 있는 이미지를 불러옴
            };

            Image image04 = new Image
            {
                BackgroundColor = Color.FromHex("ff0000"),
                Source = ImageSource.FromResource("entry_editor_image.image.yang.jpg")
            };

            stackLayout.Children.Add(image01); //스택에이아웃에 추가해줌
            stackLayout.Children.Add(image02);
            stackLayout.Children.Add(image03);
            stackLayout.Children.Add(image04);

            this.Content = stackLayout;
        }
    }
}