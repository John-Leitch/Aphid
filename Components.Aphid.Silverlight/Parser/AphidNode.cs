using System;

namespace Components.Aphid.Parser
{
    public abstract class AphidNode
    {
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

