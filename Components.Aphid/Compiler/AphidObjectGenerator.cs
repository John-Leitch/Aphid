using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.CodeDom;
using System.Linq;
using System.Reflection;

namespace Components.Aphid.Compiler
{
    public class AphidObjectGenerator : IAphidCodeObject
    {
        private static readonly Type[] _types = new Type[]
        {
            typeof(byte),
            typeof(sbyte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
        };

        private static readonly Type[] _arrayTypes = new Type[]
        {
            typeof(decimal),
            typeof(string),
            typeof(bool),
        };

        public string CodeFile => @"Interpreter\AphidObject.g.cs";

        private static CodeMethodInvokeExpression CreateSetValue(CodeExpression src)
        {
            return CodeHelper
                .Arg("property")
                .GetMethod("SetValue")
                .Invoke(new CodeExpression[]
                {
                    CodeHelper.Arg("destObj"),
                    src,
                    CodeHelper.Null()
                });
        }

        private static CodeConditionStatement CreateSetValueCondition(Type type, CodeExpression src)
        {
            var prop = CodeHelper.Arg("property");
            var propType = prop.GetProperty("PropertyType");
            var setValue = CreateSetValue(src);
            var condition = new CodeConditionStatement();
            condition.Condition = new CodeBinaryOperatorExpression(
                propType,
                CodeBinaryOperatorType.ValueEquality,
                CodeHelper.TypeOf(type));

            condition.TrueStatements.Add(setValue);
            condition.TrueStatements.Add(CodeHelper.Return(CodeHelper.True()));
            return condition;
        }

        private static CodeConditionStatement CreateNumberSetValueCondition(Type type)
        {
            return CreateSetValueCondition(
                type,
                CodeHelper
                    .TypeRefExp(typeof(Convert))
                    .GetMethod("To" + type.Name)
                    .Invoke(CodeHelper.Arg("srcObj").GetProperty("Value")));
        }

        private static CodeConditionStatement CreateArraySetValueCondition(Type type)
        {
            var lambda = type == typeof(decimal) ? "x => x.GetNumber()" :
                type == typeof(bool) ? "x => x.GetBool()" :
                type == typeof(string) ? "x => x.GetString()" :
                $"x => ({type.FullName})x.GetNumber()";

            var toArray = CodeHelper
                .Arg("srcObj")
                .InvokeMethod("GetList")
                .InvokeMethod("Select",
                    new CodeSnippetExpression(lambda))
                .InvokeMethod("ToArray");
            return CreateSetValueCondition(type.MakeArrayType(), toArray);
        }

        private static CodeMemberMethod TrySetProperty(CodeStatement firstCondition)
        {
            var method = new CodeMemberMethod();
            method.ReturnType = CodeHelper.TypeRef(typeof(bool));
            method.Name = "TrySetProperty";
            method.AddParameter(typeof(PropertyInfo), "property");
            method.AddParameter(typeof(object), "destObj");
            method.AddParameter(typeof(AphidObject), "srcObj");
            method.Statements.Add(firstCondition);

            return method;
        }

        public CodeObject CreateCodeObject()
        {
            var conditions = _types
                .Select(CreateNumberSetValueCondition)
                .Concat(_types
                    .Concat(_arrayTypes)
                    .Select(CreateArraySetValueCondition));

            var firstCondition = conditions.First();
            var currentCondition = firstCondition;

            foreach (var condition in conditions.Skip(1))
            {
                currentCondition.FalseStatements.Add(condition);
                currentCondition = condition;
            }

            currentCondition.FalseStatements.Add(CodeHelper.Return(CodeHelper.False()));

            var type = new CodeTypeDeclaration("AphidObject") { IsPartial = true };
            type.Members.Add(TrySetProperty(firstCondition));

            var ns = new CodeNamespace();
            ns.Imports.Add(new CodeNamespaceImport("System.Linq"));
            ns.Name = "Components.Aphid.Interpreter";
            ns.Types.Add(type);

            var unit = new CodeCompileUnit();
            unit.Namespaces.Add(ns);

            return unit;
        }
    }
}
