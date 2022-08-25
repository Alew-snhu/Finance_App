namespace Finance_App;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void LoadCurrentMonth(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DataLayoutPage());
	}

	private async void CreateNewLog(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new CreateNewLog());
    }

	private async void ViewPastEntries(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PastEntriesPage());
	}

    private async void LogOut(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }

}

