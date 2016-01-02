using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components.Aphid.Interpreter
{
    public class AphidLoader
    {
        private AphidInterpreter _interpreter;

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
        {
            _interpreter = interpreter;
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
            var methods = libraryType
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
                .SelectMany(x => x.Attributes.Select(y => Tuple.Create(y, x.Method)));

            foreach (var method in methods)
            {
                SetMember(scope, method.Item1.Name, new AphidInteropFunction(method.Item1, method.Item2));
            }
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
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
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

        public void LoadScript(string scriptFile, bool isTextDocument = false)
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

                _interpreter.Interpret(File.ReadAllText(f), isTextDocument);
            }
            else
            {
                throw new AphidRuntimeException("Cannot find script {0}", scriptFile);
            }
        }

        public void SetMember(AphidObject scope, string path, object value)
        {
            var members = path.Split('.');

            var currentObj = scope;

            foreach (var m in members)
            {
                if (!currentObj.ContainsKey(m))
                {
                    currentObj.Add(m, new AphidObject());
                }

                currentObj = currentObj[m];
            }

            currentObj.Value = value;
        }
    }
}

