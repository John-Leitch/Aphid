using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Compiler
{
    public static class CodeHelper
    {
        public static CodeVariableReferenceExpression VarRef(string name) =>
             new(name);

        public static CodeVariableDeclarationStatement VarDecl(Type type, string name) =>
             new(type, name);

        public static CodeVariableDeclarationStatement VarDecl(Type type, string name, CodeExpression init) =>
             new(type, name, init);

        public static CodeVariableDeclarationStatement VarDecl(string type, string name) =>
             new(type, name);

        public static CodeVariableDeclarationStatement VarDecl(string type, string name, CodeExpression init) =>
             new(type, name, init);

        public static CodeVariableDeclarationStatement VarDecl(string name) =>
             new("var", name);

        public static CodeVariableDeclarationStatement VarDecl(string name, CodeExpression init) =>
             new("var", name, init);

        public static CodePropertyReferenceExpression PropRef(CodeExpression targetObject, params string[] propertyNames)
        {
            CodePropertyReferenceExpression exp = null;

            foreach (var p in propertyNames)
            {
                exp = new CodePropertyReferenceExpression(exp ?? targetObject, p);
            }

            return exp;
        }

        public static CodePropertyReferenceExpression PropRef(params string[] propertyNames) =>
             PropRef(null, propertyNames);

        public static CodeFieldReferenceExpression FieldRef(CodeExpression targetObject, params string[] propertyNames)
        {
            CodeFieldReferenceExpression exp = null;

            foreach (var p in propertyNames)
            {
                exp = new CodeFieldReferenceExpression(exp ?? targetObject, p);
            }

            return exp;
        }

        public static CodeFieldReferenceExpression FieldRef(params string[] propertyNames) =>
             FieldRef(This(), propertyNames);

        public static CodeBinaryOperatorExpression BinOpExp(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right) =>
             new(left, op, right);

        public static CodeExpression BinOpExpJoin(this IEnumerable<CodeExpression> expressions, CodeBinaryOperatorType op)
        {
            var codeExp = expressions.First();

            foreach (var x in expressions.Skip(1))
            {
                codeExp = BinOpExp(codeExp, op, x);
            }

            return codeExp;
        }

        public static CodeArgumentReferenceExpression Arg(string name) =>
             new(name);

        public static CodeTypeReference TypeRef(Type type) =>
             new(type);

        public static CodeTypeReference TypeRef<T>() =>
             TypeRef(typeof(T));

        public static CodeTypeReference TypeRef(string typeName) =>
             new(typeName);

        public static CodeTypeReferenceExpression TypeRefExp(Type type) =>
             new(type);

        public static CodeTypeReferenceExpression TypeRefExp(string typeName) =>
             new(typeName);

        public static CodeTypeReferenceExpression TypeRefExp<T>() =>
             TypeRefExp(typeof(T));

        public static CodeTypeOfExpression TypeOf(string type) =>
             new(type);

        public static CodeTypeOfExpression TypeOf(Type type) =>
             new(type);

        public static CodeMethodReturnStatement Return(CodeExpression expression) =>
             new(expression);

        public static CodeMethodReturnStatement Return(string variableName) =>
             Return(VarRef(variableName));

        public static CodePrimitiveExpression True() =>
             new(true);

        public static CodePrimitiveExpression False() =>
             new(false);

        public static CodePrimitiveExpression Null() =>
             new();

        public static CodeThisReferenceExpression This() =>
             new();

        public static CodeObjectCreateExpression New(Type createType, params CodeExpression[] parameters) =>
             new(createType, parameters);

        public static CodeObjectCreateExpression New(CodeTypeReference createType, params CodeExpression[] parameters) =>
             new(createType, parameters);

        public static CodeAssignStatement Assign(CodeExpression left, CodeExpression right) =>
             new(left, right);

        public static CodeAssignStatement Assign(string variableName, CodeExpression right) =>
             Assign(VarRef(variableName), right);

        public static CodeAssignStatement Assign(string leftVariableName, string rightVariableName) =>
             Assign(VarRef(leftVariableName), VarRef(rightVariableName));

        public static CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, params CodeExpression[] parameters) =>
             new(targetObject, methodName, parameters);

        public static CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, CodeTypeReference[] typeParameters, params CodeExpression[] parameters) =>
             new(new CodeMethodReferenceExpression(targetObject, methodName, typeParameters), parameters);

        public static CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, string[] typeParameters, params CodeExpression[] parameters) =>
             Invoke(
                targetObject,
                methodName,
                typeParameters.Select(x => new CodeTypeReference(x)).ToArray(), parameters);

        public static CodeMethodInvokeExpression Invoke(string methodName, params CodeExpression[] parameters) =>
             Invoke(null, methodName, parameters);

        public static CodeIterationStatement While(CodeExpression testExpression, params CodeStatement[] statements) =>
             new(
                new CodeSnippetStatement(""),
                testExpression,
                new CodeSnippetStatement(""),
                statements);

        public static CodeExpressionStatement Stmt(CodeExpression expression) =>
             new(expression);

        public static CodeExpression Eq(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.ValueEquality, right);

        public static CodeExpression LessThan(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.LessThan, right);

        public static CodeExpression LessThanEq(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.LessThanOrEqual, right);

        public static CodeExpression GreaterThan(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.GreaterThan, right);

        public static CodeExpression GreaterThanEq(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.GreaterThanOrEqual, right);

        public static CodeExpression Add(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.Add, right);

        public static CodeExpression Sub(CodeExpression left, CodeExpression right) =>
             BinOpExp(left, CodeBinaryOperatorType.Subtract, right);

        public static CodeExpression Inc(CodeVariableReferenceExpression exp) =>
             IncDec(exp, CodeBinaryOperatorType.Add);

        public static CodeExpression Dec(CodeVariableReferenceExpression exp) =>
             IncDec(exp, CodeBinaryOperatorType.Subtract);

        private static CodeExpression IncDec(CodeVariableReferenceExpression exp, CodeBinaryOperatorType op) =>
             BinOpExp(
                exp,
                CodeBinaryOperatorType.Assign,
                BinOpExp(exp, op, new CodePrimitiveExpression(1)));

        public static CodeAssignStatement IncStmt(CodeVariableReferenceExpression exp) =>
             IncDecStmt(exp, CodeBinaryOperatorType.Add);

        public static CodeAssignStatement DecStmt(CodeVariableReferenceExpression exp) =>
             IncDecStmt(exp, CodeBinaryOperatorType.Subtract);

        private static CodeAssignStatement IncDecStmt(CodeVariableReferenceExpression exp, CodeBinaryOperatorType op) =>
             Assign(exp, BinOpExp(exp, op, new CodePrimitiveExpression(1)));

        public static CodePrimitiveExpression Value(int value) =>
             new(value);

        public static CodePrimitiveExpression Value(string value) =>
             new(value);

        public static void AddRange(this CodeStatementCollection collection, params CodeStatement[] statements) =>
             collection.AddRange(statements);
    }
}
