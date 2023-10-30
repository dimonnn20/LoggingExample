using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingExample
{
    public static class Logger
    {
        public static ILog log { get; } = LogManager.GetLogger(typeof(Logger));
        static Logger()
        { 
        XmlConfigurator.Configure(new System.IO.FileInfo("C:/Users/makad/source/repos/LoggingExample/LoggingExample/log4net.config"));
        }

    }
}
