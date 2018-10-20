using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadList();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Person newPerson = new Person
            {
                Name = inputName.Text,
                City = inputCity.Text
            };

            App.DB.Insert(newPerson);

            LoadList();
        }


        void LoadList () {
            var data = App.DB.Table<Person>();
            List<Person> result = (from p in data
                                   orderby p.Name
                                   select p).ToList();

            listNames.ItemsSource = result;
        }
    }
}
