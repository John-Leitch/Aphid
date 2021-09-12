using System;
using System.Runtime.Serialization;

namespace Components.Aphid.Parser
{
    [Serializable, DataContract(IsReference = true)]
    public abstract class AphidNode
    {
        [field:NonSerialized]
        public abstract AphidExpressionType Type { get; }

        public bool IsStatement()
        {
            return Type switch
            {
                AphidExpressionType.IfExpression or
                    AphidExpressionType.ForExpression or
                    AphidExpressionType.ForEachExpression or
                    AphidExpressionType.WhileExpression or
                    AphidExpressionType.DoWhileExpression or
                    AphidExpressionType.ExtendExpression or
                    AphidExpressionType.TryExpression or
                    AphidExpressionType.SwitchExpression => true,
                _ => false,
            };
        }
    }
}

