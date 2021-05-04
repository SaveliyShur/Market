using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Loggers
{
    public class MyLogger : ILogger
    {
        //Use Singleton pattern
        private static MyLogger instance;
        private static Logger logger;

        //single constructor
        private MyLogger()
        {
        }

        public static MyLogger getMyLoggerInstance()
        {
            if (instance == null)
                instance = new MyLogger();
            return instance;
        }

        private Logger getLogger(string theLogger)
        {
            if (MyLogger.logger == null)
                MyLogger.logger = LogManager.GetLogger(theLogger);

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
