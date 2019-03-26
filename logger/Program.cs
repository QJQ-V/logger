using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    class Program
    {
        static void Main(string[] args)
        {

            var loggerService = new LoggerService();

            try
            {
                loggerService.Info("WebLogger", "测试日志写入!");
                loggerService.Debug("WebLogger", "测试日志写入!");
                loggerService.Error("loginfo", "测试日志写入!");
                loggerService.Warn("loginfo", "测试日志写入!");

                Console.WriteLine("写入成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           

            Console.ReadKey();
        }
    }
}
