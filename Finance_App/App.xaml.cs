namespace Finance_App;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzEwMjg3QDMyMzAyZTMyMmUzMFBMb1ZUMnYrWkppTndhZUExTmJKRmYwMG9rSGNHVGRRK201VFdyNWI0SXc9");
        InitializeComponent();

		MainPage = new NavigationPage(new Login());
	}
}
