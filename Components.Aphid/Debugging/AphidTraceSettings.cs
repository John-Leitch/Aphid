using System.Diagnostics;

namespace Components.Aphid.Debugging
{
    public class AphidTraceSettings
    {
        public const string DefaultTimestampFormat = "[MM-dd-yy.HH:mm:ss]";

        private static AphidTraceSettings _default = new AphidTraceSettings
        {
            TraceTimestamp = true,
            TimestampFormat = DefaultTimestampFormat,
            DefaultMessageTraceLevel = TraceLevel.Info,
            TraceAphidStack = true,
            TraceCurrentExpression = true,
            TraceCurrentStatement = true,
            TraceClrStack = true
        };

        public static AphidTraceSettings Default
        {
            get => _default;
            set => _default = value;
        }

        public bool TraceTimestamp { get; set; }

        public string TimestampFormat { get; set; }

        public TraceLevel DefaultMessageTraceLevel { get; set; }

        public bool TraceCurrentStatement { get; set; }

        public bool TraceCurrentExpression { get; set; }

        public bool TraceAphidStack { get; set; }

        public bool TraceClrStack { get; set; }
    }
}
