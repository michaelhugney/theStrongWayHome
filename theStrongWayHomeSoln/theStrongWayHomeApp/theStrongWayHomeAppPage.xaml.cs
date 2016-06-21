using Xamarin.Forms;

namespace theStrongWayHomeApp
{
	public partial class theStrongWayHomeAppPage : ContentPage
	{
		public theStrongWayHomeAppPage()
		{
			InitializeComponent();

			Button button = new Button { Text = "Let's Go" };
			button.Clicked += async (sim, e) =>
			{
				await this.DisplayAlert("Alert", "You clicked me!", "OK");
			};

			var layout = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,

				Children =
				{
					new Label
					{
						HorizontalTextAlignment = TextAlignment.Center,
						Text = "Ready to take the Strong Way Home?"
					}, button
				}
			};
			Content = layout;
		}
	}
}

