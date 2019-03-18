using System.Linq;

namespace Components.Aphid.Parser
{
    public partial class IdentifierExpression : AphidExpression, IParentNode
    {
        public override string ToString() => Code == null ? Identifier : base.ToString();

        // Todo: use Equals and GetHashCode overrides as template for Mantispid.
        public override bool Equals(object obj) =>
            obj is IdentifierExpression other &&
                Identifier == other.Identifier &&
                ((Attributes == null && other.Attributes == null) ||
                (Attributes.SequenceEqual(other.Attributes)));

        public override int GetHashCode()
        {
            const int seed1 = 0x40000000,
                seed2 = seed1 >> 1,
                seed3 = seed2 >> 1,
                seed4 = seed3 >> 1;

            unchecked
            {
                var hash = Identifier != null ? Identifier.GetHashCode() : seed1;

                if (hash == 0)
                {
                    hash = seed2;
                }

                var tmp = Attributes != null ? Attributes.GetHashCode() : seed3;

                if (tmp == 0)
                {
                    tmp = seed4;
                }

                hash *= tmp;

                return hash;
            }
        }
    }
}
