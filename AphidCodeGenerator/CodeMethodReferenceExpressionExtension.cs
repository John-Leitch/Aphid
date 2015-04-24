using System.CodeDom;

namespace AphidCodeGenerator
{
    public static class CodeMethodReferenceExpressionExtension
    {
        public static CodeMethodInvokeExpression Invoke(this CodeMethodReferenceExpression expression, params CodeExpression[] parameters)
        {
            return new CodeMethodInvokeExpression(expression, parameters);
        }

        
    }
}
