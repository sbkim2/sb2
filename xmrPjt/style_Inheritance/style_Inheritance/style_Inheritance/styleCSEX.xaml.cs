using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace style_Inheritance
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class styleCSEX : ContentPage
    {
        public styleCSEX()
        {
            InitializeComponent();
            this.Padding = 20; // 컨텐츠 페이지의 패딩

            var mainTitle = new Style(typeof(Label)) // 타겟타입 레이블의 스타일 생성
            {
                Setters =
                        {
                            new Setter
                            {
                                Property = Label.TextColorProperty,
                                Value = "#fff" // 각 속성의 값을 정의
                            },
                            new Setter
                            {
                                Property = Label.FontSizeProperty,
                                Value = 30
                            },
                            new Setter
                            {
                                Property = Label.FontAttributesProperty,
                                Value = FontAttributes.Bold
                            },
                            new Setter
                            {
                                Property = Label.PaddingProperty,
                                Value = new Thickness(5)
                            },
                            new Setter
                            {
                                Property = Label.BackgroundColorProperty,
                                Value = Color.FromHex("f00")
                            },
                            new Setter
                            {
                                Property = Label.HorizontalTextAlignmentProperty,
                                Value = TextAlignment.End
                            }
                        }
            };

            var subTitleStyle = new Style(typeof(Label)) // 타겟타입 레이블의 스타일을 정의
            {
                Setters =
                        {
                            new Setter
                            {
                                Property = Label.TextColorProperty,
                                Value = "#fff"
                            },
                            new Setter
                            {
                                Property = Label.FontSizeProperty,
                                Value = 20
                            },
                            new Setter
                            {
                                Property = Label.FontAttributesProperty,
                                Value = FontAttributes.Bold
                            },
                            new Setter
                            {
                                Property = Label.PaddingProperty,
                                Value = new Thickness(5, 5, 20, 5)
                            },
                            new Setter
                            {
                                Property = Label.BackgroundColorProperty,
                                Value = Color.FromHex("900")
                            },
                            new Setter
                            {
                                Property = Label.HorizontalTextAlignmentProperty,
                                Value = TextAlignment.End
                            }
                        }
            };

            var articleStyle = new Style(typeof(Label))
            {
                Setters =
                        {
                            new Setter
                            {
                                Property = Label.TextColorProperty,
                                Value = "#fff"
                            },
                            new Setter
                            {
                                Property = Label.FontSizeProperty,
                                Value = 14
                            },
                            new Setter
                            {
                                Property = Label.FontAttributesProperty,
                                Value = FontAttributes.None
                            },
                            new Setter
                            {
                                Property = Label.PaddingProperty,
                                Value = new Thickness(5, 5, 35, 5)
                            },
                            new Setter
                            {
                                Property = Label.BackgroundColorProperty,
                                Value = Color.FromHex("500")
                            },
                            new Setter
                            {
                                Property = Label.HorizontalTextAlignmentProperty,
                                Value = TextAlignment.End
                            }
                        }
            };

            var moreBtnStyle = new Style(typeof(Button))
            {
                Setters =
                        {
                            new Setter
                            {
                                Property = Label.FontAttributesProperty,
                                Value = FontAttributes.Bold
                            },
                            new Setter
                            {
                                Property = Label.HorizontalOptionsProperty,
                                Value = LayoutOptions.Start
                            },
                            new Setter
                            {
                                Property = Label.BackgroundColorProperty,
                                Value = Color.FromHex("00f")
                            },
                            new Setter
                            {
                                Property = Label.TextColorProperty,
                                Value = Color.FromHex("fff")
                            }
                        }
            };

            StackLayout stackLayout = new StackLayout();

            Label label1_01 = new Label();
            label1_01.Text = "메인 제목";
            label1_01.Style = mainTitle;

            Label label1_02 = new Label
            {
                Text = "부제목",
                Style = subTitleStyle
            };

            Label label1_03 = new Label
            {
                Text = "김상범입니다",
                Style = articleStyle
            };

            Button btn1_01 = new Button
            {
                Text = "more",
                Style = moreBtnStyle
            };


            Label label2_01 = new Label
            {
                Text = "메인 제목2",
                Style = mainTitle
            };

            Label label2_02 = new Label
            {
                Text = "부제목2",
                Style = subTitleStyle
            };

            Label label2_03 = new Label
            {
                Text = "신원에 다닙니다.",
                Style = articleStyle
            };

            Button btn2_01 = new Button
            {
                Text = "더 보기",
                Style = moreBtnStyle
            };


            stackLayout.Children.Add(label1_01);
            stackLayout.Children.Add(label1_02);
            stackLayout.Children.Add(label1_03);
            stackLayout.Children.Add(btn1_01);

            stackLayout.Children.Add(label2_01);
            stackLayout.Children.Add(label2_02);
            stackLayout.Children.Add(label2_03);
            stackLayout.Children.Add(btn2_01); //스택레이아웃에 붙힘

            this.Content = stackLayout; // 컨텐츠페이지에 붙힘
        }
    }
}