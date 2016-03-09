using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace AphidCodeGenerator
{
    public static class CodeHelper
    {
        public static CodeVariableReferenceExpression VarRef(string name)
        {
            return new CodeVariableReferenceExpression(name);
        }

        public static CodeVariableDeclarationStatement VarDecl(Type type, string name)
        {
            return new CodeVariableDeclarationStatement(type, name);
        }

        public static CodeVariableDeclarationStatement VarDecl(Type type, string name, CodeExpression init)
        {
            return new CodeVariableDeclarationStatement(type, name, init);
        }

        public static CodeVariableDeclarationStatement VarDecl(string type, string name)
        {
            return new CodeVariableDeclarationStatement(type, name);
        }

        public static CodeVariableDeclarationStatement VarDecl(string type, string name, CodeExpression init)
        {
            return new CodeVariableDeclarationStatement(type, name, init);
        }

        public static CodeVariableDeclarationStatement VarDecl(string name)
        {
            return new CodeVariableDeclarationStatement("var", name);
        }

        public static CodeVariableDeclarationStatement VarDecl(string name, CodeExpression init)
        {
            return new CodeVariableDeclarationStatement("var", name, init);
        }

        public static CodePropertyReferenceExpression PropRef(CodeExpression targetObject, params string[] propertyNames)
        {
            CodePropertyReferenceExpression exp = null;

            foreach (var p in propertyNames)
            {
                exp = new CodePropertyReferenceExpression(exp ?? targetObject, p);
            }

            return exp;
        }

        public static CodePropertyReferenceExpression PropRef(params string[] propertyNames)
        {
            return PropRef(null, propertyNames);
        }

        public static CodeFieldReferenceExpression FieldRef(CodeExpression targetObject, params string[] propertyNames)
        {
            CodeFieldReferenceExpression exp = null;

            foreach (var p in propertyNames)
            {
                exp = new CodeFieldReferenceExpression(exp ?? targetObject, p);
            }

            return exp;
        }

        public static CodeFieldReferenceExpression FieldRef(params string[] propertyNames)
        {
            return FieldRef(This(), propertyNames);
        }

        public static CodeBinaryOperatorExpression BinOpExp(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression(left, op, right);
        }

        public static CodeExpression BinOpExpJoin(this IEnumerable<CodeExpression> expressions, CodeBinaryOperatorType op)
        {
            CodeExpression codeExp = expressions.First();

            foreach (var x in expressions.Skip(1))
            {
                codeExp = CodeHelper.BinOpExp(codeExp, op, x);
            }

            return codeExp;
        }

        public static CodeArgumentReferenceExpression Arg(string name)
        {
            return new CodeArgumentReferenceExpression(name);
        }

        public static CodeTypeReference TypeRef(Type type)
        {
            return new CodeTypeReference(type);
        }

        public static CodeTypeReference TypeRef<T>()
        {
            return TypeRef(typeof(T));
        }

        public static CodeTypeReference TypeRef(string typeName)
        {
            return new CodeTypeReference(typeName);
        }

        public static CodeTypeReferenceExpression TypeRefExp(Type type)
        {
            return new CodeTypeReferenceExpression(type);
        }

        public static CodeTypeReferenceExpression TypeRefExp(string typeName)
        {
            return new CodeTypeReferenceExpression(typeName);
        }

        public static CodeTypeReferenceExpression TypeRefExp<T>()
        {
            return TypeRefExp(typeof(T));
        }

        public static CodeTypeOfExpression TypeOf(string type)
        {
            return new CodeTypeOfExpression(type);
        }

        public static CodeTypeOfExpression TypeOf(Type type)
        {
            return new CodeTypeOfExpression(type);
        }

        public static CodeMethodReturnStatement Return(CodeExpression expression)
        {
            return new CodeMethodReturnStatement(expression);
        }

        public static CodeMethodReturnStatement Return(string variableName)
        {
            return Return(CodeHelper.VarRef(variableName));
        }

        public static CodePrimitiveExpression True()
        {
            return new CodePrimitiveExpression(true);
        }

        public static CodePrimitiveExpression False()
        {
            return new CodePrimitiveExpression(false);
        }

        public static CodePrimitiveExpression Null()
        {
            return new CodePrimitiveExpression();
        }

        public static CodeThisReferenceExpression This()
        {
            return new CodeThisReferenceExpression();
        }

        public static CodeObjectCreateExpression New(Type createType, params CodeExpression[] parameters)
        {
            return new CodeObjectCreateExpression(createType, parameters);
        }

        public static CodeObjectCreateExpression New(CodeTypeReference createType, params CodeExpression[] parameters)
        {
            return new CodeObjectCreateExpression(createType, parameters);
        }

        public static CodeAssignStatement Assign(CodeExpression left, CodeExpression right)
        {
            return new CodeAssignStatement(left, right);
        }

        public static CodeAssignStatement Assign(string variableName, CodeExpression right)
        {
            return Assign(VarRef(variableName), right);
        }

        public static CodeAssignStatement Assign(string leftVariableName, string rightVariableName)
        {
            return Assign(VarRef(leftVariableName), VarRef(rightVariableName));
        }

        public static CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, params CodeExpression[] parameters)
        {
            return new CodeMethodInvokeExpression(targetObject, methodName, parameters);
        }

        public static CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, CodeTypeReference[] typeParameters, params CodeExpression[] parameters)
        {
            var methodRef = new CodeMethodReferenceExpression(targetObject, methodName, typeParameters);

            return new CodeMethodInvokeExpression(methodRef, parameters);
        }

        public static CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, string[] typeParameters, params CodeExpression[] parameters)
        {
            return Invoke(
                targetObject,
                methodName,
                typeParameters.Select(x => new CodeTypeReference(x)).ToArray(),
                parameters);
        }

        public static CodeMethodInvokeExpression Invoke(string methodName, params CodeExpression[] parameters)
        {
            return Invoke(null, methodName, parameters);
        }

        public static CodeIterationStatement While(CodeExpression testExpression, params CodeStatement[] statements)
        {
            return new CodeIterationStatement(
                new CodeSnippetStatement(""),
                testExpression,
                new CodeSnippetStatement(""),
                statements);
        }

        public static CodeExpressionStatement Stmt(CodeExpression expression)
        {
            return new CodeExpressionStatement(expression);
        }

        public static CodeExpression Eq(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.ValueEquality, right);
        }

        public static CodeExpression LessThan(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.LessThan, right);
        }

        public static CodeExpression LessThanEq(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.LessThanOrEqual, right);
        }

        public static CodeExpression GreaterThan(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.GreaterThan, right);
        }

        public static CodeExpression GreaterThanEq(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.GreaterThanOrEqual, right);
        }

        public static CodeExpression Add(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.Add, right);
        }

        public static CodeExpression Sub(CodeExpression left, CodeExpression right)
        {
            return CodeHelper.BinOpExp(left, CodeBinaryOperatorType.Subtract, right);
        }

        public static CodeExpression Inc(CodeVariableReferenceExpression exp)
        {
            return IncDec(exp, CodeBinaryOperatorType.Add);
        }

        public static CodeExpression Dec(CodeVariableReferenceExpression exp)
        {
            return IncDec(exp, CodeBinaryOperatorType.Subtract);
        }

        private static CodeExpression IncDec(
            CodeVariableReferenceExpression exp, 
            CodeBinaryOperatorType op)
        {
            return CodeHelper.BinOpExp(
                exp,
                CodeBinaryOperatorType.Assign,
                CodeHelper.BinOpExp(
                    exp,
                    op,
                    new CodePrimitiveExpression(1)));
        }

        public static CodeAssignStatement IncStmt(CodeVariableReferenceExpression exp)
        {
            return IncDecStmt(exp, CodeBinaryOperatorType.Add);
        }

        public static CodeAssignStatement DecStmt(CodeVariableReferenceExpression exp)
        {
            return IncDecStmt(exp, CodeBinaryOperatorType.Subtract);
        }

        private static CodeAssignStatement IncDecStmt(
            CodeVariableReferenceExpression exp,
            CodeBinaryOperatorType op)
        {
            return CodeHelper.Assign(
                exp,
                CodeHelper.BinOpExp(
                    exp,
                    op,
                    new CodePrimitiveExpression(1)));
        }

        public static CodePrimitiveExpression Value(int value)
        {
            return new CodePrimitiveExpression(value);
        }

        public static CodePrimitiveExpression Value(string value)
        {
            return new CodePrimitiveExpression(value);
        }

        public static void AddRange(
            this CodeStatementCollection collection,
            params CodeStatement[] statements)
        {
            collection.AddRange(statements);
        }
    }
}
