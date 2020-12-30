using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPX1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {

         
            InitializeComponent();
            btn1.Clicked += (sender, e) => { Navigation.PushAsync(new Page2()); };
            btn2.Clicked += (sender, e) => { Navigation.PushAsync(new Page3()); };
            btn3.Clicked += (sender, e) => { Navigation.PushAsync(new Page4()); };
            btn4.Clicked += (sender, e) => { Navigation.PushAsync(new Page5()); };


        }
    }
}