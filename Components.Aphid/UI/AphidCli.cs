using Components.External.ConsolePlus;
using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Parser;
using System.IO;
using Components.Aphid.Lexer;
using System.Diagnostics;
using Components.Aphid.TypeSystem;
using Components.Aphid.Serialization;
using Components.Aphid.Debugging;
using Components.External;
using Components.Json;
using System.Reflection;
using System.Threading;
using static Components.External.ConsolePlus.Cli;
using AphidPair = System.Collections.Generic.KeyValuePair<string, Components.Aphid.TypeSystem.AphidObject>;
using static Components.Aphid.UI.Formatters.SyntaxHighlightingFormatter;
using Components.Aphid.UI.Formatters;

namespace Components.Aphid.UI
{
    public static partial class AphidCli
    {
        private const string _messageFormat = "[~{0}~{1}~R~] {2}";

        private const char _errorChar = '-';

        private static readonly object _redirectSync = new object();

        private static readonly AphidSyntaxHighlighter _highlighter = new AphidSyntaxHighlighter();

        public static Action<string> WriteOut { get; set; } = Write;

        public static Action<string> WriteLineOut { get; set; } = WriteLine;

        public static Exception LastException { get; set; }

        public static bool IsAborting { get; set; }

        public static bool TryAction(
            AphidInterpreter interpreter,
            string code,
            Action action) =>
            TryAction(interpreter, code, action, allowErrorReporting: false);

        public static bool TryAction(
            AphidInterpreter interpreter,
            string code,
            Action action,
            bool allowErrorReporting) =>
            TryAction(interpreter, () => code, action, allowErrorReporting);

        public static bool TryAction(
            AphidInterpreter interpreter,
            Func<string> getCode,
            Action action,
            bool allowErrorReporting)
        {
            var backup = false;

            try
            {
                backup = interpreter.SetIsInTryCatchFinally(true);
                action();
                interpreter.SetIsInTryCatchFinally(backup);

                return true;
            }
            catch (ThreadAbortException exception)
            {
                if (!IsAborting)
                {
                    Thread.ResetAbort();
                    LastException = exception;
                    DumpException(exception, interpreter);
                }
            }
            catch (AphidParserException exception)
            {
                LastException = exception;
                DumpException(exception, getCode());
            }
            catch (AphidLoadScriptException exception)
            {
                LastException = exception;
                DumpException(exception, interpreter);
            }
            catch (AphidRuntimeException exception)
            {
                LastException = exception;
                DumpException(exception, interpreter);
            }
            catch (TargetInvocationException exception)
                when (exception.InnerException is AphidParserException parserException)
            {
                LastException = parserException;
                DumpException(parserException, getCode());
            }
            catch (TargetInvocationException exception)
                when (exception.InnerException is AphidLoadScriptException loadScriptException)
            {
                LastException = loadScriptException;
                DumpException(loadScriptException, interpreter);
            }
            catch (TargetInvocationException exception)
                when (exception.InnerException is AphidRuntimeException runtimeException)
            {
                LastException = runtimeException;
                DumpException(runtimeException, interpreter);
            }
            catch (Exception exception)
            {
                LastException = exception;
                DumpException(exception, interpreter);
            }

            if (allowErrorReporting)
            {
                AphidErrorReporter.Report(LastException, interpreter, passThrough: false);
            }

            interpreter.SetIsInTryCatchFinally(backup);

            return false;
        }

        public static void DumpValue(
            AphidInterpreter interpreter,
            object value,
            bool ignoreNull = true,
            bool ignoreClrObj = true) =>
            WriteLineHighlighted(
                SerializingFormatter.Format(
                    interpreter,
                    value,
                    ignoreNull,
                    ignoreClrObj));

        public static string Redirect(Action action) => RedirectCore(false, action);

        public static string Capture(Action action) => RedirectCore(true, action);

