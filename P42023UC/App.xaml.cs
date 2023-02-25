using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace P42023UC
{
    public partial class App : Application
    {
        static Controllers.EmpleController database;

        public static Controllers.EmpleController Database
        {
            get 
            {
                if (database == null)
                {
                    var pathdatabase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Prog4.db3";
                    var fullpath = Path.Combine(pathdatabase, dbname);
                    database = new Controllers.EmpleController(fullpath);
                }
                return database;
            }
        }



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageListEmple());
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
