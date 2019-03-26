using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    public interface ILogger
    {
        void Error(string loggerName, string message);
        void Debug(string loggerName, string message);
        void Warn(string loggerName, string message);
        void Info(string loggerName, string message);
    }
}
