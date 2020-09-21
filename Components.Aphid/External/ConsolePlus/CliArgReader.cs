using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components.External.ConsolePlus
{
    public class CliArgReader
    {
        public string[] Arguments { get; set; }

        public bool CaseSensitive { get; set; }

        public bool IgnoreUnknownArgs { get; set; }

        public CliArgReader(string[] arguments)
        {
            Arguments = arguments;
            CaseSensitive = false;
        }

        private Dictionary<string, Tuple<CliArgAttribute, PropertyInfo>> GetArgDictionary(object target)
        {
            var argDictionary = new Dictionary<string, Tuple<CliArgAttribute, PropertyInfo>>();

            var type = target.GetType();

            foreach (var p in type.GetProperties())
            {
                var a = p.GetCustomAttributes(typeof(CliArgAttribute), true);

                if (a.Length == 0)
                {
                    continue;
                }

                var attr = a[0] as CliArgAttribute;

                var names = attr.Names;

                if (!CaseSensitive)
                {
                    names = names.Select(x => x.ToLower()).ToArray();
                }

                var dupes = names.Where(argDictionary.ContainsKey).ToArray();

                if (dupes.Length > 0)
                {
                    throw new InvalidOperationException(
                        string.Format(
                            "Duplicate argument(s): {0}.",
                            string.Join(", ", dupes)));
                }

                foreach (var name in names)
                {
                    argDictionary.Add(name, Tuple.Create(attr, p));
                }
            }

            return argDictionary;
        }

        private static void ThrowArgumentException(string Message, params object[] Args) =>
            throw new ArgumentException(string.Format(Message, Args));

        public void SetProperties(object target)
        {
            var argDictionary = GetArgDictionary(target);
            var argsSet = new List<CliArgAttribute>();

            for (var i = 0; i < Arguments.Length; i++)
            {
                var name = Arguments[i];

                if (!CaseSensitive)
                {
                    name = name.ToLower();
                }

                if (!argDictionary.ContainsKey(name))
                {
                    if (IgnoreUnknownArgs)
                    {
                        continue;
                    }

                    ThrowArgumentException("Invalid argument {0}.", name);
                }

                var arg = argDictionary[name];
                argsSet.Add(arg.Item1);

                var propType = arg.Item2.PropertyType;

                Func<object> getValue = null;

                if (propType == typeof(bool))
                {
                    getValue = () => true;
                }
                else if (++i == Arguments.Length)
                {
                    ThrowArgumentException("No value for argument {0}.", name);
                }
                else if (propType == typeof(string))
                {
                    getValue = () => Arguments[i];
                }
                else if (propType == typeof(int))
                {
                    getValue = () => int.Parse(Arguments[i]);
                }
                else if (propType == typeof(long))
                {
                    getValue = () => long.Parse(Arguments[i]);
                }
                else if (propType == typeof(decimal))
                {
                    getValue = () => decimal.Parse(Arguments[i]);
                }
                else if (propType.IsDerivedFrom(typeof(Enum)))
                {
                    getValue = () =>
                    {
                        var x = Arguments[i].Trim();
                        object result;

                        if (x.StartsWith("0x"))
                        {
                            ulong u;

                            try
                            {
                                u = Convert.ToUInt64(x.Substring(2), 16);
                                result = Enum.ToObject(propType, u);
                            }
                            catch (Exception e)
                            {
                                throw new ArgumentException("Could not parse hex number \"{0}\".", x, e);
                            }
                        }
                        else if (x.Length > 0 && char.IsDigit(x[0]))
                        {
                            if (!long.TryParse(x, out var l))
                            {
                                throw new ArgumentException("Could not parse number \"{0}\".", x);
                            }

                            result = Enum.ToObject(propType, l);
                        }
                        else
                        {
                            try
                            {
                                result = Enum.Parse(propType, x, true);
                            }
                            catch (Exception e)
                            {
                                throw new ArgumentException("Could not parse string \"{0}\".", x, e);
                            }
                        }

                        return result;
                    };
                }
                else if (propType == typeof(FileInfo))
                {
                    getValue = () =>
                    {
                        var f = new FileInfo(Arguments[i]);

                        return arg.Item1.IsInputFile && !f.Exists ? throw new ArgumentException(string.Format("Could not find file {0}.", f.FullName)) : f;
                    };
                }
                else
                {
                    ThrowArgumentException("Invalid property type {0}.", propType);
                }

                argDictionary[name].Item2.SetValue(target, getValue(), null);
            }

            var missingRequiredArgs = argDictionary
                .Select(x => x.Value.Item1)
                .Where(x => x.IsRequired && !argsSet.Contains(x))
                .Select(x => x.Names[0])
                .Distinct();

            if (missingRequiredArgs.Any())
            {
                throw new ArgumentException(string.Format(
                    "Required argument(s) missing: {0}",
                    string.Join(", ", missingRequiredArgs)));
            }
        }

        public TArgs Read<TArgs>()
            where TArgs : new()
        {
            var args = new TArgs();
            SetProperties(args);

            return args;
        }

        public static CliArgAttribute[] GetAllAttributes<TArgs>()
            where TArgs : new() => typeof(TArgs)
                .GetProperties()
                .Select(x => x.GetCustomAttribute<CliArgAttribute>())
                .ToArray();
    }
}
