using RestDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace RestDemo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // MainPage = new MainPage(); -> Throws an error like: PushAsync is not supported globally.....
            // work around PushAsync is not supported globally
            MainPage = new NavigationPage(new MainPage());
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
