using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    public class LoggerService : ILogger
    {
        public void Info(string loggerName, string message)
        {
            ILog logger = LogManager.GetLogger(loggerName);
            logger.Info(message);
        }

        public void Warn(string loggerName, string message)
        {
            ILog logger = LogManager.GetLogger(loggerName);
            logger.Warn(message);
        }

        public void Error(string loggerName, string message)
        {
            ILog logger = LogManager.GetLogger(loggerName);
            logger.Error(message);
        }

        public void Debug(string loggerName, string message)
        {
            ILog logger = LogManager.GetLogger(loggerName);
            logger.Debug(message);
        }
    }
}
