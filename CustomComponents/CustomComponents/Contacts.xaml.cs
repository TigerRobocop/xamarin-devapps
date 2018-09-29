using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomComponents
{
    public partial class Contacts : ContentView
    {
        public Contacts()
        {
            InitializeComponent();
        }

        public object Name
        {
            get {
                return lblName.Text;
            }

            set {
                lblName.Text = value.ToString();
            }
        }

        public object LastName
        {
            get
            {
                return lblLastName.Text;
            }

            set
            {
                lblLastName.Text = value.ToString();
            }
        }
    }
}
