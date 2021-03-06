using System.Collections.Generic;
using System.Collections;
using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for ValueHelper</summary>
    [TestClass]
    [PexClass(typeof(ValueHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ValueHelperTest
    {

        /// <summary>Test stub for .ctor(AphidInterpreter)</summary>
        [PexMethod]
        public ValueHelper ConstructorTest(AphidInterpreter interpreter)
        {
            ValueHelper target = new ValueHelper(interpreter);
            return target;
            // TODO: add assertions to method ValueHelperTest.ConstructorTest(AphidInterpreter)
        }

        /// <summary>Test stub for AssertBool(Object, String)</summary>
        [PexMethod]
        public void AssertBoolTest(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertBool(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertBoolTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for AssertFunction(Object, String)</summary>
        [PexMethod]
        public void AssertFunctionTest(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertFunction(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertFunctionTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for AssertList(Object, String)</summary>
        [PexMethod]
        public void AssertListTest(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertList(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertListTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for AssertNumber(Object, String)</summary>
        [PexMethod]
        public void AssertNumberTest(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertNumber(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertNumberTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for AssertObject(Object, String)</summary>
        [PexMethod]
        public void AssertObjectTest(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertObject(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertObjectTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for AssertString(Object, String)</summary>
        [PexMethod]
        public void AssertStringTest(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertString(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertStringTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for AssertValue(Object, String)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void AssertValueTest<TExpected>(
            [PexAssumeUnderTest]ValueHelper target,
            object value,
            string operation
        )
        {
            target.AssertValue<TExpected>(value, operation);
            // TODO: add assertions to method ValueHelperTest.AssertValueTest(ValueHelper, Object, String)
        }

        /// <summary>Test stub for DeepUnwrap(Object)</summary>
        [PexMethod]
        public object DeepUnwrapTest(object obj)
        {
            object result = ValueHelper.DeepUnwrap(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.DeepUnwrapTest(Object)
        }

        /// <summary>Test stub for DeepUnwrapObjectArrayRef(Object[])</summary>
        [PexMethod]
        public object[] DeepUnwrapObjectArrayRefTest(object[] array)
        {
            object[] result = ValueHelper.DeepUnwrapObjectArrayRef(array);
            return result;
            // TODO: add assertions to method ValueHelperTest.DeepUnwrapObjectArrayRefTest(Object[])
        }

        /// <summary>Test stub for GetTypeName(Type)</summary>
        [PexMethod]
        public string GetTypeNameTest([PexAssumeUnderTest]ValueHelper target, Type type)
        {
            string result = target.GetTypeName(type);
            return result;
            // TODO: add assertions to method ValueHelperTest.GetTypeNameTest(ValueHelper, Type)
        }

        /// <summary>Test stub for GetTypeName()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public string GetTypeNameTest01<T>([PexAssumeUnderTest]ValueHelper target)
        {
            string result = target.GetTypeName<T>();
            return result;
            // TODO: add assertions to method ValueHelperTest.GetTypeNameTest01(ValueHelper)
        }

        /// <summary>Test stub for GetTypeName(Object)</summary>
        [PexMethod]
        public string GetTypeNameTest02([PexAssumeUnderTest]ValueHelper target, object value)
        {
            string result = target.GetTypeName(value);
            return result;
            // TODO: add assertions to method ValueHelperTest.GetTypeNameTest02(ValueHelper, Object)
        }

        /// <summary>Test stub for Unwrap(AphidObject)</summary>
        [PexMethod]
        public object UnwrapTest(AphidObject obj)
        {
            object result = ValueHelper.Unwrap(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.UnwrapTest(AphidObject)
        }

        /// <summary>Test stub for Unwrap(Object)</summary>
        [PexMethod]
        public object UnwrapTest01(object obj)
        {
            object result = ValueHelper.Unwrap(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.UnwrapTest01(Object)
        }

        /// <summary>Test stub for UnwrapIEnumerable(Object)</summary>
        [PexMethod]
        public IEnumerable UnwrapIEnumerableTest([PexAssumeUnderTest]ValueHelper target, object obj)
        {
            IEnumerable result = target.UnwrapIEnumerable(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.UnwrapIEnumerableTest(ValueHelper, Object)
        }

        /// <summary>Test stub for UnwrapIEnumerableObject(Object)</summary>
        [PexMethod]
        public IEnumerable<object> UnwrapIEnumerableObjectTest([PexAssumeUnderTest]ValueHelper target, object obj)
        {
            IEnumerable<object> result = target.UnwrapIEnumerableObject(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.UnwrapIEnumerableObjectTest(ValueHelper, Object)
        }

        /// <summary>Test stub for UnwrapObjectArray(Object[])</summary>
        [PexMethod]
        public object[] UnwrapObjectArrayTest(object[] srcArray)
        {
            object[] result = ValueHelper.UnwrapObjectArray(srcArray);
            return result;
            // TODO: add assertions to method ValueHelperTest.UnwrapObjectArrayTest(Object[])
        }

        /// <summary>Test stub for UnwrapObjectArrayRef(Object[])</summary>
        [PexMethod]
        public object[] UnwrapObjectArrayRefTest(object[] array)
        {
            object[] result = ValueHelper.UnwrapObjectArrayRef(array);
            return result;
            // TODO: add assertions to method ValueHelperTest.UnwrapObjectArrayRefTest(Object[])
        }

        /// <summary>Test stub for Wrap(Object)</summary>
        [PexMethod]
        public AphidObject WrapTest(object obj)
        {
            AphidObject result = ValueHelper.Wrap(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.WrapTest(Object)
        }

        /// <summary>Test stub for WrapNonNull(Object)</summary>
        [PexMethod]
        public object WrapNonNullTest([PexAssumeUnderTest]ValueHelper target, object obj)
        {
            object result = target.WrapNonNull(obj);
            return result;
            // TODO: add assertions to method ValueHelperTest.WrapNonNullTest(ValueHelper, Object)
        }

        /// <summary>Test stub for WrapObjectArray(Object[])</summary>
        [PexMethod]
        public AphidObject[] WrapObjectArrayTest(object[] srcArray)
        {
            AphidObject[] result = ValueHelper.WrapObjectArray(srcArray);
            return result;
            // TODO: add assertions to method ValueHelperTest.WrapObjectArrayTest(Object[])
        }

        /// <summary>Test stub for WrapObjectArrayRef(Object[])</summary>
        [PexMethod]
        public object[] WrapObjectArrayRefTest(object[] array)
        {
            object[] result = ValueHelper.WrapObjectArrayRef(array);
            return result;
            // TODO: add assertions to method ValueHelperTest.WrapObjectArrayRefTest(Object[])
        }
    }
}
