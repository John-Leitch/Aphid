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
        public static Dictionary<ParameterInfo, ParameterInfoCache> ParamCache =
            new Dictionary<ParameterInfo, ParameterInfoCache>();

        private ParameterInfoCache _paramInfo;

        private ArgumentTypeCache _argInfo;

        public object Argument { get; private set; }

        public Type ArgumentType { get; private set; }

        public Type TargetType => _paramInfo.TargetType;

        public MethodInfo ImplicitConversionOperator => _argInfo.ImplicitConversionOperator;

        public MethodInfo ExplicitConversionOperator => _argInfo.ExplicitConversionOperator;

        public bool HasImplicitConversion => _argInfo.HasImplicitConversion;

        public bool HasExplicitConversion => _argInfo.HasExplicitConversion;

        public bool HasToStringConversion => _argInfo.HasToStringConversion;

        public bool IsDerivedFromUserReferenceType => _argInfo.IsDerivedFromUserReferenceType;

        public bool IsNonRootImplementationOfTarget => _argInfo.IsNonRootImplementationOfTarget;

        public bool IsExactTypeMatch => _argInfo.IsExactTypeMatch;

        public bool IsPrecisionLost => _argInfo.IsPrecisionLost;

        public bool IsSafeConvertibleNumberPair => IsConvertibleNumberPair && !IsPrecisionLost;

        public bool IsUnsafeConvertibleNumberPair => IsConvertibleNumberPair && IsPrecisionLost;

        public bool HasParamArray => _paramInfo.HasParamArray;

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

                lock (ParamCache)
                {
                    if (!ParamCache.TryGetValue(parameter, out _paramInfo))
                    {
                        ParamCache.Add(
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
                lock (ParamCache)
                {
                    if (!ParamCache.TryGetValue(parameter, out _paramInfo))
                    {
                        ParamCache.Add(
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

        public AphidInteropMethodArg(object argument, ParameterInfoCache parameterInfo)
            : this(argument, parameterInfo, constructsParamArray: null)
        {
            
        }

        public AphidInteropMethodArg(
            object argument,
            ParameterInfoCache parameterInfo,
            bool? constructsParamArray)
        {
            _paramInfo = parameterInfo;
            Argument = argument;

            if (argument != null)
            {
                ArgumentType = argument.GetType();

                if (!_paramInfo.ArgumentTypeCache.TryGetValue(ArgumentType, out _argInfo))
                {
                    _paramInfo.ArgumentTypeCache.Add(
                        ArgumentType,
                        _argInfo = new ArgumentTypeCache(
                            ArgumentType,
                            _paramInfo,
                            _paramInfo.TargetType));
                }
            }
            else
            {
                _argInfo = new ArgumentTypeCache();
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
    }
}
