using CadastroClientesMAUI.Resources.Interface;
using CadastroClientesMAUI.Resources.Services;
using Microsoft.Extensions.Logging;

namespace CadastroClientesMAUI
{
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

            // Registrar o HttpClient
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<IClienteService, ClienteService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
