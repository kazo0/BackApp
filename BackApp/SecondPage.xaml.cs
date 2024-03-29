using Windows.UI.Core;

namespace BackApp;

public sealed partial class SecondPage : Page
{
	public SecondPage()
	{
		this.InitializeComponent();

		Loaded += OnLoaded;
		Unloaded += OnUnloaded;
	}

	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
	}

	 void OnUnloaded(object sender, RoutedEventArgs e)
	{
		SystemNavigationManager.GetForCurrentView().BackRequested -= OnBackRequested;
	}

#if !WINDOWS
	private void OnBackRequested(object? sender, BackRequestedEventArgs e)
	{
		Frame.GoBack();

		// Need to set this to true to prevent the device back bubbling up to the system and closing the app
		e.Handled = true;
	}
#endif
}
