using System.Xml.Serialization;

namespace Components.Aphid.Compiler
{
    public class BuildNumber
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        public BuildNumber()
        {
        }

        public BuildNumber(string name)
            : this(name, 0)
        {
        }

        public BuildNumber(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
