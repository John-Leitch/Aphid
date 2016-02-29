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

        public void Emit(List<AphidExpression> statements)
        {
            foreach (var stmt in statements)
            {
                BeginStatement();
                Emit(stmt);
                EndStatement();
            }
        }

        public string Compile(List<AphidExpression> ast)
        {
            _out.Clear();
            Emit(ast);

            return _out.ToString();
        }
    }
}
