using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser.Fluent
{
    public static class AphidExpressionExtension
    {
        public static ArrayExpression ToArray(this AphidExpression expression)
        {
            return (ArrayExpression)expression;
        }

        public static BinaryOperatorExpression ToBinaryOperator(this AphidExpression expression)
        {
            return (BinaryOperatorExpression)expression;
        }

        public static BooleanExpression ToBoolean(this AphidExpression expression)
        {
            return (BooleanExpression)expression;
        }

        public static BreakExpression ToBreak(this AphidExpression expression)
        {
            return (BreakExpression)expression;
        }

        public static CallExpression ToCall(this AphidExpression expression)
        {
            return (CallExpression)expression;
        }

        public static ControlFlowExpression ToControlFlow(this AphidExpression expression)
        {
            return (ControlFlowExpression)expression;
        }

        public static DoWhileExpression ToDoWhile(this AphidExpression expression)
        {
            return (DoWhileExpression)expression;
        }

        public static ExtendExpression ToExtend(this AphidExpression expression)
        {
            return (ExtendExpression)expression;
        }

        public static ForExpression ToFor(this AphidExpression expression)
        {
            return (ForExpression)expression;
        }

        public static LoadLibraryExpression ToLoadLibrary(this AphidExpression expression)
        {
            return (LoadLibraryExpression)expression;
        }

        public static FunctionExpression ToFunction(this AphidExpression expression)
        {
            return (FunctionExpression)expression;
        }

        public static IdentifierExpression ToIdentifier(this AphidExpression expression)
        {
            return (IdentifierExpression)expression;
        }

        public static LoadScriptExpression ToLoadScript(this AphidExpression expression)
        {
            return (LoadScriptExpression)expression;
        }

        public static NullExpression ToNull(this AphidExpression expression)
        {
            return (NullExpression)expression;
        }

        public static ObjectExpression ToObject(this AphidExpression expression)
        {
            return (ObjectExpression)expression;
        }

        public static PartialFunctionExpression ToPartialFunction(this AphidExpression expression)
        {
            return (PartialFunctionExpression)expression;
        }

        public static PatternMatchingExpression ToPatternMatching(this AphidExpression expression)
        {
            return (PatternMatchingExpression)expression;
        }

        public static SwitchExpression ToSwitch(this AphidExpression expression)
        {
            return (SwitchExpression)expression;
        }

        public static TernaryOperatorExpression ToTernaryOperator(this AphidExpression expression)
        {
            return (TernaryOperatorExpression)expression;
        }

        public static ThisExpression ToThis(this AphidExpression expression)
        {
            return (ThisExpression)expression;
        }

        public static TryExpression ToTry(this AphidExpression expression)
        {
            return (TryExpression)expression;
        }

        public static UnaryOperatorExpression ToUnaryOperator(this AphidExpression expression)
        {
            return (UnaryOperatorExpression)expression;
        }

        public static WhileExpression ToWhile(this AphidExpression expression)
        {
            return (WhileExpression)expression;
        }

        public static StringExpression ToString(this AphidExpression expression)
        {
            return (StringExpression)expression;
        }

        public static IfExpression ToIf(this AphidExpression expression)
        {
            return (IfExpression)expression;
        }

        public static DynamicMemberExpression ToDynamicMember(this AphidExpression expression)
        {
            return (DynamicMemberExpression)expression;
        }

        public static NumberExpression ToNumber(this AphidExpression expression)
        {
            return (NumberExpression)expression;
        }

        public static ArrayAccessExpression ToArrayAccess(this AphidExpression expression)
        {
            return (ArrayAccessExpression)expression;
        }

        public static ForEachExpression ToForEach(this AphidExpression expression)
        {
            return (ForEachExpression)expression;
        }
    }
}
