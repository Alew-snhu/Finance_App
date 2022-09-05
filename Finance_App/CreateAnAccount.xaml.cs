

namespace Finance_App;

public partial class CreateAnAccount : ContentPage
{
	public CreateAnAccount()
	{
		InitializeComponent();
	}

    //private async void OnSubmit(object sender, EventArgs e)
    //{
    //    await
    //}
    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());

    }
}