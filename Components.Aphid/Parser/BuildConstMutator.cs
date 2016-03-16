using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class BuildConstMutator : AphidMutator
    {
        private const string _buildId = "__BUILD__";

        private int _buildNumber;

        public BuildConstMutator(int buildNumber)
        {
            _buildNumber = buildNumber;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            string id;

            if (expression.Type != AphidExpressionType.IdentifierExpression ||
                (id = expression.ToIdentifier().Identifier) != _buildId)
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;
            var utc = DateTime.Now.ToUniversalTime();

            return new List<AphidExpression>
            {
                new StringExpression(
                    string.Format(
                        "'{0}'", 
                        string.Format("{0:D2}{1:D2}.{2}", utc.Month, utc.Day, _buildNumber)))
            };
        }
    }
}
