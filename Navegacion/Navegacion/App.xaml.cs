using Navegacion.Data;
using Navegacion.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Navegacion
{
	public partial class App : Application
	{
        private static FriendDataBase dataBase;
        public static FriendDataBase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new FriendDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3"));
                }
                return dataBase;
            }
        }

        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage (new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
