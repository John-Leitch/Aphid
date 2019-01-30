using System;
using System.Runtime.Serialization;

namespace Components.Aphid.Parser
{
    [Serializable, DataContract(IsReference = true)]
    public abstract class AphidExpression : AphidNode
    {

        public AphidExpressionContext Context { get; set; }

        public int Index { get; set; } = -1;

        public int Length { get; set; } = -1;

        public string Code
        {
            get => Context.Code;
            set => Context.Code = value;
        }

        public string Filename
        {
            get => Context.Filename;
            set => Context.Filename = value;
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

            return base.ToString();
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

