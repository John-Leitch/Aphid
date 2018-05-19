using Components.Caching;
using System.Collections.Generic;
using System.IO;

namespace Components.Aphid.Parser
{
    public class AphidByteCodeCache : FileSerializationCache<List<AphidExpression>>
    {
        private string[] _searchPaths;

        public AphidByteCodeCache(string[] searchPaths)
            : base(typeof(AphidExpression).Assembly.GetName().Version)
        {
            _searchPaths = searchPaths;
        }

        protected override List<AphidExpression> CreateCache(
            string filename,
            out string[] sources)
        {
            var partialOpMutator = new PartialOperatorMutator();
            var macroMutator = new AphidMacroMutator();
            var directiveMutator = new AphidPreprocessorDirectiveMutator();
            var includeMutator = new IncludeMutator();
            includeMutator.Loader.SearchPaths.AddRange(_searchPaths);

            var ast = AphidParser.ParseFile(filename);

            var ast2 = includeMutator.MutateRecursively(
                directiveMutator.MutateRecursively(
                    macroMutator.MutateRecursively(
                        partialOpMutator.MutateRecursively(ast))));

            includeMutator.Included.Add(filename);
            sources = includeMutator.Included.ToArray();

            return ast2;
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
