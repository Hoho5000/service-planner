using ServicePlanner.Data;
using ServicePlanner.Shared;

namespace ServicePlanner;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddSingleton<DataContext>();
        builder.Services.AddSingleton<PdfService>();
        builder.Services.AddLocalization();

        return builder.Build();
    }
}
