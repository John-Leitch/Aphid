using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidFunctionComposition : IAphidCallable
    {
        public AphidExpression LeftExpression { get; private set; }

        public AphidExpression RightExpression { get; private set; }

        public object LeftFunction { get; private set; }        

        public object RightFunction { get; private set; }

        public AphidFunctionComposition(
            AphidExpression leftExpression,
            AphidExpression rightExpression,
            object leftFunction, 
            object rightFunction)
        {
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
            LeftFunction = leftFunction;
            RightFunction = rightFunction;
        }
    }
}
