using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            pgMaster.BtnAdd.Clicked += Menu_Clicked;
            pgMaster.BtnAbout.Clicked += Menu_Clicked;
            pgMaster.BtnList.Clicked += Menu_Clicked;
            pgMaster.BtnContact.Clicked += Menu_Clicked;
        }

        
        void Menu_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.StyleId) {
                case "add":
                    this.Detail = new NavigationPage(new Add());
                    break;
                case "about":
                    this.Detail = new NavigationPage(new About());
                    break;
                case "list":
                    this.Detail = new NavigationPage(new List());
                    break;
                case "contact":
                    this.Detail = new NavigationPage(new Contact());
                    break;
            }

            this.IsPresented = false;
        }

    }
}
