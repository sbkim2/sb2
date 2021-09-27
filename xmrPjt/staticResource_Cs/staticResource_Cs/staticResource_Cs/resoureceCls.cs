using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace staticResource_Cs
{
    class resoureceCls
    {
        //BackgroundColor="Red"
        //Padding="20"
        //FontSize="20"
        //FontAttributes="Bold"
        //TextColor="#FFF"

        public static Color BackColorRed = Color.FromHex("#f00");
        public static Color BackColorGreen = Color.FromHex("#0f0");
        public static Color BackColorBlue = Color.FromHex("#00f");//백그라운드 컬러

        public static double PadingBig = 80.0; // 패딩과 폰트는 더블형식
        public static double PadingNomal = 20.0;
        public static double PadingSmall = 10.0;

        public static double FontBig = 20.0;
        public static double FontNomal = 10.0;
        public static double FontSmall = 5.0;

        public static Color txtColorWhite = Color.FromHex("#fff");
        public static Color txtColorGray = Color.FromHex("#ccc");
        public static Color txtColorBlack = Color.FromHex("#000");

        //폰트 어트리뷰투
        public static FontAttributes FontAttBold = FontAttributes.Bold;
        public static FontAttributes FontAttItalic = FontAttributes.Italic;
        public static FontAttributes FontAttBI = FontAttributes.Bold | FontAttributes.Italic;





    }
}
