using Components.Aphid.Interpreter;
using Components.Aphid.UI;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Components.Aphid.Parser
{
    public class IncludeMutator : AphidMutator
    {
        private readonly string _applicationDirectory;

        public bool UseImplicitReturns { get; }

        private HashSet<string> _included { get; }

        public bool PerformCommonTransformations { get; set; }

        public bool DisableCaching { get; set; }

        public AphidLoader Loader { get; } = new AphidLoader(null);

        protected override bool UpdatePosition => false;

        public IncludeMutator(string applicationDirectory, bool useImplicitReturns)
        {
            PerformCommonTransformations = true;
            _applicationDirectory = applicationDirectory;
            UseImplicitReturns = useImplicitReturns;
            _included = new HashSet<string>();
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
                var mutated = new ConstantFoldingMutator()
                    .MutateSingle(loadExp.FileExpression);                

                if ((scriptExp = mutated).Type != AphidExpressionType.StringExpression)
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
            var script = Loader.FindScriptFile(_applicationDirectory, scriptStr);

            if (script == null && scriptExp.Filename != null)
            {
                script = Loader.FindScriptFile(Path.GetDirectoryName(scriptExp.Filename), scriptStr);
            }

            if (!File.Exists(script))
            {
                throw new AphidParserException(
                    string.Format(
                        "Could not find script {0}",
                        scriptStr),
                    scriptExp);
            }

            AddIncluded(script);

            List<AphidExpression> ast;

            if (AphidConfig.Current.ScriptCaching && !DisableCaching)
            {
                AphidByteCodeCache cache;

                if (UseImplicitReturns)
                {
                    cache = new AphidByteCodeCache(Loader.SearchPaths.ToArray())
                    {
                        DisableConstantFolding = false,
                        InlineScripts = true,
                    };
                }
                else
                {
                    cache = new AphidByteCodeCache(Loader.SearchPaths.ToArray(), 0x1);
                }

                ast = cache.Read(script, out var cacheSources);

                for (var i = 0; i < cacheSources.Length; i++)
                {
                    AddIncluded(cacheSources[i].Name);
                }
            }
            else
            {
                var code = AphidScript.Read(script);
                ast = AphidParser.Parse(code, script, useImplicitReturns: UseImplicitReturns);
            }

            if (PerformCommonTransformations)
            {
                var mut = MutatorGroups.GetStandard().Mutate(ast);
                hasChanged = true;

                return mut;
            }

            hasChanged = true;

            return ast;
        }

        public void AddIncluded(string filename) => _included.Add(CacheName.Normalize(filename));

        public HashSet<string> GetIncluded() => _included;
    }
}
