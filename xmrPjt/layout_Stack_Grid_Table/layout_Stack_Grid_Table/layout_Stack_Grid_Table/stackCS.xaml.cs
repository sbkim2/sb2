using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layout_Stack_Grid_Table
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class stackCS : ContentPage
    {
        public stackCS()
        {
            InitializeComponent();

            ScrollView scrollView = new ScrollView(); // 스크롤뷰 생성
            scrollView.Padding = 10;
            scrollView.Orientation = ScrollOrientation.Vertical; // 스크롤 방향

            StackLayout stackLayout = new StackLayout(); // 스택레이아웃 생성
            stackLayout.Orientation = StackOrientation.Vertical; // 스크롤 방향
            stackLayout.Spacing = 30;

          

            for (int i = 0; i < 20; i++) // for문을 이용해 라벨을 생성함
            {
                Label tempLabel = new Label();
                tempLabel.Text = "label" + i;
                tempLabel.BackgroundColor = Color.FromHex("ff0000");
                stackLayout.Children.Add(tempLabel); // 스택레이 아웃에 붙히는 구문
            }

            //stackLayout.Children.Add(label01);
            //stackLayout.Children.Add(label02);

            scrollView.Content = stackLayout; // 만든 스텍레아아웃을 스크롤 뷰에 붙힘
            this.Content = scrollView; // this는 Content다 즉, ContentPage
        }
    }
}