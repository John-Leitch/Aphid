using System;

namespace Components.Aphid.Parser
{
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

