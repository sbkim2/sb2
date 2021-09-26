using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lec07Pjt0001
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteCSEx : ContentPage
    {
        public AbsoluteCSEx()
        {
            InitializeComponent();

            AbsoluteLayout absoluteLayout = new AbsoluteLayout(); // 개체 생성과 생성자를 호출함

            Label label01 = new Label();
            label01.Text = "레드";
            label01.BackgroundColor = new Color(255, 0, 0);
            AbsoluteLayout.SetLayoutBounds(label01, new Rectangle(50, 100, 50, 50)); //위치를정의
            AbsoluteLayout.SetLayoutFlags(label01, AbsoluteLayoutFlags.None);
            absoluteLayout.Children.Add(label01);   // 개체의 프로퍼티를 정의함

            Label label02 = new Label();
            label02.Text = "Yellow-top";
            label02.BackgroundColor = new Color(255, 255, 0);
            AbsoluteLayout.SetLayoutBounds(label02, new Rectangle(.5, 0, .5, .05));
            AbsoluteLayout.SetLayoutFlags(label02, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(label02);

            Label label03 = new Label();
            label03.Text = "Yellow-bottom";
            label03.BackgroundColor = new Color(255, 255, 0);
            AbsoluteLayout.SetLayoutBounds(label03, new Rectangle(.5, 1, .5, .05));
            AbsoluteLayout.SetLayoutFlags(label03, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(label03);

            Label label04 = new Label();
            label04.Text = "Yellow-left";
            label04.BackgroundColor = new Color(255, 255, 0);
            AbsoluteLayout.SetLayoutBounds(label04, new Rectangle(0, .5, 50, 100));
            AbsoluteLayout.SetLayoutFlags(label04, AbsoluteLayoutFlags.PositionProportional);
            absoluteLayout.Children.Add(label04);

            Label label05 = new Label();
            label05.Text = "Yellow-right";
            label05.BackgroundColor = new Color(255, 255, 0);
            AbsoluteLayout.SetLayoutBounds(label05, new Rectangle(1, .5, 50, 100));
            AbsoluteLayout.SetLayoutFlags(label05, AbsoluteLayoutFlags.PositionProportional);
            absoluteLayout.Children.Add(label05);

            this.Content = absoluteLayout;
        }
    }
}