        private static string RedirectCore(bool forwardOut, Action action)
        {
            lock (_redirectSync)
            {
                var sb = new StringBuilder();
                var writeOut = WriteOut;
                var writeLineOut = WriteLineOut;

                try
                {
                    if (forwardOut)
                    {
                        WriteOut = x =>
                        {
                            sb.Append(EraseStyles(x));
                            writeOut(x);
                        };

                        WriteLineOut = x =>
                        {
                            sb.AppendLine(EraseStyles(x));
                            writeLineOut(x);
                        };
                    }
                    else
                    {
                        WriteOut = x => sb.Append(EraseStyles(x));
                        WriteLineOut = x => sb.AppendLine(EraseStyles(x));
                    }

                    action();
                }
                finally
                {
                    WriteOut = writeOut;
                    WriteLineOut = writeLineOut;
                }

                return sb.ToString();
            }
        }

        public static void DumpException(AphidParserException exception, string code) =>
            WriteErrorMessage(StyleEscape(ErrorFormatter.Format(exception, code)));

        public static void DumpException(AphidRuntimeException exception, AphidInterpreter interpreter)
        {
            WriteErrorMessage(StyleEscape(ErrorFormatter.Format(exception)));

            DumpStackTrace(interpreter);

            DumpScope(
                    exception.ExceptionScope,
                    interpreter ?? new AphidInterpreter());
        }

        public static void DumpException(AphidLoadScriptException exception, AphidInterpreter interpreter)
        {
            WriteErrorMessage(
                StyleEscape(
                    ErrorFormatter.Format(
                        exception,
                        AphidScript.Read(exception.ScriptFile))));

            DumpStackTrace(interpreter);

            if (exception.LoadScriptExceptionType != AphidExceptionType.AphidRuntimeException)
            {
                if (interpreter != null)
                {
                    DumpScope(interpreter);
                }
            }
            else
            {
                DumpScope(
                    exception.AphidRuntimeException.ExceptionScope,
                    interpreter ?? new AphidInterpreter());
            }
        }

        public static void DumpException(Exception exception, AphidInterpreter interpreter)
        {
            WriteErrorMessage(StyleEscape(ErrorFormatter.Format(exception)));

            if (interpreter != null)
            {
                DumpStackTrace(interpreter);
                DumpScope(interpreter);
            }
        }

        public static void DumpScope(AphidInterpreter interpreter) =>
            DumpScope(
                interpreter.GetRawStackTrace().FirstOrDefault().Scope ?? interpreter.CurrentScope,
                interpreter);

        public static void DumpScope(AphidObject scope, AphidInterpreter interpreter) =>
            DumpScope(scope, interpreter, 0);

        public static void DumpScope(AphidObject scope, AphidInterpreter interpreter, int depth)
        {
            if (!AphidConfig.Current.ShowErrorScope)
            {
                return;
            }

            if (depth == 0)
            {
                if (!Console.IsOutputRedirected)
                {
                    WriteSubheader("Exception Scope", "~|Blue~~White~");
                }
                else
                {
                    WriteErrorMessage("Exception Scope");
                }
            }

            var locals = Formatters.MemberFilter.Apply(scope);

            var localsFormatted = LocalFormatter.Format(
                interpreter,
                locals,
                AphidObject.GetScopeAncestors(scope));

            var cfg = AphidConfig.Current;

            if (cfg.StackTraceParamsMax >= 0)
            {
                var h = cfg.StackTraceParamsMax / 2f;
                int first = (int)Math.Ceiling(h), last = (int)Math.Floor(h);
                var count = locals.Length;
                var skip = Math.Max(0, count - first - last);

                if (skip != 0)
                {
                    localsFormatted = localsFormatted
                        .Where((_, i) => i < first)
                        .Append(new Lazy<string>(() =>
                            string.Format("/* Skipped {0:n0} locals */", skip)))
                        .Concat(localsFormatted.Where((_, i) => i >= skip + first));
                }
            }

            var localsStr = localsFormatted.Select(x => x.Value).JoinLines();

            if (localsStr.Length > 0)
            {
                WriteLineOut(localsStr);
            }
            else
            {
                WriteLineHighlighted("[--] None");
            }

            WriteLineOut("");

            if ((scope.TryGetValue(AphidName.Parent, out var parent) && parent != null) ||
                (parent = scope.Parent) != null)
            {
                var scopeHeader = string.Format("[Parent Scope 0x{0:x4}]", ++depth);
                WriteLineHighlighted(scopeHeader);
                DumpScope(parent, interpreter, depth);
            }
        }

