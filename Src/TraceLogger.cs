using log4net;

namespace CsLoggingTools
{
    public abstract class TraceLogger
    {
        public abstract void Log(string text, params object[] args);

        public static TraceLogger Null()
        {
            return new NullTraceLogger();
        }

        public static TraceLogger Active()
        {
            return Active(Main.Log);
        }

        public static TraceLogger Active(ILog log)
        {
            return new ActiveTraceLogger(log);
        }

        private class ActiveTraceLogger : TraceLogger
        {
            private readonly ILog log;
            public ActiveTraceLogger(ILog log)
            {
                this.log = log;
            }

            public override void Log(string text, params object[] args)
            {
                this.log.DebugFormat(text, args);
            }
        }

        private class NullTraceLogger : TraceLogger
        {
            public override void Log(string text, params object[] args)
            {
            }
        }
    }
}
