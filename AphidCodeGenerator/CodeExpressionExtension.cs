using System.CodeDom;

namespace AphidCodeGenerator
{
    public static class CodeExpressionExtension
    {
        public static CodePropertyReferenceExpression GetProperty(this CodeExpression expression, string name)
        {
            return new CodePropertyReferenceExpression(expression, name);
        }

        public static CodeMethodReferenceExpression GetMethod(this CodeExpression expression, string name)
        {
            return new CodeMethodReferenceExpression(expression, name);
        }

        public static CodeMethodInvokeExpression InvokeMethod(
            this CodeExpression expression, 
            string name, 
            params CodeExpression[] parameters)
        {
            return new CodeMethodReferenceExpression(expression, name).Invoke(parameters);
        }
    }
}
