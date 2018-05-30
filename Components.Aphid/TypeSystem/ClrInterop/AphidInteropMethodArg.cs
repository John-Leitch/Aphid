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
        private static Dictionary<ParameterInfo, ParameterInfoCache> _paramCache =
            new Dictionary<ParameterInfo, ParameterInfoCache>();

        private ParameterInfoCache _paramInfo;

        private ArgumentTypeCache _argInfo;

        public object Argument { get; private set; }

        public Type ArgumentType { get; private set; }

        public Type TargetType 
        {
            get { return _paramInfo.TargetType; }
        }

        public MethodInfo ImplicitConversionOperator
        {
            get { return _argInfo.ImplicitConversionOperator; }
        }

        public MethodInfo ExplicitConversionOperator
        {
            get { return _argInfo.ExplicitConversionOperator; }
        }

        public bool HasImplicitConversion
        {
            get { return _argInfo.HasImplicitConversion; }
        }

        public bool HasExplicitConversion
        {
            get { return _argInfo.HasExplicitConversion; }
        }

        public bool HasToStringConversion
        {
            get { return _argInfo.HasToStringConversion; }
        }

        public bool IsDerivedFromUserReferenceType
        {
            get { return _argInfo.IsDerivedFromUserReferenceType; }
        }

        public bool IsNonRootImplementationOfTarget
        {
            get { return _argInfo.IsNonRootImplementationOfTarget; }
        }

        public bool IsExactTypeMatch
        {
            get { return _argInfo.IsExactTypeMatch; }
        }

        public bool IsPrecisionLost
        {
            get { return _argInfo.IsPrecisionLost; }
        }

        public bool IsSafeConvertibleNumberPair
        {
            get { return IsConvertibleNumberPair && !IsPrecisionLost; }
        }

        public bool IsUnsafeConvertibleNumberPair
        {
            get { return IsConvertibleNumberPair && IsPrecisionLost; }
        }

        public bool HasParamArray
        {
            get { return _paramInfo.HasParamArray; }
        }

        public bool IsConvertibleNumberPair { get; private set; }

        public bool IsExactBasicTypeMatch { get; private set; }

        public bool IsExactUserReferenceTypeMatch { get; private set; }

        public bool ConstructsParamArray { get; private set; }

        public bool PassesParamArray { get; private set; }

        public bool IsGeneric { get; private set; }

        public bool IsValueTypeEnumerable { get; set; }

        private AphidInteropMethodArg(
            ParameterInfo parameter,
            object argument,
            bool? constructsParamArray = null)
        {
            Argument = argument;

            if (argument != null)
            {
                ArgumentType = argument.GetType();

                lock (_paramCache)
                {
                    if (!_paramCache.TryGetValue(parameter, out _paramInfo))
                    {
                        _paramCache.Add(
                            parameter,
                            _paramInfo = new ParameterInfoCache(parameter, ArgumentType));

                        _argInfo = _paramInfo.InitialArgumentTypeCache;
                    }
                    else if (!_paramInfo.ArgumentTypeCache.TryGetValue(ArgumentType, out _argInfo))
                    {
                        _paramInfo.ArgumentTypeCache.Add(
                            ArgumentType,
                            _argInfo = new ArgumentTypeCache(
                                ArgumentType,
                                _paramInfo,
                                _paramInfo.TargetType));
                    }
                }
            }
            else
            {
                lock (_paramCache)
                {
                    if (!_paramCache.TryGetValue(parameter, out _paramInfo))
                    {
                        _paramCache.Add(
                            parameter,
                            _paramInfo = new ParameterInfoCache(parameter));
                    }

                    _argInfo = new ArgumentTypeCache();
                }
            }

            IsGeneric = TargetType.IsGenericType;

            if (_argInfo.NeedsStringToCharCheck)
            {
                if (((string)Argument).Length == 1)
                {
                    IsExactBasicTypeMatch = true;
                }

                //IsExactUserReferenceTypeMatch = false;
                
            }
            else if (_argInfo.NeedsDecimalFitCheck)
            {
                IsConvertibleNumberPair = AphidTypeConverter.CanConvertDecimal(
                    (decimal)Argument,
                    TargetType);
            }
            else
            {
                IsConvertibleNumberPair = _argInfo.IsConvertibleNumberPair;
                IsExactBasicTypeMatch = _argInfo.IsExactBasicTypeMatch;
                IsExactUserReferenceTypeMatch = _argInfo.IsExactUserReferenceTypeMatch;
            }

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
