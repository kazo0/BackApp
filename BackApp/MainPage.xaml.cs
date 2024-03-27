namespace BackApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this.InitializeComponent();
	}

	private void Nav(object sender, RoutedEventArgs e)
	{
		Frame.Navigate(typeof(SecondPage));
	}
}
