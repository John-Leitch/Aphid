using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public enum AphidNodeType
    {
        ArrayAccessExpression,
        ArrayExpression,
        BinaryOperatorExpression,
        BooleanExpression,
        BreakExpression,
        CallExpression,
        WhileExpression,
        DoWhileExpression,
        DynamicMemberExpression,
        ElseExpression,
        ExtendExpression,
        ForEachExpression,
        ForExpression,
        FunctionExpression,
        IdentifierExpression,
        IfExpression,
        LoadLibraryExpression,
        LoadScriptExpression,
        MemberExpression,
        NullExpression,
        NumberExpression,
        ObjectExpression,
        PartialFunctionExpression,
        PatternExpression,
        PatternMatchingExpression,
        StringExpression,
        SwitchExpression,
        TernaryOperatorExpression,
        ThisExpression,
        TryExpression,
        UnaryOperatorExpression,
    }
}
