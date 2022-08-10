using log4net;

namespace CsLoggingTools
{
    public class Main
    {
        private static ILog log;
        public static ILog NullLog;
        
        static Main()
        {
            NullLog = LogManager.GetLogger("Guns n' Roses");

            //set to a null object for the case we don't initialize the member
            log = NullLog; 
        }

        public static ILog Log
        {
            get
            {
                return log;
            }
            set
            {
                if (log == null || log == NullLog)
                {
                    //This lines are here to prevent further complications when multiple applications running in an integrated environment (such as IntegUi) are trying to set this static property individually.
                    log = value;
                }
            }
        }

        public static void Clear()
        {
            log = NullLog;
        }
    }
}
