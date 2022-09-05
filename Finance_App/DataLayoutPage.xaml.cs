using System.Collections.ObjectModel;
namespace Finance_App;

public partial class DataLayoutPage : ContentPage
{
    //DataLayoutPageViewModel vm { get; set; } = new DataLayoutPageViewModel();
    Entry entry { get; set; } = new Entry();
    
    public DataLayoutPage()
    {
        InitializeComponent();
        var entry1 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m) , EntryDate = DateTime.Now.ToShortDateString() };
        var entry2 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry3 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry4 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry5 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry6 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry7 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry8 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry9 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry10 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry11 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };
        var entry12 = new Entry() { EntryLocation = "Kwik Trip", EntryAmount = String.Format("{0:C}", 25.35698m), EntryDate = DateTime.Now.ToShortDateString() };

        entry.Items.Add(entry1);
        entry.Items.Add(entry2);
        entry.Items.Add(entry3);
        entry.Items.Add(entry4);
        entry.Items.Add(entry5);
        entry.Items.Add(entry6);
        entry.Items.Add(entry7);
        entry.Items.Add(entry8);
        entry.Items.Add(entry9);
        entry.Items.Add(entry10);
        entry.Items.Add(entry11);
        entry.Items.Add(entry12);

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