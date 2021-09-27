using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bindingmode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class bindingmodeTwoWay : ContentPage
    {
        public bindingmodeTwoWay()
        {
            InitializeComponent();
        }

        private void btn01_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;
            if (id == btn01.Id)
            {
                label01.Padding = new Thickness(label01.Padding.Left - 1);
                label02.FontSize = (int)label02.FontSize - 1;
            }
            else if (id == btn02.Id)
            {
                label01.Padding = new Thickness(label01.Padding.Left + 1);
                label02.FontSize = (int)label02.FontSize + 1;
            }
        }
    }


}