using System.CodeDom;

namespace Components.Aphid.Compiler
{
    public static class CodeMethodReferenceExpressionExtension
    {
        public static CodeMethodInvokeExpression Invoke(this CodeMethodReferenceExpression expression, params CodeExpression[] parameters) =>
            new CodeMethodInvokeExpression(expression, parameters);
    }
}
