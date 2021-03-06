using System.Reflection;
// <copyright file="AphidParserTest.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Components.Aphid.Parser;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(AphidParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidParserTest
    {

        [PexMethod]
        [PexMethodUnderTest("ParsePrefixUnaryOperatorExpression()")]
        internal AphidExpression ParsePrefixUnaryOperatorExpression([PexAssumeUnderTest]AphidParser target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            AphidExpression result0
               = ((MethodBase)(typeof(AphidParser).GetMethod("ParsePrefixUnaryOperatorExpression",
                                                             BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                             CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                     .Invoke((object)target, args) as AphidExpression;
            AphidExpression result = result0;
            return result;
            // TODO: add assertions to method AphidParserTest.ParsePrefixUnaryOperatorExpression(AphidParser)
        }
    }
}
