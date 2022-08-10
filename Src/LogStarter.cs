using System.IO;
using log4net;

namespace CsLoggingTools
{
    public class LogStarter
    {
        public static void Start(string logConfigFile)
        {
            using (var sm = new FileStream(logConfigFile, FileMode.Open))
            {
                log4net.Config.XmlConfigurator.Configure(sm);
            }
        }

        public static ILog GetLogger(string logName)
        {
            return LogManager.GetLogger(logName);
        }

        public static ILog Start(string logConfigFile, string logName)
        {
            Start(logConfigFile);

            return GetLogger(logName);
        }

        public static void Stop()
        {
            LogManager.Shutdown();
        }
    }
}
