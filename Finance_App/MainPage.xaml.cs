namespace Finance_App;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }

}

