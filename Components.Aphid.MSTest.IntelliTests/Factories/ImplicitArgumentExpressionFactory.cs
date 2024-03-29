using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="ImplicitArgumentExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ImplicitArgumentExpression instances</summary>
    public static partial class ImplicitArgumentExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ImplicitArgumentExpression instances</summary>
        [PexFactoryMethod(typeof(ImplicitArgumentExpression))]
        public static ImplicitArgumentExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidTokenType operator_w,
            int value_i,
            int value_i1
        )
        {
            ImplicitArgumentExpression implicitArgumentExpression
               = new ImplicitArgumentExpression(context_aphidExpressionContext, operator_w);
            ((AphidExpression)implicitArgumentExpression).Index = value_i;
            ((AphidExpression)implicitArgumentExpression).Length = value_i1;
            return implicitArgumentExpression;

            // TODO: Edit factory method of ImplicitArgumentExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
