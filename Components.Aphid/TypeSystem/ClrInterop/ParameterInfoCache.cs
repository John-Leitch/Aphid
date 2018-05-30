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
        public Type TargetType { get; private set; }

        public bool HasParamArray { get; private set; }

        public bool IsClass { get; private set; }

        public bool IsCharArray { get; private set; }

        public bool IsArray { get; private set; }

        public Dictionary<Type, ArgumentTypeCache> ArgumentTypeCache { get; private set; }

        public ArgumentTypeCache InitialArgumentTypeCache { get; private set; }

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
