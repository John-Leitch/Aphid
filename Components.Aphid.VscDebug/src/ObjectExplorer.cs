using Components;
using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static System.String;
using static Components.Aphid.TypeSystem.AphidObject;
using static Components.Aphid.TypeSystem.ValueHelper;
using static Components.Aphid.UI.AphidCli;
using static System.Reflection.BindingFlags;
using Kvp = System.Collections.Generic.KeyValuePair<string, Components.Aphid.TypeSystem.AphidObject>;

namespace VSCodeDebug
{
    public class ObjectExplorer
    {
        private Handles<Kvp[]> _variableHandles = new Handles<Kvp[]>();

        private static string GetObjectPreview(AphidObject obj) => Format(
            "{{{0}}}",
            obj.Select(x => Format("{0} {1}", GetAphidObjectTypeName(x.Value), x.Key)).Join(", "));

        private static string GetCollectionPreview(IEnumerable collection)
        {
            var c = collection.Cast<object>().Count();
            return Format("[ {0:n0} element{1} ]", c, c != 1 ? "s" : "");
        }

        public Variable CreateVariable(Kvp v)
        {
            try
            {
                return CreateVariableCore(v);
            }
            catch (Exception e)
            {
                
                return CreateVariableCore(new Kvp("$dbgInternalException", Wrap(e)));
            }
        }

        private Variable CreateVariableCore(Kvp v)
        {
            if (v.Value == null || (v.Value.IsScalar && v.Value.Value == null))
            {
                return new Variable(v.Key, "null", AphidType.Null);
            }
            else if (v.Value.Value == null)
            {
                return new Variable(
                    v.Key,
                    GetObjectPreview(v.Value),
                    AphidType.Object,
                    _variableHandles.Create(v.Value.ToArray()));
            }
            else
            {
                if (v.Value.Value.GetType() == typeof(List<AphidObject>))
                {
                    return new Variable(
                        v.Key,
                        GetCollectionPreview((List<AphidObject>)v.Value.Value),
                        AphidType.List,
                        _variableHandles.Create(
                            ((List<AphidObject>)v.Value.Value)
                            .Select((x, i) => new Kvp(i.ToString(), x))
                            .ToArray()));
                }
                //else if (v.Value.IsAphidType())
                //{
                //    return new Variable(
                //        v.Key,
                //        new AphidSerializer(Interpreter).Serialize(v.Value),
                //        v.Value.GetValueType(),
                //        0);
                //}
                else if (v.Value.Value.GetType() != typeof(string) &&
                    v.Value.Value.GetType() != typeof(AphidObject) &&
                    v.Value.Value.GetType().GetInterface("IEnumerable") != null)
                {
                    var l = new List<AphidObject>();

                    foreach (var o in (IEnumerable)v.Value.Value)
                    {
                        l.Add(Wrap(o));
                    }

                    return new Variable(
                        v.Key,
                        GetCollectionPreview(l),
                        "list",
                        _variableHandles.Create(l
                            .Select((x, i) => new Kvp(
                                i.ToString(),
                                x))
                            .ToArray()));
                }
                else if (v.Value.Value.GetType() == typeof(AphidObject))
                {
                    return new Variable(
                        v.Key,
                        GetObjectPreview((AphidObject)v.Value.Value),
                        AphidType.Object,
                        _variableHandles.Create(((AphidObject)v.Value.Value).ToArray()));
                }
                else
                {
                    var t = v.Value.Value.GetType();

                    //Program.Log("Reflecting type {0}", t.FullName);

                    if (t.IsPrimitive || t.IsEnum)
                    {
                        return new Variable(v.Key, v.Value.Value.ToString(), t.FullName);
                    }

                    return new Variable(
                        v.Key,
                        v.Value.Value.ToString(),
                        t.FullName,
                        _variableHandles.Create(t
                            .GetProperties(Public | Instance | Static | FlattenHierarchy)
                            .Where(x => x.GetIndexParameters().Length == 0)
                            .Select((x, i) => new Kvp(
                                x.Name,
                                Wrap(TryGetValue(x, v.Value.Value))))
                            .Concat(
                                t
                                .GetFields(Public | Instance | Static | FlattenHierarchy)
                                .Select((y, j) => new Kvp(
                                    y.Name,
                                    Wrap(TryGetValue(y, v.Value.Value)))))
                            .ToArray()));
                }
            }
        }

        private object TryGetValue(FieldInfo field, object target)
        {
            try
            {
                return field.GetValue(target);
            }
            catch (Exception e)
            {
                Program.Log(e.ToString());
                return $"Error evaluating field: {e.ToString()}";
            }
        }

        private object TryGetValue(PropertyInfo property, object target)
        {
            try
            {
                return property.GetValue(target);
            }
            catch (Exception e)
            {
                Program.Log($"Property error: {e.InnerException}");
                return $"Error evaluating property: {e.ToString()}";
            }
        }

