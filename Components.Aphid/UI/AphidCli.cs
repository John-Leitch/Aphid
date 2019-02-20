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

namespace Components.Aphid.UI
{
    public static partial class AphidCli
    {
        private const string _messageFormat = "[~{0}~{1}~R~] {2}";

        private const string startMarker = " /*HL_S*/ ", endMarker = " /*HL_E*/ ";

        private const char _errorChar = '-';

        private static AphidSyntaxHighlighter _highlighter = new AphidSyntaxHighlighter();

        public static bool ShowClrStack { get; set; }

        public static Action<string> WriteOut { get; set; } = Write;

        public static Action<string> WriteLineOut { get; set; } = WriteLine;

        public static Exception LastException { get; set; }

        public static bool IsAborting { get; set; }

        public static AphidSerializer CreateSerializer(AphidInterpreter interpreter) =>
            new AphidSerializer(interpreter)
            {
                IgnoreFunctions = true,
                IgnoreLazyLists = false,
                IgnoreSpecialVariables = true,
                QuoteToStringResults = false,
                ToStringClrTypes = false,
                MaxElements = AphidConfig.Current.StackTraceParamsMax,
            };

        public static bool TryAction(
            AphidInterpreter interpreter,
            string code,
            Action action) => TryAction(interpreter, code, action, allowErrorReporting: false);

        public static bool TryAction(
            AphidInterpreter interpreter,
            string code,
            Action action,
            bool allowErrorReporting) => TryAction(interpreter, () => code, action, allowErrorReporting);

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
                AphidErrorReporter.Report(LastException, interpreter);
            }

            interpreter.SetIsInTryCatchFinally(backup);