        public static void DumpStackTrace(AphidInterpreter interpreter)
        {
            var cfg = AphidConfig.Current;
            var trace = interpreter.GetRawStackTrace();
            var frameNum = 0;

            if (!Console.IsOutputRedirected)
            {
                WriteSubheader("Stack Trace", "~|Blue~~White~");
            }
            else
            {
                WriteErrorMessage("Stack Trace");
            }

            foreach (var frame in trace)
            {
                var frameStr = FrameFormatter.FormatFrame(frameNum++, in frame);
                WriteLineOut(frameStr);

                if (cfg.StackTraceParams)
                {
                    var args = frame.Arguments
                        .Select((x, y) => string.Format(
                            "{0} $args[{1}] = {2}",
                            GetAphidObjectTypeName(x),
                            y,
                            SerializingFormatter.Format(
                                interpreter,
                                x,
                                ignoreNull: false,
                                ignoreClrObj: false)));

                    if (cfg.StackTraceParamsMax >= 0)
                    {
                        var h = cfg.StackTraceParamsMax / 2f;
                        int first = (int)Math.Ceiling(h), last = (int)Math.Floor(h);
                        var count = frame.Arguments.Count();
                        var skip = Math.Max(0, count - first - last);

                        if (skip != 0)
                        {
                            args = args
                                .Where((_, i) => i < first || i >= skip + first)
                                .Append(string.Format("/* Skipped {0:n0} args /*", skip))
                                .Skip(skip);
                        }
                    }

                    var argStr = args.JoinLines();

                    if (argStr.Length > 0)
                    {
                        WriteLineOut(Format(argStr.Indent("  ")));
                    }

                    //var locals = frame.Scope
                    //    .Select(x => string.Format(
                    //        "{0} {1} = {2}",
                    //        x.Key,
                    //        GetAphidObjectTypeName(x.Value),
                    //        DumpValue(interpreter, serializer, x.Value)))
                    //    .JoinLines();

                    //if (locals.Length > 0)
                    //{
                    //    WriteLineOut(Highlight(StyleEscape(locals.Indent("  "))));
                    //}
                }
            }

            WriteLineOut("");

            if (cfg.ShowErrorExpression || cfg.ShowErrorStatement)
            {
                ShowErrorNodes(interpreter, cfg, trace);
            }

            if (cfg.ShowErrorFrameExcerpts)
            {
                var dumpCount = 0;

                foreach (var t in trace)
                {
                    if (DumpFirstExcerpt(
                        t.Expression,
                        string.Format(
                            "Frame {0:x4} Excerpt",
                            Array.IndexOf(trace, t))) &&
                        ++dumpCount == cfg.FrameExcerptsMax)
                    {
                        break;
                    }
                }
            }

            //if(dumpCount == 0)
            //{
            //    foreach(var pair in ctxPairs)
            //    {
            //        DumpFirstExcerpt(
            //            pair.Item2,
            //            string.Format("Current {0} Excerpt", pair.Item1));
            //    }

            //}

            var headerPrinted = false;
            var statement = interpreter.CurrentStatement;
            var exp = interpreter.CurrentExpression;
            var file = interpreter.GetScriptFilename();
            var stmtFile = statement?.Filename;
            var expFile = exp?.Filename;

            if (cfg.ShowErrorFileList)
            {
                foreach (var s in new (string, string, Func<List<AphidExpression>>)[]
                {
                    (
                        "Expression",
                        expFile,
                        () => new List<AphidExpression>(new[] { interpreter.CurrentExpression })),

                    (
                        "Statement",
                        stmtFile,
                        () => new List<AphidExpression>(new[] { interpreter.CurrentStatement })),

                    (
                        "Interpreter",
                        file,
                        () => interpreter.CurrentScope.TryResolve(AphidName.Block, out var val) ?
                            (List<AphidExpression>)val.Value :
                            new List<AphidExpression>())
                })
                {
                    var files = new[] { s.Item2 }
                        .Concat(AphidParent.Flatten(s.Item3().ToArray()).Select(x => x?.Filename))
                        .Where(x => x != null)
                        .Select(x => x.Replace('/', '\\'))
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToArray();

                    if (files.Length == 0)
                    {
                        break;
                    }

                    if (!headerPrinted)
                    {
                        SafeWriteSubheader("Scripts");
                        headerPrinted = true;
                    }

                    WriteLineOut(string.Format("[~White~{0} Level Scripts~R~]", s.Item1));

                    foreach (var resp in files)
                    {
                        WriteLineOut(resp);
                    }

                    WriteLineOut("");
                }
            }
        }

