using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.UI;
using Components.External.ConsolePlus;
using LanguageServer;
using LanguageServer.Client;
using LanguageServer.Json;
using LanguageServer.Parameters;
using LanguageServer.Parameters.General;
using LanguageServer.Parameters.TextDocument;
using LanguageServer.Parameters.Workspace;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace SampleServer
{
    public class App : ServiceConnection
    {
        private string _text;
        private Uri _workerSpaceRoot;
        private int _maxNumberOfProblems;
        private TextDocumentManager _documents;
        private AphidInterpreter _interpreter;
        private AphidScopeObjectAutocompletionSource _scope;
        private Autocomplete[] _words;
        private CompletionItem[] _items;

        public App(Stream input, Stream output)
            : base(input, output)
        {
            _documents = new TextDocumentManager();
            _documents.Changed += Documents_Changed;
            _interpreter = new AphidInterpreter();
            _interpreter.Interpret(@"
                #'std';
                //#'meta';
                //#'compiler';
                using System;
                using System.Collections.Generic;
                using System.IO;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;

            ");

            _interpreter.EnterScope();

            _scope = new AphidScopeObjectAutocompletionSource(_interpreter.CurrentScope);
        }



        private void Documents_Changed(object sender, TextDocumentChangedEventArgs e)
        {
            
            ValidateTextDocument(e.Document);
        }

        protected override Result<InitializeResult, ResponseError<InitializeErrorData>> Initialize(InitializeParams @params)
        {
            _workerSpaceRoot = @params.rootUri;
            var result = new InitializeResult
            {
                capabilities = new ServerCapabilities
                {
                    textDocumentSync = TextDocumentSyncKind.Full,
                    completionProvider = new CompletionOptions
                    {
                        resolveProvider = true,
                        triggerCharacters = new string[] { ".", " " },
                    },
                }
            };
            return Result<InitializeResult, ResponseError<InitializeErrorData>>.Success(result);
        }

        protected override void DidOpenTextDocument(DidOpenTextDocumentParams @params)
        {
            _documents.Add(@params.textDocument);
            Logger.Instance.Log($"{@params.textDocument.uri} opened.");
        }

        protected override void DidChangeTextDocument(DidChangeTextDocumentParams @params)
        {
            _documents.Change(@params.textDocument.uri, @params.textDocument.version, @params.contentChanges);
            Logger.Instance.Log($"{@params.textDocument.uri} changed.");
        }

        protected override void DidCloseTextDocument(DidCloseTextDocumentParams @params)
        {
            _documents.Remove(@params.textDocument.uri);
            Logger.Instance.Log($"{@params.textDocument.uri} closed.");
        }

        protected override void DidChangeConfiguration(DidChangeConfigurationParams @params)
        {
            _maxNumberOfProblems = @params?.settings?.languageServerExample?.maxNumberOfProblems ?? 100;
            foreach (var document in _documents.All)
            {
                ValidateTextDocument(document);
            }
        }

        private void ValidateTextDocument(TextDocumentItem document)
        {
            _text = document.text;

            //Proxy.TextDocument.PublishDiagnostics(new PublishDiagnosticsParams
            //{
            //    uri = document.uri,
            //    diagnostics = new Diagnostic[0],
                
            //});

            //return;

            //Logger.Instance.Log("Validate " + document.text);
            Logger.Instance.Log("Validate");

            Diagnostic[] diagnostics;
            List<AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(document.text);
                diagnostics = new Diagnostic[0];
                Logger.Instance.Log("Success");
            }
            catch (AphidParserException e)
            {
                
                Logger.Instance.Log("Failure: " + e.ToString());
                var pos = TokenHelper.GetIndexPosition(document.text, e.UnexpectedToken.Index);

                if (pos != null)
                {
                    Logger.Instance.Log(pos.ToString());
                }
                else
                {
                    Logger.Instance.Log("No position");
                }

                diagnostics = new[]
                {
                    new Diagnostic
                    {
                        severity = DiagnosticSeverity.Error,
                        range = new Range
                        {
                            start = pos != null ? new Position { line = pos.Item1, character = pos.Item2 } : new Position(),
                            end = pos != null ? new Position { line = pos.Item1, character = pos.Item2 + e.UnexpectedToken.Lexeme != null && e.UnexpectedToken.Lexeme.Length > 0 ? e.UnexpectedToken.Lexeme.Length : 0 } : new Position(),
                        },
                        message = ParserErrorMessage.Create(document.text, e, false),
                        source = "aphid"

                    }
                };
            }

            Proxy.TextDocument.PublishDiagnostics(new PublishDiagnosticsParams
            {
                uri = document.uri,
                diagnostics = diagnostics
            });
        }

        public class AphidScopeVisitor : AphidVisitor
        {
            private AphidInterpreter _interpreter;

            private List<AphidExpression> _interpret;

            public AphidScopeVisitor(AphidInterpreter interpreter)
            {
                _interpreter = interpreter;
            }

            protected override void Visit(AphidExpression expression)
            {
                if (expression.Type == AphidExpressionType.UsingExpression)
                {
                    _interpret.Add(expression);
                }
                else if (expression.Type == AphidExpressionType.IdentifierExpression)
                {
                    _interpret.Add(new IdentifierExpression(
                        ((IdentifierExpression)expression).Identifier,
                        new List<IdentifierExpression> { new IdentifierExpression("var") }));
                }
            }

            protected override void BeginVisit(List<AphidExpression> ast)
            {
                _interpret = new List<AphidExpression>();
            }

            protected override void EndVisit(List<AphidExpression> ast)
            {
                _interpreter.CurrentScope.Clear();
                _interpreter.Interpret(_interpret);
            }
        }

        private void UpdateScope(List<AphidExpression> ast)
        {
            new App.AphidScopeVisitor(_interpreter).Visit(ast);
        }

        protected override void DidChangeWatchedFiles(DidChangeWatchedFilesParams @params)
        {
            Logger.Instance.Log("We received an file change event");
        }

        protected override Result<CompletionResult, ResponseError> Completion(CompletionParams @params)
        {
            Logger.Instance.Log("Completion");
            var index = TokenHelper.GetIndex(
                _text,
                (int)@params.position.line,
                (int)@params.position.character);

            string buf;
            //Logger.Instance.Log(_text.Remove(index));
            _words = _scope.GetWords(_text, index, false, out buf).ToArray();
            _items = _words.Select((x, i) => new CompletionItem
            {
                insertText = x.Text,
                label = x.View,
                kind = CompletionItemKind.Text,
                detail = x.View,
                documentation = x.View,
                data = i,
            })
            .ToArray();

            var array = new[]
            {
                new CompletionItem
                {
                    label = "TypeScript",
                    kind = CompletionItemKind.Text,
                    data = 1
                },
                new CompletionItem
                {
                    label = "JavaScript",
                    kind = CompletionItemKind.Text,
                    data = 2
                }
            };

            array = _items;
            return Result<CompletionResult, ResponseError>.Success(array);
        }

        //protected override Result<ArrayOrObject<CompletionItem, CompletionList>, ResponseError> Completion(TextDocumentPositionParams @params)
        //{
        //    Logger.Instance.Log("Completion");
        //    var index = TokenHelper.GetIndex(
        //        _text,
        //        (int)@params.position.line,
        //        (int)@params.position.character);

        //    string buf;
        //    Logger.Instance.Log(_text.Remove(index));
        //    _words = _scope.GetWords(_text, index, false, out buf).ToArray();
        //    _items = _words.Select((x, i) => new CompletionItem
        //    {
        //        insertText = x.Text,
        //        label = x.View,
        //        kind = CompletionItemKind.Text,
        //        detail = x.View,
        //        documentation = x.View,
        //        data = i,
        //    })
        //    .ToArray();

        //    var array = new[]
        //    {
        //        new CompletionItem
        //        {
        //            label = "TypeScript",
        //            kind = CompletionItemKind.Text,
        //            data = 1
        //        },
        //        new CompletionItem
        //        {
        //            label = "JavaScript",
        //            kind = CompletionItemKind.Text,
        //            data = 2
        //        }
        //    };

        //    array = _items;
        //    return Result<ArrayOrObject<CompletionItem, CompletionList>, ResponseError>.Success(array);
        //}

        protected override Result<CompletionItem, ResponseError> ResolveCompletionItem(CompletionItem @params)
        {
            Logger.Instance.Log("ResolveCompletion");
            //if (@params.data == 1)
            //{
            //    @params.detail = "TypeScript details";
            //    @params.documentation = "TypeScript documentation";
            //}
            //else if (@params.data == 2)
            //{
            //    @params.detail = "JavaScript details";
            //    @params.documentation = "JavaScript documentation";
            //}

            if (@params.data != null)
            {
                var item = _items[@params.data];
                @params.detail = item.detail;
                @params.documentation = item.documentation;
            }

            return Result<CompletionItem, ResponseError>.Success(@params);
        }
    }
}
