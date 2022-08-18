using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Finance_App;

public partial class CreateAnAccount : ContentPage
{
	public CreateAnAccount()
	{
		InitializeComponent();
	}

    private async void OnSubmit(object sender, EventArgs e)
    {
        

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        string text = "This Feature Is Not Finished Yet";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show(cancellationTokenSource.Token);

    }
    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());

    }
}