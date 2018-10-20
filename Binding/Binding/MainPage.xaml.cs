using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Binding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label newLabel = new Label();
            newLabel.TextColor = Color.Red;


            newLabel.BindingContext = slider;
            newLabel.SetBinding(Label.TextProperty, "Value");


            BoxView box = new BoxView();
            box.Color = Color.Blue;
            box.SetBinding(BoxView.OpacityProperty, new Binding
            {
                ImageSource = slider,
                Path = "Value"
            });

            stack.Children.Add(newLabel);
        }
    }
}
