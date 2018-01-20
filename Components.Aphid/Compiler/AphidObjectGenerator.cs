using Components.Aphid.Interpreter;
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
            typeof(Int16),
            typeof(UInt16),
            typeof(Int32),
            typeof(UInt32),
            typeof(Int64),
            typeof(UInt64),
        };

        private static readonly Type[] _arrayTypes = new Type[]
        {
            typeof(decimal),
            typeof(string),
            typeof(bool),            
        };

        public string CodeFile { get { return @"Interpreter\AphidObject.g.cs"; } }

        static CodeMethodInvokeExpression CreateSetValue(CodeExpression src)
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

        static CodeConditionStatement CreateSetValueCondition(Type type, CodeExpression src)
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

        static CodeConditionStatement CreateNumberSetValueCondition(Type type)
        {
            return CreateSetValueCondition(
                type,
                CodeHelper
                    .TypeRefExp(typeof(Convert))
                    .GetMethod("To" + type.Name)
                    .Invoke(CodeHelper.Arg("srcObj").GetProperty("Value")));
        }

        static CodeConditionStatement CreateArraySetValueCondition(Type type)
        {
            string lambda = type == typeof(decimal) ? "x => x.GetNumber()" :
                type == typeof(bool) ? "x => x.GetBool()" :
                type == typeof(string) ? "x => x.GetString()" :
                string.Format("x => ({0})x.GetNumber()", type.FullName);

            var toArray = CodeHelper
                .Arg("srcObj")
                .InvokeMethod("GetList")
                .InvokeMethod("Select",
                    new CodeSnippetExpression(lambda))
                .InvokeMethod("ToArray");
            return CreateSetValueCondition(type.MakeArrayType(), toArray);
        }

        static CodeMemberMethod TrySetProperty(CodeStatement firstCondition)
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
