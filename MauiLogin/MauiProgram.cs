using Microsoft.Extensions.Logging;

namespace MauiLogin
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("RobotoCondBold.ttf", "RobotoBold");
                    fonts.AddFont("RobotoCondLight.ttf", "RobotoLight");
                    fonts.AddFont("Roboto.ttf", "Roboto");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
