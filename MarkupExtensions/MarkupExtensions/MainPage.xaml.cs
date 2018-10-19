using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarkupExtensions
{
    public partial class MainPage : ContentPage
    {
        public static string defaultText = "Default static text";

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}
