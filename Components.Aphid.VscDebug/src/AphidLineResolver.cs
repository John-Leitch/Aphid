using Components.Aphid.Lexer;
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
        public Dictionary<int, AphidExpression> IndexTable { get; private set; }

        public static int[] GetLineIndexes(string code) =>
            new[] { 0 }
                .Concat(code
                    .Select((x, i) => new { Char = x, Index = i })
                    .Where(x => x.Char == '\n')
                    .Select(x => x.Index))
                .ToArray();

        public int[] ResolveLines(string code, int[] clientLines)
        {
            var lineIndexes = GetLineIndexes(code);
            //Program.Log("Lines found: {0}", JsonSerializer.Serialize(lineIndexes));

            //Program.Log("Indexes found: {0}", JsonSerializer.Serialize(indexes));

            return clientLines
                .Select(x => x - 1)
                .Select(x => 0 <= x && x < lineIndexes.Length ? lineIndexes[x] : 0)
                .ToArray();
        }

        public AphidExpression[] ResolveLineExpressions(
            List<AphidExpression> ast,
            string code,
            SourceBreakpoint[] clientLines)
        {
            var indexes = clientLines
                .Select(x => TokenHelper
                    .GetIndex(code, x.line - 1, x.column - 1))
                .ToArray();

            Program.Log(
                "Breakpoint offsets: {0}",
                string.Join("\r\n", indexes.Select(x => x.ToString())));

            //IndexTable = new AphidIndexVisitor().GetIndexTable(ast);
            //var indexes = ResolveLines(code, clientLines);
            IndexTable = new AphidIndexVisitor().GetIndexTable(ast);

            return indexes
                .Select(x => IndexTable.FirstOrDefault(y => y.Key >= x).Value)
                .Where(x => x != null)
                .ToArray();
        }

        public (int, int) ResolvePosition(List<AphidExpression> ast, AphidExpression expression)
        {
            if (expression == null)
            {
                Program.Log("Resolving line for expression null");
                return (0, 0);
            }

            var lineIndexes = GetLineIndexes(expression.Code);

            //Program.Log(
            //    "Line indexes: {0}",
            //    JsonSerializer.Serialize(lineIndexes));

            IndexTable = new AphidIndexVisitor().GetIndexTable(ast);

            //Program.Log(
            //    "Index table: {0}",
            //    JsonSerializer.Serialize(IndexTable.Select(x => x.Key).ToArray()));

            var lineMatch = lineIndexes
                .Select((x, i) => new { Index = x, Line = i })
                .FirstOrDefault(x => x.Index >= expression.Index);

            if (lineMatch != null)
            {
                int line, col;
                if (expression.Index == 0)
                {
                    line = 1;
                    col = 1;
                }
                else
                {
                    line = lineMatch.Line;
                    col = expression.Index - lineIndexes[lineMatch.Line - 1];
                }

                Program.Log(
                    "Expression {0} at index {1} resolved to line {2} col {3}",
                    expression,
                    expression.Index,
                    lineMatch.Line,
                    col);

                return (line, col);
            }
            else
            {
                Program.Log(
                    "Expression {0} at index {1} guessed to be on to line {2}",
                    expression,
                    expression.Index,
                    lineIndexes.Length);

                

                return (lineIndexes.Length, expression.Index - lineIndexes[lineIndexes.Length - 1]);
            }
        }
    }
}
