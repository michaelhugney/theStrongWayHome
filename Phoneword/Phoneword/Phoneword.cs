using System;

using Xamarin.Forms;

namespace Phoneword
{
	public class App : Application
	{
		public App()
		{
			MainPage = new MainPage();
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

	public class MainPage : ContentPage
	{
		public MainPage()
		{
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						HorizontalTextAlignment = TextAlignment.Center,
						Text = "Welcome to Phoneword!!"
					}
				}
			};
		}
	}
}

