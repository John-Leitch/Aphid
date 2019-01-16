using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidMacroMutator : AphidMutator
    {
        private Dictionary<string, AphidMacro> _macros = new Dictionary<string, AphidMacro>();

        protected override List<AphidExpression> OnMutate(List<AphidExpression> ast)
        {
            var macros = AphidMacro.Parse(ast);

            for (var i = 0; i < macros.Count; i++)
            {
                var m = macros.Array[i];

                if (_macros.ContainsKey(m.Name))
                {
                    throw new AphidParserException(
                        "Macro with name '{0}' already exists.",
                        m.Name);
                }

                _macros.Add(m.Name, m);
            }

            var filtered = new List<AphidExpression>(ast.Count);

            for (var i = 0; i < ast.Count; i++)
            {
                var node = ast[i];
                var include = true;

                for (var j = 0; j < macros.Count; j++)
                {
                    if (node == macros.Array[j].OriginalExpression)
                    {
                        include = false;
                        break;
                    }
                }

                if (include)
                {
                    filtered.Add(node);
                }
            }

            return filtered;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            CallExpression callExp;

            if (expression.Type != AphidExpressionType.CallExpression ||
                (callExp = (CallExpression)expression).FunctionExpression.Type !=
                    AphidExpressionType.IdentifierExpression)
            {
                hasChanged = false;

                return null;
            }

            var callIdExp = (IdentifierExpression)callExp.FunctionExpression;

            if (!_macros.TryGetValue(callIdExp.Identifier, out var macro))
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            var argTable = new Dictionary<string, AphidExpression>(callExp.Args.Count);

            for (var i = 0; i < callExp.Args.Count; i++)
            {
                argTable.Add(
                    ((IdentifierExpression)macro.Declaration.Args[i]).Identifier,
                    callExp.Args[i]);
            }

            var bodyMutator = CreateBodyMutator(argTable);
            var mutatedBody = bodyMutator.Mutate(macro.Declaration.Body);

            return mutatedBody;
        }

        protected virtual AphidMacroBodyMutator CreateBodyMutator(
            Dictionary<string, AphidExpression> argTable)
        {
            return new AphidMacroBodyMutator(argTable);
        }
    }
}
