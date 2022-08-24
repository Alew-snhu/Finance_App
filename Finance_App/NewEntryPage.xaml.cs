namespace Finance_App;


public partial class NewEntryPage : ContentPage
{
    Entry entry { get; set; } = new Entry();
	public NewEntryPage()
	{
		InitializeComponent();        
	}    

    private async void OnSubmit(object sender, EventArgs e)
    {
        var location = entry.EntryLocation;
        var amount = entry.EntryAmount;
        var datePicked = DatePicker.Date.ToShortDateString();

        var newEntry = new Entry() { EntryAmount = amount, EntryDate = datePicked, EntryLocation = location };
        entry.Items.Add(newEntry);

        await Navigation.PushAsync(new DataLayoutPage());

    }
    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DataLayoutPage());
    }
}