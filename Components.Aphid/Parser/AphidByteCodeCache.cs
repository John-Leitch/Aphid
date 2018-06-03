using Components.Caching;
using System.Collections.Generic;
using System.IO;

namespace Components.Aphid.Parser
{
    public class AphidByteCodeCache : FileSerializationCache<List<AphidExpression>>
    {
        public bool InlineScripts { get; set; }

        private string[] _searchPaths;

        public AphidByteCodeCache(string[] searchPaths)
            : base(typeof(AphidExpression).Assembly.GetName().Version)
        {
            InlineScripts = true;
            _searchPaths = searchPaths;
        }

        public AphidByteCodeCache(string[] searchPaths, uint flags)
            : base(typeof(AphidExpression).Assembly.GetName().Version, flags)
        {
            InlineScripts = true;
            _searchPaths = searchPaths;
        }

        protected override List<AphidExpression> CreateCache(
            string filename,
            out string[] sources)
        {
            List<AphidExpression> ast;

            if ((Flags & 0x1) == 0)
            {
                ast = AphidParser.ParseFile(filename);
            }
            else
            {
                ast = AphidParser.ParseFile(filename, useImplicitReturns: false);
            }

            var partialOpMutator = new PartialOperatorMutator();
            var macroMutator = new AphidMacroMutator();
            var directiveMutator = new AphidPreprocessorDirectiveMutator();
            var constantFoldingMutator = new ConstantFoldingMutator();

            if (InlineScripts)
            {
                IncludeMutator includeMutator;

                if ((Flags & 0x1) == 0)
                {
                    includeMutator = new IncludeMutator();
                }
                else
                {
                    includeMutator = new IncludeMutator(false);
                }

                includeMutator.Loader.SearchPaths.AddRange(_searchPaths);

                var ast2 =
                    constantFoldingMutator.MutateRecursively(
                        includeMutator.MutateRecursively(
                            directiveMutator.MutateRecursively(
                                macroMutator.MutateRecursively(
                                    partialOpMutator.MutateRecursively(ast)))));

                includeMutator.Included.Add(filename);
                sources = includeMutator.Included.ToArray();

                return ast2;
            }
            else
            {
                var ast2 = constantFoldingMutator.MutateRecursively(
                    directiveMutator.MutateRecursively(
                        macroMutator.MutateRecursively(
                            partialOpMutator.MutateRecursively(ast))));

                sources = new string[0];

                return ast2;
            }
        }

        protected override void SerializeCache(Stream stream, List<AphidExpression> cache)
        {
            AphidByteCode.Encode(stream, cache);
        }

        protected override List<AphidExpression> DeserializeCache(Stream stream)
        {
            return AphidByteCode.Decode(stream);
        }
    }
}
