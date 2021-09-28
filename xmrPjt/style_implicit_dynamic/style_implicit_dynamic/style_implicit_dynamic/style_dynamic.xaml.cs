using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace style_implicit_dynamic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class style_dynamic : ContentPage
    {
        bool originalStyle = true;
        public style_dynamic()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"]; // 키인 서치바스타일에 리소스 블루서치스타일을 할당한다.
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (originalStyle) // 오리지날스타일이 참이면
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"]; // 리소스 키에 그린서치스타일을 할당함
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}