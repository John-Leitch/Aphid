using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class ParameterInfoCache
    {
        public Type TargetType { get; }

        public bool HasParamArray { get; }

        public bool IsClass { get; }

        public bool IsCharArray { get; }

        public bool IsArray { get; }

        public Dictionary<Type, ArgumentTypeCache> ArgumentTypeCache { get; }

        public ArgumentTypeCache InitialArgumentTypeCache { get; }

        public ParameterInfoCache(ParameterInfo parameter)
        {
            TargetType = parameter.ParameterType;
            HasParamArray = parameter.IsDefined(typeof(ParamArrayAttribute));
            IsClass = TargetType.IsClass;
            IsCharArray = TargetType == typeof(char[]);
            IsArray = TargetType.IsArray;

            ArgumentTypeCache = new Dictionary<Type, ArgumentTypeCache>();
        }

        public ParameterInfoCache(ParameterInfo parameter, Type argumentType)            
        {
            TargetType = parameter.ParameterType;
            HasParamArray = parameter.IsDefined(typeof(ParamArrayAttribute));
            IsClass = TargetType.IsClass;
            IsCharArray = TargetType == typeof(char[]);
            IsArray = TargetType.IsArray;

            ArgumentTypeCache = new Dictionary<Type, ArgumentTypeCache>
            {
                {
                    argumentType,
                    InitialArgumentTypeCache = new ArgumentTypeCache(
                        argumentType,
                        this,
                        TargetType)
                }
            };
        }
    }
}
