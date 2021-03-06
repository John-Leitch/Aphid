using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidTypeConverter</summary>
    [TestClass]
    [PexClass(typeof(AphidTypeConverter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidTypeConverterTest
    {

        /// <summary>Test stub for .ctor(AphidInterpreter)</summary>
        [PexMethod]
        public AphidTypeConverter ConstructorTest(AphidInterpreter interpreter)
        {
            AphidTypeConverter target = new AphidTypeConverter(interpreter);
            return target;
            // TODO: add assertions to method AphidTypeConverterTest.ConstructorTest(AphidInterpreter)
        }

        /// <summary>Test stub for BoxValueTypeEnumerable(IEnumerable)</summary>
        [PexMethod]
        public IEnumerable<object> BoxValueTypeEnumerableTest(IEnumerable valueTypeSource)
        {
            IEnumerable<object> result = AphidTypeConverter.BoxValueTypeEnumerable(valueTypeSource);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.BoxValueTypeEnumerableTest(IEnumerable)
        }

        /// <summary>Test stub for CanConvert(AphidInteropMethodArg, Object, Type)</summary>
        [PexMethod]
        public AphidConversionInfo CanConvertTest(
            [PexAssumeUnderTest]AphidTypeConverter target01,
            AphidInteropMethodArg interopArg,
            object val,
            Type target
        )
        {
            AphidConversionInfo result = target01.CanConvert(interopArg, val, target);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.CanConvertTest(AphidTypeConverter, AphidInteropMethodArg, Object, Type)
        }

        /// <summary>Test stub for CanConvertArray(Object, Type, Type)</summary>
        [PexMethod]
        public bool CanConvertArrayTest(
            object value,
            Type valueType,
            Type targetType
        )
        {
            bool result = AphidTypeConverter.CanConvertArray(value, valueType, targetType);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.CanConvertArrayTest(Object, Type, Type)
        }

        /// <summary>Test stub for CanConvertDecimal(Decimal, Type)</summary>
        [PexMethod]
        public bool CanConvertDecimalTest(decimal value, Type targetType)
        {
            bool result = AphidTypeConverter.CanConvertDecimal(value, targetType);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.CanConvertDecimalTest(Decimal, Type)
        }

        /// <summary>Test stub for CanConvertOrBoxDecimal(Decimal, Type)</summary>
        [PexMethod]
        public bool CanConvertOrBoxDecimalTest(decimal value, Type targetType)
        {
            bool result = AphidTypeConverter.CanConvertOrBoxDecimal(value, targetType);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.CanConvertOrBoxDecimalTest(Decimal, Type)
        }

        /// <summary>Test stub for CanDecimalFit(Decimal, Type)</summary>
        [PexMethod]
        public bool CanDecimalFitTest(decimal value, Type targetType)
        {
            bool result = AphidTypeConverter.CanDecimalFit(value, targetType);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.CanDecimalFitTest(Decimal, Type)
        }

        /// <summary>Test stub for Convert(AphidInteropMethodArg[], Type[])</summary>
        [PexMethod]
        public object[] ConvertTest(
            [PexAssumeUnderTest]AphidTypeConverter target,
            AphidInteropMethodArg[] args,
            Type[] genericArguments
        )
        {
            object[] result = target.Convert(args, genericArguments);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ConvertTest(AphidTypeConverter, AphidInteropMethodArg[], Type[])
        }

        /// <summary>Test stub for Convert(AphidInteropMethodArg, Type[])</summary>
        [PexMethod]
        public object ConvertTest01(
            [PexAssumeUnderTest]AphidTypeConverter target,
            AphidInteropMethodArg arg,
            Type[] genericArguments
        )
        {
            object result = target.Convert(arg, genericArguments);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ConvertTest01(AphidTypeConverter, AphidInteropMethodArg, Type[])
        }

        /// <summary>Test stub for Convert(MethodBase, Object)</summary>
        [PexMethod]
        public object ConvertTest02(MethodBase opMethod, object argument)
        {
            object result = AphidTypeConverter.Convert(opMethod, argument);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ConvertTest02(MethodBase, Object)
        }

        /// <summary>Test stub for Convert(Type, Object, Type[])</summary>
        [PexMethod]
        public object ConvertTest03(
            [PexAssumeUnderTest]AphidTypeConverter target,
            Type targetType,
            object srcValue,
            Type[] genericArguments
        )
        {
            object result = target.Convert(targetType, srcValue, genericArguments);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ConvertTest03(AphidTypeConverter, Type, Object, Type[])
        }

        /// <summary>Test stub for Convert(Type, Decimal)</summary>
        [PexMethod]
        public object ConvertTest04(Type targetType, decimal value)
        {
            object result = AphidTypeConverter.Convert(targetType, value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ConvertTest04(Type, Decimal)
        }

        /// <summary>Test stub for ConvertArray(Type, Type, Array)</summary>
        [PexMethod]
        public object ConvertArrayTest(
            Type targetType,
            Type srcArrayType,
            Array srcArray
        )
        {
            object result = AphidTypeConverter.ConvertArray(targetType, srcArrayType, srcArray);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ConvertArrayTest(Type, Type, Array)
        }

        /// <summary>Test stub for IsNumber(Type)</summary>
        [PexMethod]
        public bool IsNumberTest(Type targetType)
        {
            bool result = AphidTypeConverter.IsNumber(targetType);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.IsNumberTest(Type)
        }

        /// <summary>Test stub for ToByte(Decimal)</summary>
        [PexMethod]
        public byte ToByteTest(decimal value)
        {
            byte result = AphidTypeConverter.ToByte(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToByteTest(Decimal)
        }

        /// <summary>Test stub for ToDouble(Decimal)</summary>
        [PexMethod]
        public double ToDoubleTest(decimal value)
        {
            double result = AphidTypeConverter.ToDouble(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToDoubleTest(Decimal)
        }

        /// <summary>Test stub for ToFloat(Decimal)</summary>
        [PexMethod]
        public float ToFloatTest(decimal value)
        {
            float result = AphidTypeConverter.ToFloat(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToFloatTest(Decimal)
        }

        /// <summary>Test stub for ToInt16(Decimal)</summary>
        [PexMethod]
        public short ToInt16Test(decimal value)
        {
            short result = AphidTypeConverter.ToInt16(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToInt16Test(Decimal)
        }

        /// <summary>Test stub for ToInt32(Decimal)</summary>
        [PexMethod]
        public int ToInt32Test(decimal value)
        {
            int result = AphidTypeConverter.ToInt32(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToInt32Test(Decimal)
        }

        /// <summary>Test stub for ToInt64(Decimal)</summary>
        [PexMethod]
        public long ToInt64Test(decimal value)
        {
            long result = AphidTypeConverter.ToInt64(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToInt64Test(Decimal)
        }

        /// <summary>Test stub for ToSByte(Decimal)</summary>
        [PexMethod]
        public sbyte ToSByteTest(decimal value)
        {
            sbyte result = AphidTypeConverter.ToSByte(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToSByteTest(Decimal)
        }

        /// <summary>Test stub for ToUInt16(Decimal)</summary>
        [PexMethod]
        public ushort ToUInt16Test(decimal value)
        {
            ushort result = AphidTypeConverter.ToUInt16(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToUInt16Test(Decimal)
        }

        /// <summary>Test stub for ToUInt32(Decimal)</summary>
        [PexMethod]
        public uint ToUInt32Test(decimal value)
        {
            uint result = AphidTypeConverter.ToUInt32(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToUInt32Test(Decimal)
        }

        /// <summary>Test stub for ToUInt64(Decimal)</summary>
        [PexMethod]
        public ulong ToUInt64Test(decimal value)
        {
            ulong result = AphidTypeConverter.ToUInt64(value);
            return result;
            // TODO: add assertions to method AphidTypeConverterTest.ToUInt64Test(Decimal)
        }
    }
}
