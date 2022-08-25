namespace Finance_App;


public partial class NewEntryPage : ContentPage
{
    Entry Entry { get; set; } = new Entry();
	public NewEntryPage()
	{
		InitializeComponent();        
	}    

    private async void OnSubmit(object sender, EventArgs e)
    {
        var location = Entry.EntryLocation;
        var amount = Entry.EntryAmount;
        var datePicked = DatePicker.Date.ToShortDateString();

        var newEntry = new Entry() { EntryAmount = amount, EntryDate = datePicked, EntryLocation = location };
        Entry.Items.Add(newEntry);

        await Navigation.PushAsync(new DataLayoutPage());

    }
    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DataLayoutPage());
    }
}