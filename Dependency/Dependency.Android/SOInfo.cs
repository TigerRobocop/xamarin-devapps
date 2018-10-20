using System;
using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Dependency.Android.SOInfo))]

namespace Dependency.Android
{
    public class SOInfo : ISOInfo
    {
        public string GetInfo(){
            return Build.Manufacturer;
        }
    }
}
