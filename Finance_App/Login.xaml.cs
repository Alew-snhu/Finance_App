namespace Finance_App;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void OnCreateAccount(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAnAccount());
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }
}