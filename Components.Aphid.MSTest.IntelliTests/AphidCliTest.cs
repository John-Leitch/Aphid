// <copyright file="AphidCliTest.cs">Copyright © AutoSec Tools LLC 2019</copyright>
using System;
using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.UI.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidCli</summary>
    [PexClass(typeof(AphidCli))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AphidCliTest
    {
        /// <summary>Test stub for Capture(Action)</summary>
        [PexMethod]
        public string CaptureTest(Action action)
        {
            string result = AphidCli.Capture(action);
            return result;
            // TODO: add assertions to method AphidCliTest.CaptureTest(Action)
        }

        /// <summary>Test stub for DumpException(AphidParserException, String)</summary>
        [PexMethod]
        public void DumpExceptionTest(AphidParserException exception, string code)
        {
            AphidCli.DumpException(exception, code);
            // TODO: add assertions to method AphidCliTest.DumpExceptionTest(AphidParserException, String)
        }

        /// <summary>Test stub for DumpException(AphidRuntimeException, AphidInterpreter)</summary>
        [PexMethod]
        public void DumpExceptionTest01(AphidRuntimeException exception, AphidInterpreter interpreter)
        {
            AphidCli.DumpException(exception, interpreter);
            // TODO: add assertions to method AphidCliTest.DumpExceptionTest01(AphidRuntimeException, AphidInterpreter)
        }

        /// <summary>Test stub for DumpException(AphidLoadScriptException, AphidInterpreter)</summary>
        [PexMethod]
        public void DumpExceptionTest02(AphidLoadScriptException exception, AphidInterpreter interpreter)
        {
            AphidCli.DumpException(exception, interpreter);
            // TODO: add assertions to method AphidCliTest.DumpExceptionTest02(AphidLoadScriptException, AphidInterpreter)
        }

        /// <summary>Test stub for DumpException(Exception, AphidInterpreter)</summary>
        [PexMethod]
        public void DumpExceptionTest03(Exception exception, AphidInterpreter interpreter)
        {
            AphidCli.DumpException(exception, interpreter);
            // TODO: add assertions to method AphidCliTest.DumpExceptionTest03(Exception, AphidInterpreter)
        }

        /// <summary>Test stub for DumpScope(AphidInterpreter)</summary>
        [PexMethod]
        public void DumpScopeTest(AphidInterpreter interpreter)
        {
            AphidCli.DumpScope(interpreter);
            // TODO: add assertions to method AphidCliTest.DumpScopeTest(AphidInterpreter)
        }

        /// <summary>Test stub for DumpScope(AphidObject, AphidInterpreter)</summary>
        [PexMethod]
        public void DumpScopeTest01(AphidObject scope, AphidInterpreter interpreter)
        {
            AphidCli.DumpScope(scope, interpreter);
            // TODO: add assertions to method AphidCliTest.DumpScopeTest01(AphidObject, AphidInterpreter)
        }

        /// <summary>Test stub for DumpScope(AphidObject, AphidInterpreter, Int32)</summary>
        [PexMethod]
        public void DumpScopeTest02(
            AphidObject scope,
            AphidInterpreter interpreter,
            int depth
        )
        {
            AphidCli.DumpScope(scope, interpreter, depth);
            // TODO: add assertions to method AphidCliTest.DumpScopeTest02(AphidObject, AphidInterpreter, Int32)
        }

        /// <summary>Test stub for DumpStackTrace(AphidInterpreter, Exception)</summary>
        [PexMethod]
        public void DumpStackTraceTest(AphidInterpreter interpreter, Exception exception)
        {
            AphidCli.DumpStackTrace(interpreter, exception);
            // TODO: add assertions to method AphidCliTest.DumpStackTraceTest(AphidInterpreter, Exception)
        }

        /// <summary>Test stub for DumpStackTrace(AphidInterpreter)</summary>
        [PexMethod]
        public void DumpStackTraceTest01(AphidInterpreter interpreter)
        {
            AphidCli.DumpStackTrace(interpreter);
            // TODO: add assertions to method AphidCliTest.DumpStackTraceTest01(AphidInterpreter)
        }

        /// <summary>Test stub for DumpStackTrace(AphidInterpreter, AphidFrame[])</summary>
        [PexMethod]
        public void DumpStackTraceTest02(AphidInterpreter interpreter, AphidFrame[] trace)
        {
            AphidCli.DumpStackTrace(interpreter, trace);
            // TODO: add assertions to method AphidCliTest.DumpStackTraceTest02(AphidInterpreter, AphidFrame[])
        }

        /// <summary>Test stub for DumpValue(AphidInterpreter, Object, Boolean, Boolean)</summary>
        [PexMethod]
        public void DumpValueTest(
            AphidInterpreter interpreter,
            object value,
            bool ignoreNull,
            bool ignoreClrObj
        )
        {
            AphidCli.DumpValue(interpreter, value, ignoreNull, ignoreClrObj);
            // TODO: add assertions to method AphidCliTest.DumpValueTest(AphidInterpreter, Object, Boolean, Boolean)
        }

        /// <summary>Test stub for get_GetAphidObjectTypeName()</summary>
        [PexMethod]
        public AphidCli.GetAphidObjectTypeNameDelegate GetAphidObjectTypeNameGetTest()
        {
            AphidCli.GetAphidObjectTypeNameDelegate result = AphidCli.GetAphidObjectTypeName
              ;
            return result;
            // TODO: add assertions to method AphidCliTest.GetAphidObjectTypeNameGetTest()
        }

        /// <summary>Test stub for set_GetAphidObjectTypeName(GetAphidObjectTypeNameDelegate)</summary>
        [PexMethod]
        public void GetAphidObjectTypeNameSetTest(AphidCli.GetAphidObjectTypeNameDelegate value)
        {
            AphidCli.GetAphidObjectTypeName = value;
            // TODO: add assertions to method AphidCliTest.GetAphidObjectTypeNameSetTest(GetAphidObjectTypeNameDelegate)
        }

        /// <summary>Test stub for get_GetAphidTypeName()</summary>
        [PexMethod]
        public AphidCli.GetAphidTypeNameDelegate GetAphidTypeNameGetTest()
        {
            AphidCli.GetAphidTypeNameDelegate result = AphidCli.GetAphidTypeName;
            return result;
            // TODO: add assertions to method AphidCliTest.GetAphidTypeNameGetTest()
        }

        /// <summary>Test stub for set_GetAphidTypeName(GetAphidTypeNameDelegate)</summary>
        [PexMethod]
        public void GetAphidTypeNameSetTest(AphidCli.GetAphidTypeNameDelegate value)
        {
            AphidCli.GetAphidTypeName = value;
            // TODO: add assertions to method AphidCliTest.GetAphidTypeNameSetTest(GetAphidTypeNameDelegate)
        }

        /// <summary>Test stub for get_GetObjectTypeFullName()</summary>
        [PexMethod]
        public AphidCli.GetObjectTypeFullNameDelegate GetObjectTypeFullNameGetTest()
        {
            AphidCli.GetObjectTypeFullNameDelegate result = AphidCli.GetObjectTypeFullName;
            return result;
            // TODO: add assertions to method AphidCliTest.GetObjectTypeFullNameGetTest()
        }

        /// <summary>Test stub for set_GetObjectTypeFullName(GetObjectTypeFullNameDelegate)</summary>
        [PexMethod]
        public void GetObjectTypeFullNameSetTest(AphidCli.GetObjectTypeFullNameDelegate value)
        {
            AphidCli.GetObjectTypeFullName = value;
            // TODO: add assertions to method AphidCliTest.GetObjectTypeFullNameSetTest(GetObjectTypeFullNameDelegate)
        }

        /// <summary>Test stub for get_GetObjectTypeName()</summary>
        [PexMethod]
        public AphidCli.GetObjectTypeNameDelegate GetObjectTypeNameGetTest()
        {
            AphidCli.GetObjectTypeNameDelegate result = AphidCli.GetObjectTypeName;
            return result;
            // TODO: add assertions to method AphidCliTest.GetObjectTypeNameGetTest()
        }

        /// <summary>Test stub for set_GetObjectTypeName(GetObjectTypeNameDelegate)</summary>
        [PexMethod]
        public void GetObjectTypeNameSetTest(AphidCli.GetObjectTypeNameDelegate value)
        {
            AphidCli.GetObjectTypeName = value;
            // TODO: add assertions to method AphidCliTest.GetObjectTypeNameSetTest(GetObjectTypeNameDelegate)
        }

        /// <summary>Test stub for get_GetTypeFullName()</summary>
        [PexMethod]
        public AphidCli.GetTypeFullNameDelegate GetTypeFullNameGetTest()
        {
            AphidCli.GetTypeFullNameDelegate result = AphidCli.GetTypeFullName;
            return result;
            // TODO: add assertions to method AphidCliTest.GetTypeFullNameGetTest()
        }

        /// <summary>Test stub for set_GetTypeFullName(GetTypeFullNameDelegate)</summary>
        [PexMethod]
        public void GetTypeFullNameSetTest(AphidCli.GetTypeFullNameDelegate value)
        {
            AphidCli.GetTypeFullName = value;
            // TODO: add assertions to method AphidCliTest.GetTypeFullNameSetTest(GetTypeFullNameDelegate)
        }

        /// <summary>Test stub for get_GetTypeName()</summary>
        [PexMethod]
        public AphidCli.GetTypeNameDelegate GetTypeNameGetTest()
        {
            AphidCli.GetTypeNameDelegate result = AphidCli.GetTypeName;
            return result;
            // TODO: add assertions to method AphidCliTest.GetTypeNameGetTest()
        }

        /// <summary>Test stub for set_GetTypeName(GetTypeNameDelegate)</summary>
        [PexMethod]
        public void GetTypeNameSetTest(AphidCli.GetTypeNameDelegate value)
        {
            AphidCli.GetTypeName = value;
            // TODO: add assertions to method AphidCliTest.GetTypeNameSetTest(GetTypeNameDelegate)
        }

        /// <summary>Test stub for get_GetUnwrappedType()</summary>
        [PexMethod]
        public AphidCli.GetUnwrappedTypeDelegate GetUnwrappedTypeGetTest()
        {
            AphidCli.GetUnwrappedTypeDelegate result = AphidCli.GetUnwrappedType;
            return result;
            // TODO: add assertions to method AphidCliTest.GetUnwrappedTypeGetTest()
        }

        /// <summary>Test stub for set_GetUnwrappedType(GetUnwrappedTypeDelegate)</summary>
        [PexMethod]
        public void GetUnwrappedTypeSetTest(AphidCli.GetUnwrappedTypeDelegate value)
        {
            AphidCli.GetUnwrappedType = value;
            // TODO: add assertions to method AphidCliTest.GetUnwrappedTypeSetTest(GetUnwrappedTypeDelegate)
        }

        /// <summary>Test stub for Redirect(Action)</summary>
        [PexMethod]
        public string RedirectTest(Action action)
        {
            string result = AphidCli.Redirect(action);
            return result;
            // TODO: add assertions to method AphidCliTest.RedirectTest(Action)
        }

        /// <summary>Test stub for SafeWriteSubheader(String)</summary>
        [PexMethod]
        public void SafeWriteSubheaderTest(string text)
        {
            AphidCli.SafeWriteSubheader(text);
            // TODO: add assertions to method AphidCliTest.SafeWriteSubheaderTest(String)
        }

        /// <summary>Test stub for TryAction(AphidInterpreter, String, Action)</summary>
        [PexMethod]
        public bool TryActionTest(
            AphidInterpreter interpreter,
            string code,
            Action action
        )
        {
            bool result = AphidCli.TryAction(interpreter, code, action);
            return result;
            // TODO: add assertions to method AphidCliTest.TryActionTest(AphidInterpreter, String, Action)
        }

        /// <summary>Test stub for TryAction(AphidInterpreter, String, Action, Boolean)</summary>
        [PexMethod]
        public bool TryActionTest01(
            AphidInterpreter interpreter,
            string code,
            Action action,
            bool allowErrorReporting
        )
        {
            bool result = AphidCli.TryAction(interpreter, code, action, allowErrorReporting)
              ;
            return result;
            // TODO: add assertions to method AphidCliTest.TryActionTest01(AphidInterpreter, String, Action, Boolean)
        }

        /// <summary>Test stub for TryAction(AphidInterpreter, Func`1&lt;String&gt;, Action, Boolean)</summary>
        [PexMethod]
        public bool TryActionTest02(
            AphidInterpreter interpreter,
            Func<string> getCode,
            Action action,
            bool allowErrorReporting
        )
        {
            bool result
               = AphidCli.TryAction(interpreter, getCode, action, allowErrorReporting);
            return result;
            // TODO: add assertions to method AphidCliTest.TryActionTest02(AphidInterpreter, Func`1<String>, Action, Boolean)
        }

        /// <summary>Test stub for get_Unwrap()</summary>
        [PexMethod]
        public AphidCli.UnwrapDelegate UnwrapGetTest()
        {
            AphidCli.UnwrapDelegate result = AphidCli.Unwrap;
            return result;
            // TODO: add assertions to method AphidCliTest.UnwrapGetTest()
        }

        /// <summary>Test stub for set_Unwrap(UnwrapDelegate)</summary>
        [PexMethod]
        public void UnwrapSetTest(AphidCli.UnwrapDelegate value)
        {
            AphidCli.Unwrap = value;
            // TODO: add assertions to method AphidCliTest.UnwrapSetTest(UnwrapDelegate)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object[])</summary>
        [PexMethod]
        public void WriteErrorMessageTest(string format, object[] arg)
        {
            AphidCli.WriteErrorMessage(format, arg);
            // TODO: add assertions to method AphidCliTest.WriteErrorMessageTest(String, Object[])
        }

        /// <summary>Test stub for WriteLineHighlighted(String)</summary>
        [PexMethod]
        public void WriteLineHighlightedTest(string text)
        {
            AphidCli.WriteLineHighlighted(text);
            // TODO: add assertions to method AphidCliTest.WriteLineHighlightedTest(String)
        }

        /// <summary>Test stub for WriteLineHighlighted(String, Boolean)</summary>
        [PexMethod]
        public void WriteLineHighlightedTest01(string text, bool escapeStyles)
        {
            AphidCli.WriteLineHighlighted(text, escapeStyles);
            // TODO: add assertions to method AphidCliTest.WriteLineHighlightedTest01(String, Boolean)
        }

        /// <summary>Test stub for WriteMessage(ConsoleColor, Char, String, Object[])</summary>
        [PexMethod]
        public void WriteMessageTest(
            ConsoleColor tokenColor,
            char token,
            string format,
            object[] arg
        )
        {
            AphidCli.WriteMessage(tokenColor, token, format, arg);
            // TODO: add assertions to method AphidCliTest.WriteMessageTest(ConsoleColor, Char, String, Object[])
        }

        /// <summary>Test stub for WriteSubheader(String, String)</summary>
        [PexMethod]
        public void WriteSubheaderTest(string text, string style)
        {
            AphidCli.WriteSubheader(text, style);
            // TODO: add assertions to method AphidCliTest.WriteSubheaderTest(String, String)
        }
    }
}
