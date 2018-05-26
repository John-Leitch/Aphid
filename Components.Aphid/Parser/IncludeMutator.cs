using Components;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.UI;
using Components.Caching;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Components.Aphid.Parser
{
    public class IncludeMutator : AphidMutator
    {
        AphidLoader _loader = new AphidLoader(null);

        private string _applicationDirectory;

        public bool UseImplicitReturns { get; private set; }

        public List<string> Included { get; private set; }

        public bool PerformCommonTransformations { get; set; }

        public AphidLoader Loader
        {
            get { return _loader; }
        }

        public IncludeMutator(string applicationDirectory, bool useImplicitReturns)
        {
            PerformCommonTransformations = true;
            _applicationDirectory = applicationDirectory;
            UseImplicitReturns = useImplicitReturns;
            Included = new List<string>();
        }

        public IncludeMutator(string applicationDirectory)
            : this(applicationDirectory, true)
        {
        }

        public IncludeMutator()
            : this(Path.GetDirectoryName(typeof(IncludeMutator).Assembly.Location))
        {
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            LoadScriptExpression loadExp;

            if (expression.Type != AphidExpressionType.LoadScriptExpression)
            {
                hasChanged = false;

                return null;
            }
            else if ((loadExp = (LoadScriptExpression)expression).FileExpression.Type !=
                    AphidExpressionType.StringExpression)
            {
                throw new AphidParserException("Invalid load script operand", loadExp);
            }

            var scriptExp = (StringExpression)loadExp.FileExpression;
            var script = _loader.FindScriptFile(_applicationDirectory, StringParser.Parse(scriptExp.Value));

            if (!File.Exists(script))
            {
                throw new AphidParserException("Could not find script", scriptExp);
            }

            Included.Add(script);
            var code = AphidScript.Read(script);
            var ast = AphidParser.Parse(code, useImplicitReturns: UseImplicitReturns);

            if (PerformCommonTransformations)
            {
                var mutatedAst = new PartialOperatorMutator().MutateRecursively(ast);
                mutatedAst = new AphidMacroMutator().MutateRecursively(mutatedAst);
                mutatedAst = new AphidPreprocessorDirectiveMutator().MutateRecursively(mutatedAst);
                hasChanged = true;

                return mutatedAst;
            }
            else
            {
                hasChanged = true;

                return ast;
            }
        }
    }
}
