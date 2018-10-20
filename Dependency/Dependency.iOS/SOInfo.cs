using System;
using UIKit;

namespace ParalelSAP
{
     public class SOInfo
    {
        public string GetInfo()
        {
            UIDevice device = new UIDevice();
            return device.Model();
        }
    }
                    
}
