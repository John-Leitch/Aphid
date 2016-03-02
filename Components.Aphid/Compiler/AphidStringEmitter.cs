using Components.Aphid.Parser;
using System.Collections.Generic;
using System.Text;

namespace Components.Aphid.Compiler
{
    public abstract partial class AphidStringEmitter
    {
        protected StringBuilder _out = new StringBuilder();

        protected void Append(string format, params object[] args)
        {
            _out.AppendFormat(format, args);
        }

        protected void Append(object value)
        {
            _out.Append(value.ToString());
        }

        protected virtual void EmitHeader() { }

        public void Emit(List<AphidExpression> statements)
        {
            foreach (var stmt in statements)
            {
                BeginStatement();
                Emit(stmt, isStatement: true);
                EndStatement();
            }
        }

        public virtual string Compile(List<AphidExpression> ast)
        {
            _out.Clear();
            EmitHeader();
            Emit(ast);

            return _out.ToString();
        }
    }
}
