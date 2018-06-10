using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
using Components.External;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components.Aphid.Interpreter
{
    public class AphidLoader : AphidRuntimeComponent
    {
        private static Memoizer<Type, Tuple<string, AphidInteropFunction>[]> _libraryMemoizer =
            new Memoizer<Type, Tuple<string, AphidInteropFunction>[]>();

        private List<string> _searchPaths = new List<string> 
        { 
            Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "Library")
        };

        private List<Assembly> _modules;

        public List<string> SearchPaths
        {
            get { return _searchPaths; }
        }

        public AphidLoader(AphidInterpreter interpreter)
            : base(interpreter)
        {
            _modules = new List<Assembly> { Assembly.GetExecutingAssembly() };
        }

        public void LoadModule(string moduleFile)
        {
            var asm = Assembly.LoadFile(moduleFile);

            if (!_modules.Contains(asm))
            {
                _modules.Add(asm);
            }
        }

        public void LoadModule(Assembly module)
        {
            if (!_modules.Contains(module))
            {
                _modules.Add(module);
            }
        }

        public void LoadLibrary(Type libraryType, AphidObject scope)
        {
            var methods = _libraryMemoizer.Call(LoadLibrary, libraryType);

            foreach (var method in methods)
            {
                SetMember(scope, method.Item1, method.Item2);
            }
        }

        private Tuple<string, AphidInteropFunction>[] LoadLibrary(Type libraryType)
        {
            return libraryType
                .GetMethods(
                    BindingFlags.Static |
                    BindingFlags.NonPublic |
                    BindingFlags.Public)
                .Select(x => new
                {
                    Method = x,
                    Attributes = x
                        .GetCustomAttributes(true)
                        .Where(y => y is AphidInteropFunctionAttribute)
                        .Cast<AphidInteropFunctionAttribute>()
                        .ToArray()
                })
                .SelectMany(x => x.Attributes
                    .Select(y => Tuple.Create(y.Name, new AphidInteropFunction(y, x.Method))))
                .ToArray();
        }

        public void LoadLibrary(string libraryType, AphidObject scope)
        {
            foreach (var module in _modules)
            {
                var t = module.GetType(libraryType);

                if (t != null)
                {
                    LoadLibrary(t, scope);

                    return;
                }
            }

            throw new InvalidOperationException();
        }

        public void LoadLibrary<TLibrary>(AphidObject scope)
        {
            LoadLibrary(typeof(TLibrary), scope);
        }

        public string FindScriptFile(string scriptFile)
        {
            return FindScriptFile(
                Path.GetDirectoryName(typeof(AphidLoader).Assembly.Location),
                scriptFile);
        }

        public string FindScriptFile(string appDir, string scriptFile)
        {
            Func<string, string>[] extensionStrategies = new Func<string, string>[]
            {
                x => x + ".alx",
                x => x,                
            };

            var files = extensionStrategies.Select(x => x(scriptFile));

            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    return file;
                }
            }

            var searchPathSets = new List<List<string>> { _searchPaths };

            if (appDir != null)
            {
                searchPathSets.Add(new List<string> { appDir });
            }

            foreach (var paths in searchPathSets)
            {
                foreach (var file in files)
                {
                    foreach (var p in paths)
                    {
                        var f = Path.Combine(p, file);
                        
                        if (File.Exists(f))
                        {
                            return f;
                        }
                    }
                }
            }

            return null;
        }

        public List<AphidExpression> LoadScript(string scriptFile, bool isTextDocument = false)
        {
            var f = FindScriptFile(null, scriptFile);

            if (f != null)
            {
                if (f.Contains(Path.DirectorySeparatorChar))
                {
                    var dir = Path.GetFullPath(Path.GetDirectoryName(f));
                    
                    if (!_searchPaths.Contains(dir))
                    {
                        _searchPaths.Add(dir);
                    }
                }

                List<AphidExpression> ast;

                try
                {
                    if (AphidConfig.Current.ScriptCaching)
                    {
                        var cache = new AphidByteCodeCache(_searchPaths.ToArray());

                        ast = cache.Read(f);
                    }
                    else
                    {
                        ast =
                            new AphidPreprocessorDirectiveMutator().MutateRecursively(
                                new AphidMacroMutator().MutateRecursively(
                                    new PartialOperatorMutator().MutateRecursively(
                                        AphidParser.Parse(File.ReadAllText(f), f, isTextDocument))));
                    }
                }
                catch (AphidParserException e)
                {
                    throw new AphidLoadScriptException(
                        Interpreter,
                        Interpreter.CurrentScope,
                        Interpreter.CurrentStatement,
                        Interpreter.CurrentExpression,
                        f,
                        e);
                }
                catch (AphidRuntimeException e)
                {
                    throw new AphidLoadScriptException(
                        Interpreter,
                        Interpreter.CurrentScope,
                        Interpreter.CurrentStatement,
                        Interpreter.CurrentExpression,
                        f,
                        e);
                }
                catch (Exception e)
                {
                    throw new AphidLoadScriptException(
                        Interpreter,
                        Interpreter.CurrentScope,
                        Interpreter.CurrentStatement,
                        Interpreter.CurrentExpression,
                        f,
                        e);
                }

                Interpreter.Interpret(ast);
                
                return ast;
            }
            else
            {
                throw Interpreter.CreateRuntimeException("Cannot find script {0}.", scriptFile);
            }
        }

        public void SetMember(AphidObject scope, string path, object value)
        {
            var members = path.Split('.');

            var currentObj = scope;

            for (var i = 0; i < members.Length; i++)
            {
                var m = members[i];

                if (i != members.Length - 1)
                {
                    if (!currentObj.ContainsKey(m))
                    {
                        var o = AphidObject.Complex();
                        currentObj.Add(m, o);
                        currentObj = o;
                    }
                    else
                    {
                        currentObj = currentObj[m];
                    }
                }
                else
                {
                    var o = Interpreter.ValueHelper.IsComplexAphidObject(value) ?
                        (AphidObject)value :
                        AphidObject.Scalar(Interpreter.ValueHelper.Unwrap(value));

                    if (!currentObj.ContainsKey(m))
                    {
                        currentObj.Add(m, o);
                    }
                    else
                    {
                        currentObj[m] = o;
                    }
                }
            }

            //foreach (var m in members)
            //{
            //    if (!currentObj.ContainsKey(m))
            //    {
            //        currentObj.Add(m, AphidObject.Complex());
            //    }

            //    currentObj = currentObj[m];
            //}

            //currentObj.Value = value;
        }
    }
}

