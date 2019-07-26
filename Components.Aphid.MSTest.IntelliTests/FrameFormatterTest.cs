using Components.Aphid.Interpreter;
using System;
using Components.Aphid.UI.Formatters;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.UI.Formatters.Tests
{
    /// <summary>This class contains parameterized unit tests for FrameFormatter</summary>
    [TestClass]
    [PexClass(typeof(FrameFormatter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FrameFormatterTest
    {

        /// <summary>Test stub for FormatFrame(Int32, AphidFrame&amp;)</summary>
        [PexMethod]
        public string FormatFrameTest(int frameNum, in AphidFrame frame)
        {
            string result = FrameFormatter.FormatFrame(frameNum, in frame);
            return result;
            // TODO: add assertions to method FrameFormatterTest.FormatFrameTest(Int32, AphidFrame&)
        }
    }
}
