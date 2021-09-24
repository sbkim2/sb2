using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lec06Pjt0001
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyContentView : ContentView
    {
        public MyContentView()
        {
            InitializeComponent(); // 이때 자믈파일에 있는 컴퍼넌트를 메모리에 생성함

            pName.Text = "";
            pMajor.Text = "";
            pNation.Text = "";
            pGender.Text = "";
            pAge.Text = "";
        }

        public string Name
        {
            get
            {
                return pName.Text;
            }
            set
            {
                pName.Text = value;
            }
        }
        public string Major { 
            get
            {
                return pMajor.Text;
            }
            set
            {
                pMajor.Text = value;
            }
        }
        public string Nation
        {
            get
            {
                return pNation.Text;
            }
            set
            {
                pNation.Text = value;
            }
        }
        public string Gender
        {
            get
            {
                return pGender.Text;
            }
            set
            {
                pGender.Text = value;
            }
        }
        public string Age
        {
            get
            {
                return pAge.Text;
            }
            set
            {
                pAge.Text = value;
            }
        }
    }
}