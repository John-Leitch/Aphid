using Components.Aphid;
using System.Collections.Generic;
using System.IO;

namespace Components.Aphid.Parser
{
    public class AphidByteCodeCache : FileSerializationCache<List<AphidExpression>>
    {
        public bool InlineScripts
        {
            get => (Flags & 0x2) != 0;
            set
            {
                if (value)
                {
                    Flags |= 0x2u;
                }
                else
                {
                    Flags &= ~0x2u;
                }
            }
        }

        public bool DisableConstantFolding
        {
            get => (Flags & 0x4) != 0;
            set
            {
                if (value)
                {
                    Flags |= 0x4u;
                }
                else
                {
                    Flags &= ~0x4u;
                }
            }
        }

        private readonly string[] _searchPaths;

        public AphidByteCodeCache(string[] searchPaths)
            : base(typeof(AphidExpression).Assembly.GetName().Version) => _searchPaths = searchPaths;

        public AphidByteCodeCache(string[] searchPaths, uint flags)
            : base(typeof(AphidExpression).Assembly.GetName().Version, flags) => _searchPaths = searchPaths;

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
            
            if (InlineScripts)
            {
                IncludeMutator includeMutator;

                if ((Flags & 0x1) == 0)
                {
                    includeMutator = new IncludeMutator
                    {
                        PerformCommonTransformations = false,
                    };
                }
                else
                {
                    includeMutator = new IncludeMutator(false)
                    {
                        PerformCommonTransformations = false,
                    };
                }

                foreach (var p in _searchPaths)
                {
                    includeMutator.Loader.SearchPaths.Add(p);
                }
                
                ast = includeMutator.Mutate(MutatorGroups.GetMinimal().Mutate(ast));

                if (!DisableConstantFolding)
                {
                    ast = new ConstantFoldingMutator().Mutate(ast);
                }

                includeMutator.Included.Add(filename);
                sources = new string[includeMutator.Included.Count];
                includeMutator.Included.CopyTo(sources);

                return ast;
            }

            ast = (DisableConstantFolding ?
                MutatorGroups.GetMinimal() :
                MutatorGroups.GetStandard())
                .Mutate(ast);

            sources = new[] { filename };

            return ast;
        }

        protected override void SerializeCache(Stream stream, List<AphidExpression> cache) => AphidByteCode.Encode(stream, cache);

        protected override List<AphidExpression> DeserializeCache(Stream stream) => AphidByteCode.Decode(stream);
    }
}
