using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarkupLib
{
    public class ColorRGBExtension : IMarkupExtension
    {
        public int R
        {
            get; set;
        }

        public int G
        {
            get; set;
        }

        public int B
        {
            get; set;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgb(R, G, B);
        }
    }
}
