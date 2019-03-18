using Components.External;
using System;
using System.Linq;
using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class ArgumentTypeCache
    {
        public bool IsExactTypeMatch { get; }

        public bool IsExactBasicTypeMatch { get; }

        public bool IsExactUserReferenceTypeMatch { get; }

        public bool IsDerivedFromUserReferenceType { get; }

        public bool IsNonRootImplementationOfTarget { get; }

        public MethodInfo ImplicitConversionOperator { get; }

        public MethodInfo ExplicitConversionOperator { get; }

        public bool HasImplicitConversion { get; }

        public bool HasExplicitConversion { get; }

        public bool HasToStringConversion { get; }

        public bool NeedsStringToCharCheck { get; }

        public bool NeedsDecimalFitCheck { get; }

        public bool IsPrecisionLost { get; }

        public bool IsConvertibleNumberPair { get; }

        public ArgumentTypeCache(
            Type argumentType,
            ParameterInfoCache targetParam,
            Type targetType)
        {
            if (IsExactTypeMatch = argumentType == targetType)
            {
                IsExactBasicTypeMatch =
                    argumentType.IsPrimitive ||
                    argumentType.IsEnum ||
                    argumentType == typeof(string) ||
                    argumentType == typeof(decimal);

                IsExactUserReferenceTypeMatch = argumentType.IsClass && argumentType != typeof(object);
                HasToStringConversion = targetType == typeof(string);
            }
            else if (argumentType == typeof(string) && targetType == typeof(char[]))
            {
                IsExactBasicTypeMatch = false;
                IsExactUserReferenceTypeMatch = false;
                HasToStringConversion = targetType == typeof(string);
            }
            else if (argumentType == typeof(char) && targetType == typeof(string))
            {
                IsExactBasicTypeMatch = true;
                IsExactUserReferenceTypeMatch = false;
                HasToStringConversion = targetType == typeof(string);
            }
            else if (argumentType != typeof(string) || targetType != typeof(char))
            {
                if ((ImplicitConversionOperator = ConversionOperator.GetImplicitOperator(
                    targetType,
                    argumentType)) != null)
                {
                    HasImplicitConversion = true;
                }
                else if ((ExplicitConversionOperator = ConversionOperator.GetExplicitOperator(
                    targetType,
                    argumentType)) != null)
                {
                    HasExplicitConversion = true;
                }

                if (targetType == typeof(string))
                {
                    HasToStringConversion = true;
                }

                IsExactBasicTypeMatch = IsExactUserReferenceTypeMatch = false;
            }
            else
            {
                HasToStringConversion = targetType == typeof(string);
                NeedsStringToCharCheck = true;
            }

            IsDerivedFromUserReferenceType =
                targetParam.IsClass &&
                targetType != typeof(object) &&
                targetType != typeof(object[]) &&
                (argumentType == null ||
                    (argumentType.IsClass &&
                    argumentType.IsDerivedFrom(targetType)));

            IsNonRootImplementationOfTarget =
                targetType.IsInterface &&
                argumentType != null &&
                argumentType != typeof(object) &&
                argumentType.GetInterfaces().Contains(targetType);

            if (argumentType == typeof(decimal) && AphidTypeConverter.IsNumber(targetType))
            {
                NeedsDecimalFitCheck = true;
                IsPrecisionLost = targetType == typeof(float) || targetType == typeof(double);
            }
            else if (targetType == typeof(decimal) && AphidTypeConverter.IsNumber(argumentType))
            {
                IsConvertibleNumberPair = true;
            }
            else
            {
                // Todo: cover non-decimal to non-decimal checks e.g.
                // ulong to uint -> uint.MinValue <= ulongValue && ulongValue <= uint.MaxValue
                IsConvertibleNumberPair = false;
            }
        }

        public ArgumentTypeCache()
        {
        }
    }
}
