using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser.Fluent
{
    public static class AphidExpressionExtension
    {
        public static ArrayExpression ToArray(this AphidExpression expression) => (ArrayExpression)expression;

        public static BinaryOperatorExpression ToBinaryOperator(this AphidExpression expression) => (BinaryOperatorExpression)expression;

        public static BooleanExpression ToBoolean(this AphidExpression expression) => (BooleanExpression)expression;

        public static BreakExpression ToBreak(this AphidExpression expression) => (BreakExpression)expression;

        public static CallExpression ToCall(this AphidExpression expression) => (CallExpression)expression;

        public static DoWhileExpression ToDoWhile(this AphidExpression expression) => (DoWhileExpression)expression;

        public static ExtendExpression ToExtend(this AphidExpression expression) => (ExtendExpression)expression;

        public static ForExpression ToFor(this AphidExpression expression) => (ForExpression)expression;

        public static LoadLibraryExpression ToLoadLibrary(this AphidExpression expression) => (LoadLibraryExpression)expression;

        public static FunctionExpression ToFunction(this AphidExpression expression) => (FunctionExpression)expression;

        public static IdentifierExpression ToIdentifier(this AphidExpression expression) => (IdentifierExpression)expression;

        public static LoadScriptExpression ToLoadScript(this AphidExpression expression) => (LoadScriptExpression)expression;

        public static NullExpression ToNull(this AphidExpression expression) => (NullExpression)expression;

        public static ObjectExpression ToObject(this AphidExpression expression) => (ObjectExpression)expression;

        public static PartialFunctionExpression ToPartialFunction(this AphidExpression expression) => (PartialFunctionExpression)expression;

        public static PatternMatchingExpression ToPatternMatching(this AphidExpression expression) => (PatternMatchingExpression)expression;

        public static SwitchExpression ToSwitch(this AphidExpression expression) => (SwitchExpression)expression;

        public static TernaryOperatorExpression ToTernaryOperator(this AphidExpression expression) => (TernaryOperatorExpression)expression;

        public static ThisExpression ToThis(this AphidExpression expression) => (ThisExpression)expression;

        public static TryExpression ToTry(this AphidExpression expression) => (TryExpression)expression;

        public static UnaryOperatorExpression ToUnaryOperator(this AphidExpression expression) => (UnaryOperatorExpression)expression;

        public static WhileExpression ToWhile(this AphidExpression expression) => (WhileExpression)expression;

        public static StringExpression ToString(this AphidExpression expression) => (StringExpression)expression;

        public static IfExpression ToIf(this AphidExpression expression) => (IfExpression)expression;

        public static DynamicMemberExpression ToDynamicMember(this AphidExpression expression) => (DynamicMemberExpression)expression;

        public static NumberExpression ToNumber(this AphidExpression expression) => (NumberExpression)expression;

        public static ArrayAccessExpression ToArrayAccess(this AphidExpression expression) => (ArrayAccessExpression)expression;

        public static ForEachExpression ToForEach(this AphidExpression expression) => (ForEachExpression)expression;
    }
}
