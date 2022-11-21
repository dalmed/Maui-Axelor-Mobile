using Microsoft.Extensions.Logging;
using SmartWMS.Services;
using SmartWMS.Utils;

namespace SmartWMS;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
       => MauiApp.CreateBuilder()
           .UseMauiApp<App>()
           .RegisterAppServices()
           .RegisterViewModels()
           .RegisterViews()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
          .Build();

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        //  [assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

        string cfgLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config");
        FileInfo fi = new FileInfo(cfgLog);
        log4net.Config.XmlConfigurator.Configure(fi);



        //        mauiAppBuilder.Services.AddSingleton<IRestClientService, RestClientService>();
        //        mauiAppBuilder.Services.AddSingleton<IUserService, UserService>();

        //        mauiAppBuilder.Services.AddLogging(configure =>
        //         {
        //#if DEBUG
        //             LogLevel logLevel = LogLevel.Debug;
        //#else
        //    LogLevel logLevel = LogLevel.Information;
        //#endif

        //             configure.AddProvider(new LoggerProvider())
        //                         .AddFilter("MyMauiApp", logLevel);

        //         });

        DependencyService.Register<RestClientService>();
        DependencyService.Register<UserService>();
        DependencyService.Register<Logger>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        //mauiAppBuilder.Services.AddSingleton<ViewModels.MainPageModel>();

        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
       //mauiAppBuilder.Services.AddTransient<Views.MainPage>();
       // Routing.RegisterRoute("Main", typeof(Views.MainPage));
        return mauiAppBuilder;
    }
}
