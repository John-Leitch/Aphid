using Microsoft.Cci;
using Microsoft.Cci.MutableCodeModel;
using System;

namespace ILWeave
{
    public class ReferenceReplacementRewriter : ILRewriter
    {
        public ITypeDefinition Type { get; set; }

        public string PropertyName { get; set; }

        public ReferenceReplacementRewriter(IMetadataHost host, ILocalScopeProvider localScopeProvider, ISourceLocationProvider sourceLocationProvider)
            : base(host, localScopeProvider, sourceLocationProvider)
        {
        }

        protected override void EmitOperation(IOperation operation)
        {
            switch (operation.OperationCode)
            {
                case OperationCode.Ret:
                    base.EmitOperation(new Operation() { OperationCode = OperationCode.Ldarg_0 });

                    base.EmitOperation(new Operation()
                    {
                        OperationCode = OperationCode.Ldstr,
                        Value = PropertyName,
                    });

                    var method = TypeHelper2.GetMethodRecursive(
                        Type,
                        host.NameTable.GetNameFor("InvokePropertyChanged"),
                        host.PlatformType.SystemString);

                    if (method == Dummy.Method || method == null)
                    {
                        throw new InvalidOperationException();
                    }

                    base.EmitOperation(new Operation()
                    {
                        OperationCode = OperationCode.Call,
                        Value = method,
                    });

                    break;
            }

            base.EmitOperation(operation);
        }
    }
}
