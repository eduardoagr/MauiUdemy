using Microsoft.Extensions.Logging;

using Mopups.Hosting;
using Mopups.Services;

namespace MauiMopUp {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMopups()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(MopupService.Instance);
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>(); // Use typeof to make it generic
            builder.Services.AddTransient<MyPopupPage>(); // Use typeof to make it gener
            builder.Services.AddTransient<MyPopupPageViewModel>();
            return builder.Build();
        }
    }
}
