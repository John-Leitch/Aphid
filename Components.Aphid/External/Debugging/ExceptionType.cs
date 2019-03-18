namespace Components.Cypress
{
    public static class ExceptionType
    {
        private const string _avSuffix = "AV";

        public const string
            Exception = "Exception",
            Breakpoint = "Breakpoint",
            ReadAV = "Read" + _avSuffix,
            WriteAV = "Write" + _avSuffix,
            DepAV = "DEP" + _avSuffix,
            UnknownAV = "Unknown" + _avSuffix;

        public static readonly string[] Types = new[]
        {
            Exception,
            Breakpoint,
            ReadAV,
            WriteAV,
            DepAV,
            UnknownAV
        };
    }
}
