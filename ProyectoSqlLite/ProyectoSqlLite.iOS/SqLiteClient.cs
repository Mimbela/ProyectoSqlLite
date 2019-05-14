using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using ProyectoSqlLite.Dependencies;
using ProyectoSqlLite.iOS;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqLiteClient))]
namespace ProyectoSqlLite.iOS
{
    public class SqLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "HOSPITAL.db";
            string rutadocumentos = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string librarypath = Path.Combine(rutadocumentos, "..", "Library", "Databases");
            if (!Directory.Exists(librarypath))
            {
                Directory.CreateDirectory(librarypath);
            }
            string path = Path.Combine(librarypath, bbddfile);
            SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}