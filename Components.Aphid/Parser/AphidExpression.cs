using System;
using System.Runtime.Serialization;

namespace Components.Aphid.Parser
{
    [Serializable, DataContract(IsReference = true)]
    public abstract class AphidExpression : AphidNode
    {
        private AphidExpressionContext _context;

        public AphidExpressionContext Context
        {
            get => _context;
            set => _context = value;
        }

        private int _index = -1;

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        private int _length = -1;

        public int Length
        {
            get => _length;
            set => _length = value;
        }

        public string Code
        {
            get => _context.Code;
            set => _context.Code = value;
        }

        public string Filename
        {
            get => _context.Filename;
            set => _context.Filename = value;
        }

#if APHID_DEBUGGING_ENABLED
        public bool HasBreakpoint { get; set; }
#endif

        public override string ToString()
        {
            if (Code != null && Index != -1 && Length != -1)
            {
                return Code.Substring(Index, Length);
            }
            else
            {
                return base.ToString();
            }
        }

        public AphidExpression WithPositionFrom(AphidExpression expression)
        {
            Index = expression.Index;
            Length = expression.Length;
            Context = expression.Context;

            return this;
        }
    }
}

