global using CommunityToolkit.Maui;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

global using Microsoft.Extensions.Logging;

global using Newtonsoft.Json;

global using System.Collections.ObjectModel;
global using System.Diagnostics;
global using System.Globalization;
global using System.Net.Http.Json;
global using System.Text.Json;

global using YU_GI_OH.Interfaces;
global using YU_GI_OH.Model;
global using YU_GI_OH.Services;
global using YU_GI_OH.View;
global using YU_GI_OH.ViewModel;

using SkiaSharp.Views.Maui.Controls.Hosting;

namespace YU_GI_OH;
public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseSkiaSharp()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Register HttpClient
        builder.Services.AddSingleton<HttpClient>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<IHttpService, HttpService>();
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<CardsPage>();
        builder.Services.AddTransient<CardDetailPage>();
        builder.Services.AddTransient<CardDetailPageViewModel>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddTransient<CardsPageViewModel>();



        return builder.Build();
    }
}