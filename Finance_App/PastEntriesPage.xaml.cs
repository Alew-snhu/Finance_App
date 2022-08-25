namespace Finance_App;

public partial class PastEntriesPage : ContentPage
{
	PastEntry PastEntry { get; set; } = new PastEntry();
	public PastEntriesPage()
	{
		InitializeComponent();
		var pastEntry = new PastEntry() { Month = "August", Year = "2022"};
        var pastEntry2 = new PastEntry() { Month = "September", Year = "2022" }; 
		var pastEntry3 = new PastEntry() { Month = "October", Year = "2022" };
        
		PastEntry.Months.Add(pastEntry);
		PastEntry.Months.Add(pastEntry2);
		PastEntry.Months.Add(pastEntry3);

		PastEntriesListView.ItemsSource = PastEntry.Months;
    }

}
public class PastEntry
{
	public string Month { get; set; }
	public string Year { get; set; }
	public List<PastEntry> Months { get; set; } = new List<PastEntry>();
}