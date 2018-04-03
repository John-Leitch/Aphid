using Components.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    // Todo: refactor properties into AphidConversionInfo and logic into AphidTypeConverter.
    public class AphidInteropMethodArg
    {
        public object Argument { get; private set; }

        public Type ArgumentType { get; private set; }

        public Type TargetType { get; private set; }

        public MethodInfo ImplicitConversionOperator { get; private set; }

        public MethodInfo ExplicitConversionOperator { get; private set; }

        public bool HasImplicitConversion { get; private set; }

        public bool HasExplicitConversion { get; private set; }

        public bool HasToStringConversion { get; private set; }

        public bool IsExactBasicTypeMatch { get; private set; }

        public bool IsExactUserReferenceTypeMatch { get; private set; }

        public bool IsDerivedFromUserReferenceType { get; private set; }

        public bool IsNonRootImplementationOfTarget { get; private set; }

        public bool IsExactTypeMatch { get; private set; }

        public bool IsConvertibleNumberPair { get; private set; }

        public bool IsPrecisionLost { get; private set; }

        public bool IsSafeConvertibleNumberPair
        {
            get { return IsConvertibleNumberPair && !IsPrecisionLost; }
        }

        public bool IsUnsafeConvertibleNumberPair
        {
            get { return IsConvertibleNumberPair && IsPrecisionLost; }
        }

        public bool HasParamArray { get; private set; }

        public bool ConstructsParamArray { get; private set; }

        public bool PassesParamArray { get; private set; }

        private AphidInteropMethodArg(
            ParameterInfo parameter,
            object argument,
            bool? constructsParamArray = null)
        {
            Argument = argument;

            ArgumentType = argument != null ?
                argument.GetType() :
                null;

            TargetType = parameter.ParameterType;

            if (IsExactTypeMatch = ArgumentType == TargetType)
            {
                IsExactBasicTypeMatch =
                    ArgumentType.IsPrimitive ||
                    ArgumentType.IsEnum ||
                    ArgumentType == typeof(string) ||
                    ArgumentType == typeof(decimal);

                IsExactUserReferenceTypeMatch = ArgumentType.IsClass && ArgumentType != typeof(object);
                HasToStringConversion = TargetType == typeof(string);
            }
            else if ((ArgumentType == typeof(string) &&
                    TargetType == typeof(char) &&
                    ((string)Argument).Length == 1) ||
                (ArgumentType == typeof(char) && TargetType == typeof(string)))
            {
                IsExactBasicTypeMatch = true;
                IsExactUserReferenceTypeMatch = false;
                HasToStringConversion = TargetType == typeof(string);
            }
            else
            {
                if (ArgumentType != null)
                {
                    if ((ImplicitConversionOperator = ConversionOperator.GetImplicitOperator(
                        TargetType,
                        ArgumentType)) != null)
                    {
                        HasImplicitConversion = true;
                    }
                    else if ((ExplicitConversionOperator = ConversionOperator.GetExplicitOperator(
                        TargetType,
                        ArgumentType)) != null)
                    {
                        HasExplicitConversion = true;
                    }

                    if (TargetType == typeof(string))
                    {
                        HasToStringConversion = true;
                    }
                }

                IsExactBasicTypeMatch = IsExactUserReferenceTypeMatch = false;
            }

            IsDerivedFromUserReferenceType =
                TargetType.IsClass &&
                TargetType != typeof(object) &&
                TargetType != typeof(object[]) &&
                (ArgumentType == null ||
                    (ArgumentType.IsClass &&
                    ArgumentType.IsDerivedFrom(TargetType)));

            IsNonRootImplementationOfTarget =
                TargetType.IsInterface &&
                ArgumentType != null &&
                ArgumentType != typeof(object) &&
                ArgumentType.GetInterfaces().Contains(TargetType);

            if (ArgumentType == typeof(decimal) && AphidTypeConverter.IsNumber(TargetType))
            {
                IsConvertibleNumberPair = AphidTypeConverter.CanConvertDecimal(
                    (decimal)Argument,
                    TargetType);

                IsPrecisionLost = TargetType == typeof(float) || TargetType == typeof(double);
            }
            else if (TargetType == typeof(decimal) && AphidTypeConverter.IsNumber(ArgumentType))
            {
                IsConvertibleNumberPair = true;
            }
            else
            {
                // Todo: cover non-decimal to non-decimal checks e.g.
                // ulong to uint -> uint.MinValue <= ulongValue && ulongValue <= uint.MaxValue
                IsConvertibleNumberPair = false;
            }

            HasParamArray = parameter.IsDefined(typeof(ParamArrayAttribute));

            if (HasParamArray)
            {
                if (constructsParamArray == null)
                {
                    if (!HasParamArray)
                    {
                        ConstructsParamArray = false;
                        PassesParamArray = false;
                    }
                    else
                    {
                        if (!IsExactTypeMatch &&
                            ArgumentType != null &&
                            ArgumentType.GetInterface("IEnumerable") != null)
                        {
                            ConstructsParamArray = true;
                            PassesParamArray = false;
                        }
                        else
                        {
                            ConstructsParamArray = false;
                            PassesParamArray = true;
                        }
                    }
                }
                else
                {
                    ConstructsParamArray = constructsParamArray.Value;
                    PassesParamArray = !ConstructsParamArray;
                }
            }
        }

        public AphidInteropMethodArg(object argument, ParameterInfo parameter)
            : this(parameter, argument)
        {
            
        }

        public AphidInteropMethodArg(object argument, ParameterInfo parameter, bool constructsParamArray)
            : this(parameter, argument, constructsParamArray)
        {
        }
    }
}
