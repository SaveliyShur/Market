using NLog;
using NLog.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Loggers
{
    [ThreadSafe]
    public class MyLogger : ILogger
    {
        //Use Singleton pattern
        private static MyLogger instance;
        private static Logger logger;

        /// <summary>
        /// Объект для синхронизации разных потоков для создание самого объекта
        /// </summary>
        private static object syncMyLogger = new object();

        /// <summary>
        /// Объект для синхронизации разных потоков для создания экземпляра логгера
        /// </summary>
        private static object syncLoggerInstance = new object();

        //single constructor
        private MyLogger() {}

        public static MyLogger getMyLoggerInstance()
        {
            if (instance == null)
            {
                lock (syncMyLogger)
                {
                    if (instance == null)
                        instance = new MyLogger();
                }
            }
            return instance;
        }

        private Logger getLogger(string theLogger)
        {
            if (MyLogger.logger == null)
            {
                lock (syncLoggerInstance)
                {
                    if (MyLogger.logger == null)
                        MyLogger.logger = LogManager.GetLogger(theLogger);
                }
            }

            return MyLogger.logger;
        }

        public void debug(string message, string arg = null)
        {
            if (arg == null)
                getLogger("myAppLogger").Debug(message);
            else
                getLogger("myAppLogger").Debug(message, arg);
        }

        public void error(string message, string arg = null)
        {
            if (arg == null)
                getLogger("myAppLogger").Error(message);
            else
                getLogger("myAppLogger").Error(message, arg);
        }

        public void fatal(string message, string arg = null)
        {
            if (arg == null)
                getLogger("myAppLogger").Fatal(message);
            else
                getLogger("myAppLogger").Fatal(message, arg);
        }

        public void info(string message, string arg = null)
        {
            if (arg == null)
                getLogger("myAppLogger").Info(message);
            else
                getLogger("myAppLogger").Info(message, arg);
        }

        public void warning(string message, string arg = null)
        {
            if (arg == null)
                getLogger("myAppLogger").Warn(message);
            else
                getLogger("myAppLogger").Warn(message, arg);
        }
    }
}
