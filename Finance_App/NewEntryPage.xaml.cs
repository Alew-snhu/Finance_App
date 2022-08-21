namespace Finance_App;

public partial class NewEntryPage : ContentPage
{
	public NewEntryPage()
	{
		InitializeComponent();
	}

    private async void OnSubmit(object sender, EventArgs e)
    {
        var location = ExpenseLocation.Text.ToString();
        var amount = ExpenseAmount.Text.ToString();
        var datePicked = DatePicker.Date.ToShortDateString();

        TextCell textCell = new TextCell();
        textCell.Text = $"Location:{location} Amount:{amount} Date:{datePicked}";

        DataLayoutPage dataLayoutPage = new DataLayoutPage();
        dataLayoutPage.DataTable.Add(textCell);

        await Navigation.PushAsync(dataLayoutPage);

    }
    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DataLayoutPage());
    }
}