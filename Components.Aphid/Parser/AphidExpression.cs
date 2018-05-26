using System;
using System.Runtime.Serialization;

namespace Components.Aphid.Parser
{
    [Serializable, DataContract(IsReference = true)]
    public abstract class AphidExpression : AphidNode
    {
        private int _index = -1;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        private int _length = -1;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public string Code { get; set; }

        public string Filename { get; set; }

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
            Code = expression.Code;

            return this;
        }
    }
}

