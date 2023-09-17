namespace PestRecognizerApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new Views.HomePage());
	}
}
