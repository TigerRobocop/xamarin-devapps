using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DB.iOS.DBPath))]
namespace DB.iOS
{
    public class DBPath : IDBPath
    {
        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "DB.db3");

        }
    }
}
