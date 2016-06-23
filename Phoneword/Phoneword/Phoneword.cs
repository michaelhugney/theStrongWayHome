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
		Entry phoneNumberText;
		Button translateButton;
		Button callButton;
		string translatedNumber;

		public MainPage()
		{
			this.Padding = new Thickness(20, Device.OnPlatform(40, 20, 20), 20, 20);
			StackLayout panel = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Vertical,
				Spacing = 15,
			};
			Label commandLabel = new Label
			{
				Text = "Enter a Phoneword:",
			};
			phoneNumberText = new Entry
			{
				Text = "1-855-XAMARIN",
			};
			translateButton = new Button
			{
				Text = "Translate",
			};
			translateButton.Clicked += OnTranslate;
			callButton = new Button
			{
				Text = "Call",
				IsEnabled = false,
			};
			panel.Children.Add(commandLabel);
			panel.Children.Add(phoneNumberText);
			panel.Children.Add(translateButton);
			panel.Children.Add(callButton);

			this.Content = panel;
		}

		void OnTranslate(object sender, System.EventArgs e)
		{
			translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);

			if (!string.IsNullOrEmpty(translatedNumber))
			{
				callButton.IsEnabled = true;
				callButton.Text = "Call " + translatedNumber;
			}
			else
			{
				callButton.IsEnabled = false;
				callButton.Text = "Call";
			}
		}
	}
}

