using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using CommunityToolkit.Maui;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.DataGrid.Hosting;

namespace Finance_App;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit().ConfigureSyncfusionCore().ConfigureSyncfusionDataGrid(); 
        return builder.Build();
    }
}