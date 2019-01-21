using System.CodeDom;

namespace Components.Aphid.Compiler
{
    public static class CodeExpressionExtension
    {
        public static CodePropertyReferenceExpression GetProperty(this CodeExpression expression, string name) =>
            new CodePropertyReferenceExpression(expression, name);

        public static CodeMethodReferenceExpression GetMethod(this CodeExpression expression, string name) =>
            new CodeMethodReferenceExpression(expression, name);

        public static CodeMethodInvokeExpression InvokeMethod(
            this CodeExpression expression,
            string name,
            params CodeExpression[] parameters) =>
            new CodeMethodReferenceExpression(expression, name).Invoke(parameters);
    }
}
