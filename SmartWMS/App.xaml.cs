namespace SmartWMS;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Constants.RestBaseUrl = $@"https://demo2.oliva-erp.com";


        MainPage = new AppShell();
	}
}