        public List<Scope> Scopes(
            AphidInterpreter interpreter,
            StackFrame frame,
            AphidObject scope,
            Exception exception)
        {
            var scopes = new List<Scope>();
            var kvps = scope.ToArray();

            var localsHandle = _variableHandles.Create(kvps
                .Where(x =>
                    !x.Key.StartsWith("$") ||
                    x.Key == "$args" ||
                    x.Key == "$block" ||
                    x.Key == "$_")
                .ToArray());

            var specialsHandle = _variableHandles.Create(kvps
                .Where(x => x.Key.StartsWith("$"))
                .ToArray());

            scopes.Add(new Scope("Locals", localsHandle));
            scopes.Add(new Scope("Special Variables", specialsHandle));

            if (exception != null)
            {
                var exScope = Complex();
                exScope.Add("object", Scalar(exception));
                exScope.Add("message", Scalar(exception.Message));
                exScope.Add("clrStack", Scalar(exception.StackTrace));
                exScope.Add("inner", Scalar(exception.InnerException));
                exScope.Add("hresult", Scalar(exception.HResult));

                var exHandle = _variableHandles.Create(exScope.ToArray());
                scopes.Add(new Scope("Exception", exHandle));
            }

#if EXPRESSION_HISTORY
            var expRecords = interpreter.ExpressionHistory.Take(interpreter.ExpressionHistoryIndex);

            if (interpreter.ExpressionHistoryCount >= AphidInterpreter.ExpressionHistorySize)
            {
                expRecords = interpreter.ExpressionHistory
                    .Skip(interpreter.ExpressionHistoryIndex)
                    .Concat(expRecords);
            }

            var historyScope = Complex();
            var i = 0;
            foreach (var rec in expRecords.Take(interpreter.ExpressionHistoryCount))
            {
                //var expRecordObj = Complex();
                //expRecordObj.Add("statement", Scalar(rec.Statement));
                //expRecordObj.Add("frames", Scalar(rec.Frames));
                //expRecordObj.Add("block", Scalar(rec.Block));
                //expRecordObj.Add("blockIndex", Scalar(rec.BlockIndex));
                historyScope.Add($"[#{i++:x4},Depth={rec.Frames.Length:x2},Index={rec.BlockIndex:x2}]", Scalar(rec));
            }

            scopes.Add(new Scope(
                "Statement Tracing",
                _variableHandles.Create(historyScope.ToArray())));
#endif

            return scopes;
        }

        public List<Variable> Variables(int reference)
        {
            var variables = new List<Variable>();

            if (_variableHandles.TryGet(reference, out var children))
            {
                Program.Log("[variables] Got {0} children for {1}", children.Length, reference);
                foreach (var c in children)
                {
                    //Program.Log(
                    //    "[variables] Got child for {0}: {1}",
                    //    reference,
                    //    c.Value != null ? c.Value.GetType().FullName : c.ToString());

                    if (c.Value == null)
                    {
                        variables.Add(CreateVariable(c));
                    }
                    else if (c.Value.Value == null)
                    {
                        variables.Add(CreateVariable(c));
                        //c.Value.ToArray()
                        //foreach (var kvp in c.Value)
                        //{
                        //    variables.Add(CreateVariable(kvp));
                        //}
                    }
                    else if (false && c.Value.Value.GetType() == typeof(List<AphidObject>))
                    {
                        variables.Add(
                            CreateVariable(
                                new Kvp(
                                    c.Key,
                                    Scalar(c.Value.GetList()))));

                        //variables.Add(CreateVariable(c));
                        //foreach (var o in c.Value.GetList().Select(x => x.ToArray()))
                        //{
                        //}
                        //variables.Add(CreateVariable(c));

                        //foreach (var obj in c.Value.GetList())
                        //{
                        //new Kvp(c.Key, obj.Va

                        //foreach (var kvp in obj)
                        //{
                        //    variables.Add(CreateVariable(kvp));
                        //}
                        //}
                    }
                    else
                    {
                        variables.Add(CreateVariable(c));
                    }
                }

                //variables.AddRange(children
                //    .Where(x => x != null)
                //    .SelectMany(x => x
                //        .Where(y => y.Key != null)
                //        .Select(y => CreateVariable(y.Key, y.Value))));
                //.GroupBy(x => x.Key)
                //.Select(x => x.First().Key, x.First().Value)));
                //variables.AddRange(children
                //    .SelectMany(x => x.ToArray())
                //    .GroupBy(x => x.Key)
                //    .Select(x => CreateVariable(x.First().Key, x.First().Value)));
            }
            else if (false)
            {
                //if (children?.Length > 0)
                //{
                //    var more = false;
                //    if (children.Length > _maxChildren)
                //    {
                //        children = children.Take(_maxChildren).ToArray();
                //        more = true;
                //    }

                //    if (children.Length < 20)
                //    {
                //        // Wait for all values at once.
                //        //WaitHandle.WaitAll(children.Select(x => x.WaitHandle).ToArray());
                //        foreach (var v in children)
                //        {
                //            //variables.Add(CreateVariable(v));
                //        }
                //    }
                //    else
                //    {
                //        foreach (var v in children)
                //        {
                //            //v.WaitHandle.WaitOne();
                //            //variables.Add(CreateVariable(v));
                //        }
                //    }

                //    if (more)
                //    {
                //        variables.Add(new Variable("...", null, null));
                //    }
                //}
            }
            else
            {
                Program.Log("No variable handle created");
            }

            return variables;
        }

        public void Reset() => _variableHandles.Reset();
    }
}
