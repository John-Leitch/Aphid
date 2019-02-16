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
            switch (Type)
            {
                case AphidExpressionType.IfExpression:
                case AphidExpressionType.ForExpression:
                case AphidExpressionType.ForEachExpression:
                case AphidExpressionType.WhileExpression:
                case AphidExpressionType.DoWhileExpression:
                case AphidExpressionType.ExtendExpression:
                case AphidExpressionType.TryExpression:
                case AphidExpressionType.SwitchExpression:
                    return true;

                default:
                    return false;
            }
        }
    }
}