            return false;
        }

        public static void ExecuteCode(string code) =>
            ExecuteCode(code, isTextDocument: false);

        public static void ExecuteCode(AphidInterpreter interpreter, string code) =>
            ExecuteCode(interpreter, code, isTextDocument: false);

        public static void ExecuteCode(string code, bool isTextDocument) =>
            ExecuteCode(new AphidInterpreter(), code, isTextDocument);

        public static AphidObject DumpExpression(string code) =>
            DumpExpression(new AphidInterpreter(), code);

        public static AphidObject DumpExpression(AphidInterpreter interpreter, string code)
        {
            AphidObject result = null;

            void action()
            {
                if (code.Trim()?.Length == 0)
                {
                    return;
                }

                var lexer = new AphidLexer(code);
                var tokens = lexer.GetTokens();
                var exp = AphidParser.ParseExpression(tokens, code);
                var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp);
                //new AphidCodeVisitor(code).VisitExpression(retExp);
                interpreter.Interpret(retExp);
                result = interpreter.GetReturnValue();

                if (result != null && (result.Value != null || result.Any()))
                {
                    DumpValue(
                        interpreter,
                        CreateSerializer(interpreter),
                        result,
                        ignoreNull: false,
                        ignoreClrObj: false);
                }
            }

            if (AphidErrorHandling.HandleErrors)
            {
                TryAction(interpreter, code, action);
            }
            else
            {
                action();
            }

            return result;
        }

        public static void ExecuteCode(
            AphidInterpreter interpreter,
            string code,
            bool isTextDocument)
        {
            if (AphidErrorHandling.HandleErrors)
            {
                var backup = false;

                try
                {
                    backup = interpreter.SetIsInTryCatchFinally(true);
                    interpreter.Interpret(code, isTextDocument);
                }
                catch (ThreadAbortException exception)
                {
                    if (!IsAborting)
                    {
                        Thread.ResetAbort();
                        DumpException(exception, interpreter);
                        Environment.Exit((int)AphidExitCode.GeneralError);
                    }
                }
                catch (AphidParserException exception)
                {
                    DumpException(exception, code);
                    Environment.Exit((int)AphidExitCode.ParserError);
                }
                catch (AphidLoadScriptException exception)
                {
                    DumpException(exception, interpreter);
                    Environment.Exit((int)AphidExitCode.LoadScriptError);
                }
                catch (AphidRuntimeException exception)
                {
                    DumpException(exception, interpreter);
                    Environment.Exit((int)AphidExitCode.RuntimeError);
                }
                catch (Exception exception)
                {
                    DumpException(exception, interpreter);
                    Environment.Exit((int)AphidExitCode.GeneralError);
                }
                finally
                {
                    interpreter.SetIsInTryCatchFinally(backup);
                }
            }
            else
            {
                interpreter.Interpret(code, isTextDocument);
            }
        }

        public static void DumpException(AphidParserException exception, string code) =>
            WriteErrorMessage(StyleEscape(GetErrorMessage(exception, code)));

        public static void DumpException(
            AphidRuntimeException exception,
            AphidInterpreter interpreter)
        {
            WriteErrorMessage(StyleEscape(GetErrorMessage(exception)));
            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            AphidLoadScriptException exception,
            AphidInterpreter interpreter)
        {
            WriteErrorMessage(
                StyleEscape(
                    GetErrorMessage(
                        exception,
                        AphidScript.Read(exception.ScriptFile))));

            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            Exception exception,
            AphidInterpreter interpreter)
        {
            WriteErrorMessage(StyleEscape(GetErrorMessage(exception)));

            if (interpreter != null)
            {
                DumpStackTrace(interpreter);
            }
        }

        public static void DumpStackTrace(AphidInterpreter interpreter)
        {
            var cfg = AphidConfig.Current;
            var trace = interpreter.GetRawStackTrace();
            var i = 0;

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
                string rawFrameStr = null;
                AphidExpression frameExp = null;

                if (frame.Expression != null && frame.Expression.Filename == null)
                {
                    var complete = AphidParent.FirstComplete(frame.Expression) ??
                        AphidParent.FirstNearComplete(frame.Expression);

                    if (complete != null)
                    {
                        frameExp = complete;
                        //rawFrameStr = complete.ToString();
                    }
                }
                else
                {
                    frameExp = frame.Expression;
                }

                if (rawFrameStr == null)
                {
                    rawFrameStr = frame.ToString(true, useFullNames: false);
                }

                var frameStr = StyleEscape(
                    !"\r\n".Any(rawFrameStr.Contains) ?
                        rawFrameStr :
                        rawFrameStr
                            .NormalizeLines()
                            .SplitLines()
                            .Select(x => x.Trim())
                            .Join(" "));

                var truncated = false;
                int maxWidth;

                try
                {
                    maxWidth = Console.WindowWidth - 12;
                }
                catch
                {
                    // Todo: Move constant into config.
                    maxWidth = 80;
                }

                if (frameStr.Length > maxWidth)
                {
                    frameStr = frameStr.Remove(maxWidth);
                    truncated = true;
                }

                frameStr = Highlight(frameStr.TrimEnd());

                if (truncated)
                {
                    frameStr += " ~White~...~R~";
                }

                var frameOut = string.Format(
                    "[~White~{0:x4}~R~] {1}",
                    i++,
                    frameStr);

                WriteOut(frameOut);

                var frameExpFile = frameExp?.Filename;

                if (frameExpFile != null)
                {
                    var basePath = PathHelper.GetEntryDirectory();

                    if (frameExpFile.StartsWith(
                        basePath,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        frameExpFile = frameExpFile.Substring(basePath.Length);
                    }

                    var pos = ParserErrorMessage
                        .AppendPosition(
                            new StringBuilder(),
                            frameExp.Code,
                            frameExp.Index,
                            false)
                        .ToString();

                    WriteOut(" ");
                    var colors = _highlighter
                        .Highlight(
                            string.Format(
                                "[in {1}{0}]",
                                pos.TrimEnd(),
                                frameExpFile))
                        .ToArray();

                    //Func<byte[], byte, byte[]> brighten = (x, amt) =>
                    //{
                    //    var copy = (byte[])x.Clone();

                    //    copy
                    //        .GroupBy(a => a)
                    //        .OrderByDescending(a => a)
                    //        .First();


                    //    if(x[0] == x[1] && x[0] == x[2])
                    //    {
                    //        return x.Select(a => (byte)(a + amt)).ToArray();
                    //    }
                    //    else if (x[0] == x[1])
                    //};

                    for (var x = 0; x < colors.Length; x++)
                    {
                        var old = colors[x].ForegroundRgb;

                        var top = old
                            .OrderByDescending(a => a)
                            .GroupToArrayDictionary(a => a)
                            .First();

                        byte increase(byte a) => Math.Max(a, (byte)(a * 1.4));
                        byte[] color;

                        if (top.Value.Length == 3)
                        {
                            color = old.Select(increase).ToArray();
                        }
                        else if (top.Value.Length == 2)
                        {
                            var off1 = Array.IndexOf(old, top.Value[0]);
                            var off2 = Array.IndexOf(old, top.Value[1], off1 + 1);

                            color = colors[x].ForegroundRgb.ToArray();
                            color[off1] = increase(color[off1]);
                            color[off2] = increase(color[off2]);
                        }
                        else
                        {
                            var off = Array.IndexOf(old, top.Value[0]);

                            color = colors[x].ForegroundRgb.ToArray();
                            color[off] = increase(color[off]);
                        }

                        colors[x] = new ColoredText(
                            color,
                            //colors[x].ForegroundRgb.Select((a => (byte)(a * 1.1)).ToArray(),
                            new byte[] { 0x00, 0x20, 0x20 },
                            colors[x].Text);
                    }

                    WriteLineOut(VT100.GetString(colors));

                    //WriteLineOut(string.Format(
                    //    " ~|DarkBlue~~White~[{1}{0}]~R~",
                    //    Highlight(pos),
                    //    frameExpFile));
                }
                else
                {
                    WriteLineOut("");
                }

                if (cfg.StackTraceParams)
                {
                    var serializer = CreateSerializer(interpreter);

                    var args = frame.Arguments
                        .Select((x, y) => string.Format(
                            "$args[{0}] = {1} {2}",
                            y,
                            GetAphidObjectTypeName(x),
                            DumpValue(interpreter, serializer, x)));

                    if (cfg.StackTraceParamsMax >= 0)
                    {
                        var h = cfg.StackTraceParamsMax / 2f;
                        int first = (int)Math.Ceiling(h), last = (int)Math.Floor(h);
                        var count = frame.Arguments.Count();
                        var skip = Math.Max(0, count - first - last);

                        if (skip != 0)
                        {
                            args = args
                                .Take(first)
                                .Append(string.Format("/* Skipped {0:n0} args /*", skip))
                                .Skip(skip);
                        }
                    }

                    var argStr = args.JoinLines();

                    if (argStr.Length > 0)
                    {
                        WriteLineOut(Highlight(StyleEscape(argStr.Indent("  "))));
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
                    WriteLineOut(Highlight("null"));
                    WriteLineOut("");
                    continue;
                }

                try
                {
                    WriteLineOut(
                        Highlight(
                            StyleEscape(
                                kvp.Item2.Code != null ?
                                    kvp.Item2.Code.Substring(
                                        kvp.Item2.Index,
                                        kvp.Item2.Length) :
                                    kvp.Item2.ToString())));
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

        public static string DumpValue(
            AphidInterpreter interpreter,
            AphidSerializer serializer,
            object value,
            bool ignoreNull = true,
            bool ignoreClrObj = true)
        {
            string result;

            try
            {
                result = serializer.Serialize(ValueHelper.Wrap(value));
            }
            catch (Exception e)
            {
                var ex = ExceptionHelper.Unwrap(e);

                return $"Error dumping {value.GetType()}: {ex.Message}";
            }

            //if(result.StartsWith("clrObject("))
            //{
            //    string json;

            //    try
            //    {
            //        json = JsonSerializer.Serialize(interpreter.ValueHelper.Unwrap(value));
            //        result = json;
            //    }
            //    catch { }
            //}

            return
                (ignoreClrObj && result.StartsWith("clrObject(")) ||
                (ignoreNull && result == "null") ? "" :
                result;
        }

        private static bool DumpFirstExcerpt(AphidExpression statement, string name = null) =>
            DumpExcerpt(statement, name)
                || DumpExcerpt(AphidParent.FirstComplete(statement), name)
                || DumpExcerpt(AphidParent.FirstNearComplete(statement), name);

        private static bool DumpExcerpt(AphidExpression statement, string name = null)
        {
            if (statement == null ||
                string.IsNullOrEmpty(statement.Code) ||
                statement.Index < 0)
            {
                return false;
            }

            var codeCopy = statement.Code
                .Insert(statement.Index + statement.Length, endMarker)
                .Insert(statement.Index, startMarker);

            var excerpt = TokenHelper.GetCodeExcerpt(
                codeCopy,
                statement.Index + startMarker.Length,
                AphidConfig.Current.FrameExcerptLines / 2);

            excerpt = Highlight(StyleEscape(excerpt));

            if (!string.IsNullOrEmpty(excerpt.Trim()))
            {
                SafeWriteSubheader(name ?? "Program Excerpt");
                WriteLineOut(excerpt);

                return true;
            }

            return false;
        }

        public static string GetErrorMessage(
            AphidParserException exception,
            string code) => string.Format(
                "Unhandled parser exception: {0}",
                ParserErrorMessage.Create(code, exception, true));

        public static string GetErrorMessage(AphidRuntimeException exception) =>
            $"{exception.Message}\r\n";

        public static string GetErrorMessage(AphidLoadScriptException exception, string code)
        {
            var sb = new StringBuilder("Load script exception\r\n");
            var t = exception.LoadScriptExceptionType;

            sb.AppendLine(
                t == AphidExceptionType.ParserException ?
                    GetErrorMessage(exception.ParserException, code) :
                t == AphidExceptionType.AphidRuntimeException ?
                    GetErrorMessage(exception.AphidRuntimeException) :
                GetErrorMessage(exception.InnerException));

            return sb.ToString();
        }

        public static string GetErrorMessage(Exception exception)
        {
            var ex = ExceptionHelper.Unwrap(exception);

            return string.Format(
                ShowClrStack ?
                    "Unhandled exception: {0}\r\n\r\n{1}\r\n" :
                    "Unhandled exception: {0}\r\n",
                ex.Message,
                ex.StackTrace);
            // Todo: implement properly
            // +
            //(ex.InnerException != null ? 
            //    "Inner:\r\n\r\n" + GetErrorMessage(ex.InnerException) :
            //    "");
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

        public static ColoredText Invert(ColoredText x)
        {
            if (x.BackgroundRgb == null)
            {
                x.BackgroundRgb = x.ForegroundRgb;
                x.ForegroundRgb = SystemColor.Black;
            }
            else if (x.ForegroundRgb == null)
            {
                x.ForegroundRgb = x.BackgroundRgb;
                x.BackgroundRgb = SystemColor.White;
            }
            else
            {
                var bg = x.BackgroundRgb;
                x.BackgroundRgb = x.ForegroundRgb;
                x.ForegroundRgb = bg;
            }

            return x;
        }

        public static string Highlight(string code)
        {
            if (code.Trim().Length == 0)
            {
                return code;
            }

            //if(code.Contains("tryAction"))
            //{
            //    Debugger.Break();
            //}

            var ct = _highlighter.Highlight(code).ToArray();

            //var color = SystemColor.AntiqueWhite;

            int start = Array.FindIndex(ct, x => x.Text == startMarker.Trim()),
                end = -1;

            if (start != -1)
            {
                end = Array.FindIndex(ct, start, x => x.Text == endMarker.Trim());
            }

            foreach (var i in new[] { start, end })
            {
                if (i == -1)
                {
                    continue;
                }

                if (i - 1 >= 0)
                {
                    ct[i - 1].Text = "";
                }

                if (i >= 0 && i < ct.Length)
                {
                    ct[i].Text = "";
                }

                if (i + 1 < ct.Length)
                {
                    ct[i + 1].Text = "";
                }
            }

            if (start != -1 && end != -1)
            {
                for (var i = start + 1; i < end; i++)
                {
                    ct[i] = Invert(ct[i]);
                }
            }
            else if (start != -1)
            {
                start += 2;

                if (ct.Length != start)
                {
                    ct[start] = Invert(ct[start]);
                }
            }
            else if (end != -1)
            {
                if (--end >= 0)
                {
                    ct[end] = Invert(ct[end]);
                }
            }

            return VT100.GetString(ct);
        }
    }
}
