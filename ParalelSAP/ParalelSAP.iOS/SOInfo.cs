using System;
using UIKit;

namespace ParalelSAP
{
  public string GetInfo()
 {
		UIDevice device = new UIDevice();
		return device.Model();
	}
}
