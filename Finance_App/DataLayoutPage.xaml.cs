namespace Finance_App;

public partial class DataLayoutPage : ContentPage
{
	public DataLayoutPage()
	{
		InitializeComponent();
	}

    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}