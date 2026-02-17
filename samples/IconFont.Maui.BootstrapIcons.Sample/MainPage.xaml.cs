using BI = IconFont.Maui.BootstrapIcons.BootstrapIcons;

namespace IconFont.Maui.BootstrapIcons.Sample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		AddCSharpIcons();
	}

	private void AddCSharpIcons()
	{
		string[] glyphs = [BI.Github, BI.Twitter, BI.Linkedin, BI.Youtube, BI.Discord];
		string[] colors = ["#181717", "#1DA1F2", "#0A66C2", "#FF0000", "#5865F2"];
		string[] names = ["GitHub", "Twitter", "LinkedIn", "YouTube", "Discord"];

		for (int i = 0; i < glyphs.Length; i++)
		{
			var stack = new VerticalStackLayout { HorizontalOptions = LayoutOptions.Center, Spacing = 4 };
			var image = new Image
			{
				WidthRequest = 28,
				HeightRequest = 28,
				Source = BI.Create(glyphs[i], Color.FromArgb(colors[i]), 28)
			};
			stack.Children.Add(image);
			stack.Children.Add(new Label { Text = names[i], FontSize = 10, HorizontalOptions = LayoutOptions.Center });
			CSharpIcons.Children.Add(stack);
		}
	}
}
