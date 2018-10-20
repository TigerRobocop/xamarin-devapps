using System;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Dependency.iOS.SOInfo))]
namespace Dependency.iOS
{
    public class SOInfo: ISOInfo
    {
        public string GetInfo()
        {
            UIDevice device = new UIDevice();
            return device.Model;
        }
    }
                    
}
