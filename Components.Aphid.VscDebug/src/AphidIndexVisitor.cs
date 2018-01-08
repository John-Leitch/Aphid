using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCodeDebug.src
{
    public class AphidIndexVisitor : AphidVisitor
    {
        private Dictionary<int, AphidExpression> _indexTable;

        protected override void Visit(AphidExpression expression)
        {
            if (!_indexTable.ContainsKey(expression.Index))
            {
                Program.Log("Index: {0}, Exp: {1}", expression.Index, expression.ToString());
                _indexTable.Add(expression.Index, expression);
            }
        }

        public Dictionary<int, AphidExpression> GetIndexTable(List<AphidExpression> ast)
        {
            _indexTable = new Dictionary<int, AphidExpression>();

            Visit(ast);

            return _indexTable;
        }
    }
}
