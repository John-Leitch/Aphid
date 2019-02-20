using Components.Aphid.Parser;
using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "ConstantFolding"), Parallelizable(ParallelScope.All)]
    public class MutatorTests : AphidTests
    {
        private void MutatorTest<TMutator>(string code, Action<List<AphidExpression>> assertAst)
            where TMutator : AphidMutator, new()
        {
            var mutator = Activator.CreateInstance<TMutator>();
            var ast = AphidParser.Parse(code);
            ast = mutator.MutateRecursively(ast);
            assertAst(ast);
        }

        private void MutatorTest<TMutator>(string expected, string code)
            where TMutator : AphidMutator, new()
        {
            MutatorTest<TMutator>(
                code,
                ast => Assert.AreEqual(expected, StringParser.Parse(ast.Cast<StringExpression>().Single().Value)));
        }

        private void MutatorTest<TMutator>(decimal expected, string code)
            where TMutator : AphidMutator, new()
        {
            MutatorTest<TMutator>(
                code,
                ast => Assert.AreEqual(expected, ast.Cast<NumberExpression>().Single().Value));
        }

        [Test]
        public void ConstantFoldingTest1() => MutatorTest<ConstantFoldingMutator>("foo", "'fo' + 'o';");

        [Test]
        public void ConstantFoldingTest2() => MutatorTest<ConstantFoldingMutator>(10, "4 + 6;");
    }
}
