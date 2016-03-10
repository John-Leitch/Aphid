﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public static class InteropMethodResolver
    {
        public static AphidInteropMethodInfo Resolve<TTargetType>(string methodName, object[] args)
        {
            return Resolve(typeof(TTargetType), methodName, args);
        }

        public static AphidInteropMethodInfo Resolve(Type targetType, string methodName, object[] args)
        {
            return Resolve(
                targetType
                    .GetMethods()
                    .Where(x => x.Name == methodName && x.GetParameters().Length == args.Length),
                args);
        }

        public static AphidInteropMethodInfo Resolve(IEnumerable<MethodInfo> nameMatches, object[] args)
        {
            var methods = nameMatches
                .Where(x => x.GetParameters().Length == args.Length)
                .Select(x => new
                {
                    Method = x,
                    Args = x
                        .GetParameters()
                        .Select((y, i) => new AphidInteropMethodArg(args[i], y.ParameterType))
                        .ToArray()
                })
                .Select(x => new 
                {
                    x.Method,
                    x.Args,
                    ConversionInfo = x.Args
                        .Select(y =>  AphidTypeConverter.CanConvert(y.Argument, y.TargetType))
                        .ToArray()
                })
                .Where(x => x.ConversionInfo.All(y => y.CanConvert))
                .Select(x => new AphidInteropMethodInfo(
                    x.Method,
                    x.ConversionInfo
                        .Where(y => y.GenericArguments != null)
                        .SelectMany(y => y.GenericArguments)
                        .ToArray(),
                    x.Args))
                .ToArray();

            if (methods.Length != 1)
            {
                throw new AphidRuntimeException("Could not resolve interop method.");
            }

            return methods.Single();
        }
    }
}