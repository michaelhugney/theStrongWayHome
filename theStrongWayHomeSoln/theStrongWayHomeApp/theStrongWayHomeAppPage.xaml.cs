using Xamarin.Forms;

namespace theStrongWayHomeApp
{
	public partial class theStrongWayHomeAppPage : ContentPage
	{
		string userName;

		public theStrongWayHomeAppPage()
		{
			InitializeComponent();

			Button button = new Button { Text = "Login through FaceBook" };
			button.Clicked += async (sim, e) =>
			{
				await this.DisplayAlert("Alert", "You clicked me!", "OK");
			};

			Label question = new Label
			{
				Text = "Hello, what is your name?",
				BackgroundColor = Color.Maroon,
				TextColor = Color.FromRgb(75, 0, 0),
				MinimumWidthRequest = 0.5,
				WidthRequest = 0.75,
			};
			Entry name = new Entry
			{
				Text = "John",
				BackgroundColor = Color.Maroon,
			};
			name.Completed += (o,s) => {
				ShowNextPage(name.Text);
			};

			var layout = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};

			layout.Children.Add(question);
			layout.Children.Add(name);

			Content = layout;
		}

		public void ShowNextPage(string name)
		{
			var layout = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Entry
					{
						Text = "Hello, " + name,
					}
				}
			};
			this.Content = layout;
		}
	}
}

