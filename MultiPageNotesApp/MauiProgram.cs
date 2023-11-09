global using CommunityToolkit.Maui;
global using CommunityToolkit.Maui.Alerts;
global using CommunityToolkit.Maui.Core;
global using CommunityToolkit.Maui.Views;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

global using Microsoft.Extensions.Logging;

global using MultiPageNotesApp.Interfaces;
global using MultiPageNotesApp.Models;
global using MultiPageNotesApp.Services;
global using MultiPageNotesApp.View;
global using MultiPageNotesApp.ViewModels;

global using SQLite;

global using System.Collections.ObjectModel;
global using System.Diagnostics;
global using System.Globalization;

namespace MultiPageNotesApp {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900", "AwesomeFont");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "Material");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<AppShell>();

            builder.Services.AddSingleton<IAppService, AppService>();
            builder.Services.AddSingleton<IDataService, DataService>();

            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<HomePageViewModel>();

            builder.Services.AddTransient<AddNotePage>();
            builder.Services.AddTransient<AddNotePageViewModel>();

            builder.Services.AddSingleton<NoteDetailPage>();
            builder.Services.AddTransient<NoteDetailPageViewModel>();

            return builder.Build();
        }
    }
}