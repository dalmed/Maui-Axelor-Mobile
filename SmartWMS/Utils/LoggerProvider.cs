using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWMS.Utils
{

    public class LoggerProvider : ILoggerProvider
    {
        public LoggerProvider()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            int lastDotPos = categoryName.LastIndexOf('.');
            if (lastDotPos > 0)
            {
                categoryName = categoryName.Substring(lastDotPos + 1);
            }

            return new Logger(categoryName);
        }

        public void Dispose() { }
    }
}
