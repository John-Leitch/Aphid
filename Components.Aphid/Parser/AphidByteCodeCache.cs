using System;
using System.Collections.Generic;
using System.IO;

namespace Components.Aphid.Parser
{
    public partial class AphidByteCodeCache : FileSerializationCache<List<AphidExpression>>
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

        public bool Is64Bit
        {
            get => (Flags & 0x8) != 0;
            set
            {
                if (value)
                {
                    Flags |= 0x8;
                }
                else
                {
                    Flags &= ~0x8u;
                }
            }
        }

        private readonly string[] _searchPaths;

        public AphidByteCodeCache(string[] searchPaths)
            : base(typeof(AphidExpression).Assembly.GetName().Version)
        {
            Is64Bit = Environment.Is64BitProcess;
            _searchPaths = searchPaths;
        }

        public AphidByteCodeCache(string[] searchPaths, uint flags)
            : base(
                typeof(AphidExpression).Assembly.GetName().Version,
                Environment.Is64BitProcess ?
                    (flags | 0x8) :
                    flags & (~0x8u)) =>
            _searchPaths = searchPaths;

        protected override List<AphidExpression> CreateCache(
            string filename,
            out string[] sources)
        {
            List<AphidExpression> ast = (Flags & 0x1) == 0 ? AphidParser.ParseFile(filename) : AphidParser.ParseFile(filename, useImplicitReturns: false);
            if (InlineScripts)
            {
                IncludeMutator includeMutator = (Flags & 0x1) == 0
                    ? new IncludeMutator { PerformCommonTransformations = false }
                    : new IncludeMutator(false) { PerformCommonTransformations = false };
                foreach (var p in _searchPaths)
                {
                    includeMutator.Loader.SearchPaths.Add(p);
                }

                ast = includeMutator.Mutate(MutatorGroups.GetMinimal().Mutate(ast));

                if (!DisableConstantFolding)
                {
                    ast = new ConstantFoldingMutator().Mutate(ast);
                }

                includeMutator.AddIncluded(filename);
                var included = includeMutator.GetIncluded();
                sources = new string[included.Count];
                included.CopyTo(sources);

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
