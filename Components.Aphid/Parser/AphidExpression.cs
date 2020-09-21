using System;
using System.Runtime.Serialization;

namespace Components.Aphid.Parser
{
    [Serializable, DataContract(IsReference = true)]
    public abstract class AphidExpression : AphidNode
    {
        //[field:NonSerialized]
        public AphidExpressionContext Context { get; set; }

        public int Index { get; set; } = -1;

        public int Length { get; set; } = -1;

        [field:NonSerialized]
        public string Code
        {
            get => Context.Code;
            set => Context.Code = value;
        }

        [field:NonSerialized]
        public string Filename
        {
            get => Context.Filename;
            set => Context.Filename = value;
        }

#if APHID_DEBUGGING_ENABLED
        public bool HasBreakpoint { get; set; }
#endif

        public override string ToString() => Code != null && Index != -1 && Length != -1 ? Code.Substring(Index, Length) : base.ToString();

        public AphidExpression WithPositionFrom(AphidExpression expression)
        {
            Index = expression.Index;
            Length = expression.Length;
            Context = expression.Context;

            return this;
        }

        //[OnSerialized()]
        //internal void OnSerializingMethod(StreamingContext context)
        //{
        //    //context.State.HasFlag
        //}

        //[OnDeserialized()]
        //internal void OnDeserializingMethod(StreamingContext context)
        //{
        //    //context.
        //}
    }
}

