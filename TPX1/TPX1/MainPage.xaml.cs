using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TPX1
{ 
    public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        btnlogin.Clicked += (sender, e) => { Navigation.PushAsync(new Page1()); };
    }
}
}



