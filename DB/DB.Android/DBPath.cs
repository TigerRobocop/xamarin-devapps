using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DB.Droid.DBPath))]
namespace DB.Droid
{
	public class DBPath: IDBPath
    {
      

        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "DB.db3");

        }
    }
}
