using Microsoft.Extensions.Logging;

namespace SmartWMS.Utils
{
    public class Logger : ILogger
    {
        private readonly string Category;

        public IDisposable BeginScope<TState>(TState state) => null!;

        public bool IsEnabled(LogLevel logLevel) => true;

        public Logger(string category)
        {
            Category = category;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string message = formatter(state, exception);
//#if ANDROID
//            Java.Lang.Throwable? throwable = null;

//            if (exception is not null)
//            {
//                throwable = Java.Lang.Throwable.FromException(exception);
//            }

//            switch (logLevel)
//            {
//                case LogLevel.Trace:
//                    Android.Util.Log.Verbose(Category, throwable, message);
//                    break;

//                case LogLevel.Debug:
//                    Android.Util.Log.Debug(Category, throwable, message);
//                    break;

//                case LogLevel.Information:
//                    Android.Util.Log.Info(Category, throwable, message);
//                    break;

//                case LogLevel.Warning:
//                    Android.Util.Log.Warn(Category, throwable, message);
//                    break;

//                case LogLevel.Error:
//                    Android.Util.Log.Error(Category, throwable, message);
//                    break;

//                case LogLevel.Critical:
//                    Android.Util.Log.Wtf(Category, throwable, message);
//                    break;
//            }
//#else
            switch (logLevel)
            {
                case LogLevel.Trace:
                    this.LogTrace( message);
                    break;

                case LogLevel.Debug:
                    this.LogDebug(message);
                    break;

                case LogLevel.Information:
                    this.LogInformation( message);
                    break;

                case LogLevel.Warning:
                    this.LogWarning(message);
                    break;

                case LogLevel.Error:
                    this.LogError(message);
                    break;

                case LogLevel.Critical:
                    this.LogCritical(message);
                    break;
            }
//#endif
        }
    }
}