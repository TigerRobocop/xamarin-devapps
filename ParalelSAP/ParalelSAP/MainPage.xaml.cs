using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParalelSAP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            SOInfo info = new SOInfo();

            InitializeComponent();
            lblInfo.Text = info.GetInfo();


        }
    }
}
