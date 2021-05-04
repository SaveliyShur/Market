using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Loggers
{
    public interface ILogger
    {
        void debug(string message, string arg = null);
        void error(string message, string arg = null);
        void info(string message, string arg = null);
        void warning(string message, string arg = null);
        void fatal(string message, string arg = null);

    }
}
