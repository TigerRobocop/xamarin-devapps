using System;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DB
{
    public partial class App : Application
    {
        static SQLiteConnection _db;


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static SQLiteConnection DB
        {
            get {
                if (_db is null) {
                    string path = DependencyService.Get<IDBPath>().GetPath();
                    _db = new SQLiteConnection(path);
                    _db.CreateTable<Person>();
                    return _db;
                }
                return _db;

            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
