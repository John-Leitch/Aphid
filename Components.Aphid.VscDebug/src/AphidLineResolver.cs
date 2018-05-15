using Components.Aphid.Parser;
using Components.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCodeDebug
{
    public class AphidLineResolver
    {
        private string _code;

        private List<AphidExpression> _ast;

        public Dictionary<int, AphidExpression> IndexTable { get; private set; }

        public AphidLineResolver(string code, List<AphidExpression> ast)
        {
            _code = code;
            _ast = ast;
        }

        public int[] GetLineIndexes()
        {
            return new[] { 0 }
                .Concat(_code
                    .Select((x, i) => new { Char = x, Index = i })
                    .Where(x => x.Char == '\n')
                    .Select(x => x.Index))
                .ToArray();
        }

        public int[] ResolveLines(int[] clientLines)
        {
            var lineIndexes = GetLineIndexes();
            //Program.Log("Lines found: {0}", JsonSerializer.Serialize(lineIndexes));
            var indexes = clientLines.Select(x => lineIndexes[x - 1]).ToArray();
            //Program.Log("Indexes found: {0}", JsonSerializer.Serialize(indexes));

            return indexes;
        }

        public AphidExpression[] ResolveLineExpressions(int[] clientLines)
        {
            IndexTable = new AphidIndexVisitor().GetIndexTable(_ast);
            var indexes = ResolveLines(clientLines);

            return indexes
                .Select(x => IndexTable.First(y => y.Key >= x).Value)
                .ToArray();

        }

        public int ResolveExpressionLine(AphidExpression expression)
        {
            if (expression == null)
            {
                Program.Log("Resolving line for expression null");
                return 0;
            }

            var lineIndexes = GetLineIndexes();

            Program.Log(
                "Line indexes: {0}",
                JsonSerializer.Serialize(lineIndexes));

            IndexTable = new AphidIndexVisitor().GetIndexTable(_ast);

            Program.Log(
                "Index table: {0}",
                JsonSerializer.Serialize(IndexTable.Select(x => x.Key).ToArray()));

            var lineMatch = lineIndexes
                .Select((x, i) => new { Index = x, Line = i })
                .FirstOrDefault(x => x.Index >= expression.Index);

            var line = lineMatch != null ? lineMatch.Line : lineIndexes.Length;

            Program.Log(
                "Expression {0} at index {1} resolved to line {2}",
                expression,
                expression.Index,
                line);

            return line;
        }
    }
}
