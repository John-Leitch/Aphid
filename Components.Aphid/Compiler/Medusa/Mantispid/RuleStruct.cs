namespace Mantispid
{
    public class RuleStruct
    {
        public string Name { get; }

        public string BaseName { get; }

        public ParserIdentifier[] Properties { get; }

        public RuleStruct(string name, string baseName, ParserIdentifier[] properties)
        {
            Name = name;
            BaseName = baseName;
            Properties = properties;
        }
    }
}
