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
    public partial class RelativeCSEx : ContentPage
    {
        public RelativeCSEx()
        {
            //InitializeComponent();


            RelativeLayout relativeLayout = new RelativeLayout();
            relativeLayout.BackgroundColor = Color.FromHex("0000ff");

            Label label01 = new Label();
            label01.Text = "Wrap";
            label01.BackgroundColor = Color.FromHex("cccccc");
            relativeLayout.Children.Add(label01, 
                Constraint.RelativeToParent((parent) => {return parent.Width * 0;}), 
                Constraint.RelativeToParent((parent) => {return parent.Height * .1;}),
                Constraint.RelativeToParent((parent) => {return parent.Width * 1;}),
                Constraint.RelativeToParent((parent) => {return parent.Height * .8;})
                );

            Label label02 = new Label();
            label02.Text = "Red";
            label02.BackgroundColor = Color.FromHex("ff0000");
            relativeLayout.Children.Add(label02,
                Constraint.RelativeToParent(parent => { return parent.Width * .2; }),
                Constraint.RelativeToParent(parent => { return parent.Height * .2; }),
                Constraint.RelativeToView(label01, (Parent, child) => { return child.Width * .5; }),
                Constraint.RelativeToView(label01, (Parent, child) => { return child.Height * .5; })
                );

            Label label03 = new Label();
            label03.Text = "Green";
            label03.BackgroundColor = Color.FromHex("00ff00");
            relativeLayout.Children.Add(label03,
                Constraint.RelativeToView(label02, (Parent, child) => { return child.X * 1; }),
                Constraint.RelativeToView(label02, (Parent, child) => { return child.Y * 1 + 270; }),
                Constraint.RelativeToView(label02, (Parent, child) => { return child.Width * 1; }),
                Constraint.RelativeToView(label02, (Parent, child) => { return child.Height * .2; })
                );


            this.Content = relativeLayout;
        }
    }
}