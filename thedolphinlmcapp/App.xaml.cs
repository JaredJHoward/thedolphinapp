using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using thedolphinlmcapp.Data;

namespace thedolphinlmcapp
{
    public partial class App : Application
    {
        static ArticleDatabase database;
        static UsersDatabase database2;
        // Create the database connection as a singleton.
        public static ArticleDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ArticleDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ArticleDB.db3"));
                }
                return database;
            }
        }
        public static UsersDatabase Database2
        {
            get
            {
                if (database2 == null)
                {
                    database2 = new UsersDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDB.db3"));
                }
                return database2;
            }
        }
        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
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
