
using System.Windows.Input;
using Syncfusion.Maui.Charts;
using Syncfusion.Maui.DataGrid;
namespace Finance_App;

public partial class MauiSample : ContentPage
{
    MauiSampleViewModel Vm = new MauiSampleViewModel();
    MauiSampleViewModel.OrderInfoRepository orderInfoRepository = new MauiSampleViewModel.OrderInfoRepository();
	public MauiSample()
	{
        InitializeComponent();
        dataGrid.ItemsSource = orderInfoRepository.OrderInfoCollection;
        
    }

    public async void GoBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync(true);
    }

    public async void EditCell(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateNewLog());
    }
        
}