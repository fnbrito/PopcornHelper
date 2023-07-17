using Microsoft.Extensions.Logging;

namespace PopcornHelper
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            LoadConfigurationFile();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            
#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


        public static void LoadConfigurationFile()
        {
            const string dotenv = ""; // .env file path here
            
            // This will load the configuration file (.env) into the environment variables
            DotEnv.Load(dotenv);

            /*
             * The correct way to grab this would be to issue the following:
             * var root = Directory.GetCurrentDirectory();
             * var dotenv = Path.Combine(root, ".env");
             * But for some reason, this yields window's system32 folder.
             * https://github.com/dotnet/maui/issues/8091
             * No response on the issue yet.
             */
        }
    }
}