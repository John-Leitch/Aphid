using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class AphidAttributeScanner
    {
        private readonly Queue<string> _attributes;

        public string CurrentAttribute { get; private set; }

        public AphidAttributeScanner(IdentifierExpression owner)
        {
            _attributes = new Queue<string>(
                owner.Attributes.Select(x => x.Identifier));
        }

        public bool Next()
        {
            CurrentAttribute = null;

            if (EndOfStream())
            {
                return false;
            }

            CurrentAttribute = _attributes.Dequeue();

            return true;
        }

        public bool Match(string name)
        {
            if (CurrentAttribute == name)
            {
                Next();

                return true;
            }

            return false;
        }

        public void Require(string name)
        {
            if (CurrentAttribute != name)
            {
                throw new AphidParserException(
                    "Expected attribute {0}, found {1}.",
                    name,
                    CurrentAttribute);
            }

            Next();
        }

        public bool EndOfStream() => _attributes.Count == 0 && CurrentAttribute == null;
    }
}
