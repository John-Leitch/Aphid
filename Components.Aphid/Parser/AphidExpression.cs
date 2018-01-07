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
    }
}

