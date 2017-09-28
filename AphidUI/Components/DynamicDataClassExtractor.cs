using AphidCodeGenerator;
using Components.External;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Component.AphidUI
{
    public class DynamicDataClassExtractor<TType, TAttribute>
        where TAttribute : Attribute
    {
        Lazy<Dictionary<string, PropertyInfo>> _sourcePropertyTable;

        public DynamicDataClassExtractor()
        {
            _sourcePropertyTable = new Lazy<Dictionary<string, PropertyInfo>>(
                () => GetPropertyTable(typeof(TType)));
        }

        private Dictionary<string, PropertyInfo> GetPropertyTable(Type type)
        {
            return type
                .GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(TAttribute), true).Any())
                .ToDictionary(x => x.Name, x => x);
        }

        public Type BuildType(string typeName)
        {
            var nameTable = _sourcePropertyTable.Value;

            var type2 = new CodeTypeDeclaration(typeName)
            {
                CustomAttributes = new CodeAttributeDeclarationCollection(
                    new[] { new CodeAttributeDeclaration(CodeHelper.TypeRef<SerializableAttribute>()) })
            };

            var fields = nameTable
                .ToDictionary(
                x => x.Key,
                x => new CodeMemberField(x.Value.PropertyType, string.Format("_autoField_{0}", x.Key)));


            var props = nameTable
                    .Select(x => new CodeMemberProperty
                    {
                        Attributes = MemberAttributes.Public,
                        Type = CodeHelper.TypeRef(x.Value.PropertyType),
                        Name = x.Key,
                        HasGet = true,
                        HasSet = true,
                        CustomAttributes = new CodeAttributeDeclarationCollection(
                            new[] { new CodeAttributeDeclaration(CodeHelper.TypeRef<TAttribute>()) })
                    })
                    .ToArray();

            foreach (var p in props)
            {
                var field = CodeHelper.FieldRef(fields[p.Name].Name);
                p.GetStatements.Add(CodeHelper.Return(field));
                p.SetStatements.Add(CodeHelper.Assign(field, CodeHelper.VarRef("value")));
            }

            type2.Members.AddRange(fields.Select(x => x.Value).ToArray());
            type2.Members.AddRange(props);

            var code = CSharpHelper.GenerateCode(type2);

            using (var provider = new CSharpCodeProvider())
            {
                var options = new CompilerParameters
                {
                    GenerateExecutable = false,
                    GenerateInMemory = true,

                };

                var references = nameTable
                    .Select(x => x.Value.PropertyType.Assembly.Location)
                    .Concat(new[] { typeof(SerializableAttribute), typeof(TAttribute) }
                        .Select(x => x.Assembly.Location))
                    .Distinct()
                    .ToArray();

                options.ReferencedAssemblies.AddRange(references);

                var results = provider.CompileAssemblyFromSource(options, code);

                return results.CompiledAssembly.GetType(typeName);
            }
        }

        public object InstantiatePopulated(TType sourceInstance, string typeName)
        {
            var t = BuildType(typeName);
            var instance = Activator.CreateInstance(t);
            var dstPropTable = GetPropertyTable(t);

            foreach (var p in _sourcePropertyTable.Value)
            {
                dstPropTable[p.Key].SetValue(instance, p.Value.GetValue(sourceInstance));
            }

            return instance;
        }
    }
}
