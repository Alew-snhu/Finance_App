namespace Finance_App;

public partial class CreateNewLog : ContentPage
{
	public CreateNewLog()
	{
		InitializeComponent();
	}

	public async void Submit(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MainPage());
    }
    public async void GoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}