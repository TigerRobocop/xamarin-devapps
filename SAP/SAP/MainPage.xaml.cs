using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
#if __IOS__
using UIKit;
#elif __ANDROID_1__
using Android.OS;
#endif


namespace SAP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

#if __IOS__
            UIDevice device = new UIDevice();
            lblInfo.Text = String.Format("Model={0}, System={1}, Version={2}",
                                         device.Model, device.SystemName, device.SystemVersion);


#elif __ANDROID_1__
             lblInfo.Text = String.Format("Model={0}, System={1}, Version={2}",
                                          Build.Manufacturer, Build.Model, Build.VERSION.Release.ToString());

#endif
        }
    }
}