        public static void SafeWriteSubheader(string text)
        {
            if (!Console.IsOutputRedirected)
            {
                WriteSubheader(text, "~|Blue~~White~");
            }
            else
            {
                WriteLineOut(string.Format("[{0}]", text));
            }
        }

        public static void WriteSubheader(string text, string style = "") =>
            WriteLineOut(
                string.Format(
                    "{0}  {1}{2}{3}",
                    style,
                    Escape(text),
                    new string(' ', BufferWidth - text.Length - 3),
                    "~R~"));

        public static void WriteErrorMessage(string format, params object[] arg)
        {
            if (!Console.IsOutputRedirected && Console.CursorLeft != 0)
            {
                WriteLineOut("\r\n");
            }

            WriteMessage(
                ConsoleColor.Red,
                _errorChar,
                format,
                arg);
        }

        public static void WriteMessage(ConsoleColor tokenColor, char token, string format, params object[] arg) =>
            WriteLineOut(
                string.Format(
                    string.Format(_messageFormat, tokenColor, token, format.Replace("{", "{{").Replace("}", "}}")),
                    arg));

        public static void WriteLineHighlighted(string text) =>
            WriteLineOut(Format(text));

        public static void WriteLineHighlighted(string text, bool escapeStyles) =>
            WriteLineOut(Format(text, escapeStyles));

        private static bool DumpFirstExcerpt(AphidExpression statement, string name) =>
            DumpExcerpt(statement, name)
                || DumpExcerpt(AphidParent.FirstComplete(statement), name)
                || DumpExcerpt(AphidParent.FirstNearComplete(statement), name);

        private static bool DumpExcerpt(AphidExpression statement, string name)
        {
            var excerpt = ExcerptFormatter.Format(statement, name);

            if (excerpt != null)
            {
                SafeWriteSubheader(name ?? "Program Excerpt");
                WriteLineOut(excerpt);

                return true;
            }

            return false;
        }

        private static void ShowErrorNodes(AphidInterpreter interpreter, AphidConfig cfg, AphidFrame[] trace)
        {
            SafeWriteSubheader("Execution Context");

            var ctxPairs = new List<(string, AphidExpression)>();

            if (cfg.ShowErrorExpression)
            {
                ctxPairs.Add(("Expression", interpreter.CurrentExpression));
            }

            if (cfg.ShowErrorStatement)
            {
                ctxPairs.Add(("Statement", interpreter.CurrentStatement));
            }

            foreach (var kvp in ctxPairs)
            {
                WriteLineOut(string.Format("[~White~Last {0}~R~]", kvp.Item1));

                if (kvp.Item2 == null)
                {
                    WriteLineOut(Format("null", escapeStyles: false));
                    WriteLineOut("");
                    continue;
                }

                try
                {
                    WriteLineOut(
                        Format(
                            kvp.Item2.Code != null ?
                                kvp.Item2.Code.Substring(
                                    kvp.Item2.Index,
                                    kvp.Item2.Length) :
                                kvp.Item2.ToString()));
                }
                catch (Exception e)
                {
                    WriteErrorMessage(
                        string.Format(
                            "Error writing context for ~Yellow~{0}~R~\r\n{1}",
                            kvp.Item2,
                            e.Message));
                }

                WriteLineOut("");
            }

            foreach (var pair in ctxPairs.Where(x => x.Item2 != null))
            {
                if (trace.Any(a =>
                    a.Expression != null &&
                    a.Expression.Filename == pair.Item2.Filename &&
                    pair.Item2.Index <= a.Expression.Index &&
                    pair.Item2.Index + pair.Item2.Length >=
                        a.Expression.Index + a.Expression.Length) ||
                    DumpFirstExcerpt(
                        pair.Item2,
                        string.Format("Current {0} Excerpt", pair.Item1)))
                {
                    break;
                }
            }
        }
    }
}
