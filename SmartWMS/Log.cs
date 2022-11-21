using System.Reflection;
using log4net;

namespace SmartWMS
{
    public class Log
    {
        private static readonly Log Instance = new Log();
        protected ILog MonitoringLogger;
        protected static ILog DebugLogger;

        private Log()
        {
            MonitoringLogger = LogManager.GetLogger(Assembly.GetAssembly(typeof(Log)), "MonitoringLogger");
            DebugLogger = LogManager.GetLogger(Assembly.GetAssembly(typeof(Log)), "DebugLogger");
        }

        /// <summary>  
        /// Used to log Debug messages in an explicit Debug Logger  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public static void Debug(string message)
        {
            DebugLogger.Debug(message);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public static void Debug(string message, Exception exception)
        {
            DebugLogger.Debug(message, exception);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public static void Info(string message)
        {
            Instance.MonitoringLogger.Info(message);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public static void Info(string message, Exception exception)
        {
            Instance.MonitoringLogger.Info(message, exception);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public static void Warn(string message)
        {
            Instance.MonitoringLogger.Warn(message);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public static void Warn(string message, Exception exception)
        {
            Instance.MonitoringLogger.Warn(message, exception);
        }

        /// <summary>  
        ///  Error from string
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public static void Error(string message)
        {
            Instance.MonitoringLogger.Error(message);
        }

        /// <summary>
        /// Error from exception
        /// </summary>
        /// <param name="message"></param>
        public static void Error(Exception message)
        {
            Instance.MonitoringLogger.Error(message);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public static void Error(string message, Exception exception)
        {
            Instance.MonitoringLogger.Error(message, exception);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public static void Fatal(string message)
        {
            Instance.MonitoringLogger.Fatal(message);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public static void Fatal(string message, Exception exception)
        {
            Instance.MonitoringLogger.Fatal(message, exception);
        }

        //public static string DbError(Exception ex, IEnumerable<DbEntityValidationResult> validationErrors)
        //{
        //    var log = $" {Environment.NewLine}{ex}{Environment.NewLine}{ex.InnerException}{Environment.NewLine}";
        //    var err = $" {Environment.NewLine}{ex.Message}{Environment.NewLine}";

        //    var dbEntityValidationResults =
        //        validationErrors as DbEntityValidationResult[] ?? validationErrors.ToArray();
        //    if (dbEntityValidationResults.Any())
        //    {
        //        var vld = "DbEntityValidationResult: ";
        //        vld += dbEntityValidationResults.SelectMany(error => error.ValidationErrors).Aggregate(vld,
        //        (current, dbValidationError) =>
        //            current +
        //            $"{dbValidationError.PropertyName}: {dbValidationError.ErrorMessage}{Environment.NewLine}");
        //        log += vld;
        //        err += vld;
        //    }
        //    Instance.MonitoringLogger.Error(log);

        //    return err;
        //}
    }
}