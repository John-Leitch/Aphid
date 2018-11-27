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

        public HashSet<string> Included { get; private set; }

        public bool PerformCommonTransformations { get; set; }

        public bool DisableCaching { get; set; }

        public AphidLoader Loader
        {
            get { return _loader; }
        }

        protected override bool UpdatePosition
        {
            get { return false; }
        }

        public IncludeMutator(string applicationDirectory, bool useImplicitReturns)
        {
            PerformCommonTransformations = true;
            _applicationDirectory = applicationDirectory;
            UseImplicitReturns = useImplicitReturns;
            Included = new HashSet<string>();
        }

        public IncludeMutator(string applicationDirectory)
            : this(applicationDirectory, true)
        {
        }

        public IncludeMutator(bool useImplicitReturns)
            : this(Path.GetDirectoryName(typeof(IncludeMutator).Assembly.Location), useImplicitReturns)
        {
        }

        public IncludeMutator()
            : this(Path.GetDirectoryName(typeof(IncludeMutator).Assembly.Location))
        {
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            LoadScriptExpression loadExp;
            AphidExpression scriptExp;

            if (expression.Type != AphidExpressionType.LoadScriptExpression)
            {
                hasChanged = false;

                return null;
            }
            else if ((loadExp = (LoadScriptExpression)expression).FileExpression.Type !=
                    AphidExpressionType.StringExpression)
            {
                var constantFolder = new ConstantFoldingMutator();
                var mutated = constantFolder.Mutate(new List<AphidExpression> { loadExp.FileExpression });

                if (mutated.Count != 1 || (scriptExp = mutated[0]).Type != AphidExpressionType.StringExpression)
                {
                    hasChanged = false;

                    return null;
                    //throw new AphidParserException("Invalid load script operand", loadExp);
                }
            }
            else
            {
                scriptExp = loadExp.FileExpression;
            }

            var scriptStr = StringParser.Parse(((StringExpression)scriptExp).Value);

            var script = _loader.FindScriptFile(_applicationDirectory, scriptStr);

            if (!File.Exists(script))
            {
                throw new AphidParserException(
                    string.Format(
                        "Could not find script {0}",
                        scriptStr),
                    scriptExp);
            }

            Included.Add(script);

            List<AphidExpression> ast;

            if (AphidConfig.Current.ScriptCaching && !DisableCaching)
            {
                AphidByteCodeCache cache;

                if (UseImplicitReturns)
                {
                    cache = new AphidByteCodeCache(_loader.SearchPaths.ToArray());
                }
                else
                {
                    cache = new AphidByteCodeCache(_loader.SearchPaths.ToArray(), 0x1);
                }

                ast = cache.Read(script, out var cacheSources);

                for (var i = 0; i < cacheSources.Length; i++)
                {
                    Included.Add(cacheSources[i].Name);
                }
            }
            else
            {
                var code = AphidScript.Read(script);
                ast = AphidParser.Parse(code, script, useImplicitReturns: UseImplicitReturns);
            }

            if (PerformCommonTransformations)
            {
                var mutatedAst = new PartialOperatorMutator().MutateRecursively(ast);
                mutatedAst = new AphidMacroMutator().MutateRecursively(mutatedAst);
                mutatedAst = new AphidPreprocessorDirectiveMutator().MutateRecursively(mutatedAst);
                mutatedAst = new ConstantFoldingMutator().MutateRecursively(mutatedAst);
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
