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

            foreach (var m in macros)
            {
                if (_macros.ContainsKey(m.Name))
                {
                    throw new AphidParserException(
                        "Macro with name '{0}' already exists.",
                        m.Name);
                }

                _macros.Add(m.Name, m);
            }

            return ast.Where(x => !_macros.Any(y => y.Value.OriginalExpression == x)).ToList();
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            var callExp = expression as CallExpression;

            if (callExp == null)
            {
                hasChanged = false;

                return null;
            }

            var callIdExp = callExp.FunctionExpression as IdentifierExpression;

            AphidMacro macro;

            if (callIdExp == null || !_macros.TryGetValue(callIdExp.Identifier, out macro))
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            var argTable = callExp.Args
                .Select((x, i) => new
                {
                    Name = (IdentifierExpression)macro.Declaration.Args[i],
                    Value = x,
                })
                .ToDictionary(x => x.Name.Identifier, x => x.Value);

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
