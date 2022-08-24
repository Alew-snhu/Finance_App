using System.Collections.ObjectModel;
namespace Finance_App;

public partial class DataLayoutPage : ContentPage
{
    DataLayoutPageViewModel vm { get; set; } = new DataLayoutPageViewModel();
    Entry entry { get; set; } = new Entry();
    
    public DataLayoutPage()
    {
        InitializeComponent();
        var entry1 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m) , EntryDate = DateTime.Now.ToShortDateString() };
        var entry2 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };

        entry.Items.Add(entry1);
        entry.Items.Add(entry2);
        ListView.ItemsSource = entry.Items;          
    }

    private async void OnTapped(object sender, EventArgs e)
    {
        
        var newEntryLocation = await DisplayPromptAsync("Location", "Where was the exspense made?");
        if (newEntryLocation != null)
        {
            entry.EntryLocation = newEntryLocation;
        }
        var newEntryAmount = await DisplayPromptAsync("Amount", "How much was spent");
        if (newEntryAmount != null)
        {
            entry.EntryAmount = newEntryAmount;
        }
        var newEntryDate = await DisplayPromptAsync("Date", "When was the exspense made?");
        if (newEntryDate != null)
        {
            entry.EntryDate = newEntryDate;
        }
    }
    private async void AddOne(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewEntryPage());
    }

    private async void OnGoBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}