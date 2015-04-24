using Microsoft.Cci;
using Microsoft.Cci.MutableCodeModel;
using System;
using System.Linq;

namespace ILWeave
{
    public class PropertyChangedWeaver : MetadataRewriter
    {
        ReferenceReplacementRewriter _rewriter;

        private PropertyChangedWeaver(IMetadataHost host)
            : base(host)
        {
            
        }

        public override void RewriteChildren(NamedTypeDefinition typeDefinition)
        {
            if (typeDefinition.Properties == null)
            {
                return;
            }

            var props = typeDefinition.Properties
                .Select(x => new
                {
                    Property = x,
                    Attributes = x.Attributes
                        //.Select(y => (NamespaceTypeDefinition)y.Type)
                        .Select(y => y.Type as NamespaceTypeDefinition)
                        .Where(y => y != null && y.Name.Value == "PropertyChangedAttribute")
                })
                .Where(x => x.Attributes.Any());

            if (!props.Any())
            {
                return;
            }

            foreach (var p in props.ToArray())
            {
                if (p.Property.Setter == null)
                {
                    throw new InvalidOperationException();
                }

                var copier = new MetadataDeepCopier(host);

                var p2 = copier.Copy(p.Property);
                typeDefinition.Properties.Remove(p.Property);
                typeDefinition.Properties.Add(p2);

                var method = copier.Copy(p2.Setter.ResolvedMethod);
                _rewriter.PropertyName = p2.Name.Value;
                _rewriter.Type = method.ContainingTypeDefinition;
                method.Body = _rewriter.Rewrite(method.Body);
                method.ContainingTypeDefinition = typeDefinition;

                var m = typeDefinition.Methods.FirstOrDefault(x => x.Name == p2.Setter.ResolvedMethod.Name);
                typeDefinition.Methods.Remove(m);
                typeDefinition.Methods.Add(method);
            }
        }

        public static IModule RewriteModule(IMetadataHost host, ILocalScopeProvider localScopeProvider, ISourceLocationProvider sourceLocationProvider, IModule module)
        {

            var m = new PropertyChangedWeaver(host);
            m._rewriter = new ReferenceReplacementRewriter(host, localScopeProvider, sourceLocationProvider);
            
            return m.Rewrite(module);
        }
    }
}
