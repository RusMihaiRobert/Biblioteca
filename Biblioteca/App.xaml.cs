using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Data;
using System.IO;

namespace Biblioteca
{
    public partial class App : Application
    {
        static LibraryDatabase database;
        public static LibraryDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                    LibraryDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Library.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
