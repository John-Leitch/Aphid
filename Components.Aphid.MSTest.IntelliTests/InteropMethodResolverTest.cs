using System.Reflection;
using System.Threading;
using Components.Aphid.Parser;
using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for InteropMethodResolver</summary>
    [TestClass]
    [PexClass(typeof(InteropMethodResolver))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class InteropMethodResolverTest
    {

        /// <summary>Test stub for .ctor(AphidInterpreter, Func`5&lt;Object,BinaryOperatorExpression,Boolean,Func`1&lt;AphidObject&gt;,AphidObject&gt;, ReaderWriterLockSlim)</summary>
        [PexMethod]
        public InteropMethodResolver ConstructorTest(
            AphidInterpreter interpreter,
            Func<object, BinaryOperatorExpression, bool, Func<AphidObject>, AphidObject> interpretMemberInteropExpression,
            ReaderWriterLockSlim importsLock
        )
        {
            InteropMethodResolver target
               = new InteropMethodResolver(interpreter, interpretMemberInteropExpression, importsLock);
            return target;
            // TODO: add assertions to method InteropMethodResolverTest.ConstructorTest(AphidInterpreter, Func`5<Object,BinaryOperatorExpression,Boolean,Func`1<AphidObject>,AphidObject>, ReaderWriterLockSlim)
        }

        /// <summary>Test stub for GetMethodDescription(MethodBase)</summary>
        [PexMethod]
        public string GetMethodDescriptionTest([PexAssumeUnderTest]InteropMethodResolver target, MethodBase method)
        {
            string result = target.GetMethodDescription(method);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.GetMethodDescriptionTest(InteropMethodResolver, MethodBase)
        }

        /// <summary>Test stub for Resolve(String, Object[])</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public AphidInteropMethodInfo ResolveTest<TTargetType>(
            [PexAssumeUnderTest]InteropMethodResolver target,
            string methodName,
            object[] args
        )
        {
            AphidInteropMethodInfo result = target.Resolve<TTargetType>(methodName, args);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.ResolveTest(InteropMethodResolver, String, Object[])
        }

        /// <summary>Test stub for Resolve(Type, String, Object[])</summary>
        [PexMethod]
        public AphidInteropMethodInfo ResolveTest01(
            [PexAssumeUnderTest]InteropMethodResolver target,
            Type targetType,
            string methodName,
            object[] args
        )
        {
            AphidInteropMethodInfo result = target.Resolve(targetType, methodName, args);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.ResolveTest01(InteropMethodResolver, Type, String, Object[])
        }

        /// <summary>Test stub for Resolve(MethodBase[], Object[])</summary>
        [PexMethod]
        public AphidInteropMethodInfo ResolveTest02(
            [PexAssumeUnderTest]InteropMethodResolver target,
            MethodBase[] nameMatches,
            object[] args
        )
        {
            AphidInteropMethodInfo result = target.Resolve(nameMatches, args);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.ResolveTest02(InteropMethodResolver, MethodBase[], Object[])
        }

        /// <summary>Test stub for TryResolveInstanceMember(BinaryOperatorExpression, AphidObject, Boolean)</summary>
        [PexMethod]
        public object TryResolveInstanceMemberTest(
            [PexAssumeUnderTest]InteropMethodResolver target,
            BinaryOperatorExpression expression,
            AphidObject obj,
            bool returnRef
        )
        {
            object result = target.TryResolveInstanceMember(expression, obj, returnRef);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.TryResolveInstanceMemberTest(InteropMethodResolver, BinaryOperatorExpression, AphidObject, Boolean)
        }

        /// <summary>Test stub for TryResolveMember(BinaryOperatorExpression, AphidObject, Boolean)</summary>
        [PexMethod]
        public object TryResolveMemberTest(
            [PexAssumeUnderTest]InteropMethodResolver target,
            BinaryOperatorExpression expression,
            AphidObject obj,
            bool returnRef
        )
        {
            object result = target.TryResolveMember(expression, obj, returnRef);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.TryResolveMemberTest(InteropMethodResolver, BinaryOperatorExpression, AphidObject, Boolean)
        }

        /// <summary>Test stub for TryResolveStaticMember(BinaryOperatorExpression, Boolean)</summary>
        [PexMethod]
        public object TryResolveStaticMemberTest(
            [PexAssumeUnderTest]InteropMethodResolver target,
            BinaryOperatorExpression expression,
            bool returnRef
        )
        {
            object result = target.TryResolveStaticMember(expression, returnRef);
            return result;
            // TODO: add assertions to method InteropMethodResolverTest.TryResolveStaticMemberTest(InteropMethodResolver, BinaryOperatorExpression, Boolean)
        }
    }
}
