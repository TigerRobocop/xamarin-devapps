using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BrowserBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            webBrowser.Source = inputUrl.Text;
        }

        void btnBack_Clicked(object sender, System.EventArgs e)
        {
            webBrowser.GoBack();
        }

        void btnGo_Clicked(object sender, System.EventArgs e)
        {
            webBrowser.GoForward();
        }
    }
}
