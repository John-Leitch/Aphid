using Components.Aphid.Interpreter;
using Components.Aphid.Library.Net.Http;
using Components.External.ConsolePlus;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

namespace Components.Aphid.Library.Net
{
    public class HttpServer
    {
        private const string _formUrlEncoded = "application/x-www-form-urlencoded";

        private string[] _prefixes;

        private string _webRoot;

        private Encoding _encoding = Encoding.GetEncoding(1252);

        private AphidSessionManager _sessionManager = new AphidSessionManager();

        private AphidObject _globals = new AphidObject();

        public HttpServer(string[] prefixes, string webRoot)
        {
            _prefixes = prefixes;
            _webRoot = webRoot;
        }

        public HttpServer(string prefix, string webRoot)
            : this(new [] { prefix }, webRoot)
        {
        }

        public void Start()
        {
            _webRoot = GetWebRoot();
            Cli.WriteInfoMessage("Web root: ~Cyan~{0}~R~", _webRoot);
            var listener = new HttpListener();

            foreach (var p in _prefixes)
            {
                listener.Prefixes.Add(p);
                Cli.WriteQueryMessage("Listening on ~Cyan~{0}~R~", p);
            }

            listener.Start();
            Cli.WriteInfoMessage("Server started");

            while (true)
            {
                var context = listener.GetContext();

                ThreadPool.QueueUserWorkItem(x =>
                {
                    Cli.WriteQueryMessage(
                        "Client ~Green~{0}~R~ requested ~Cyan~{1}~R~",
                        context.Request.RemoteEndPoint.Address,
                        context.Request.Url);

                    HandleClient(context);
                });
            }
        }

        private string GetWebRoot()
        {
            return Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "WebRoot");
        }

        private void HandleClient(HttpListenerContext context)
        {
            byte[] resp;

            try
            {
                resp = CreateResponse(context);
            }
            catch (FileNotFoundException)
            {
                resp = SetError(context, 404, "404 not found: {0}", context.Request.Url);
            }
            catch (Exception e)
            {
                resp = SetError(context, 500, "500 internal server errror: {0}", e.Message);
            }

            WriteResponse(context, resp);
        }

        private byte[] SetError(HttpListenerContext context, int error, string format, params object[] args)
        {
            context.Response.StatusCode = error;
            var errorMsg = string.Format(format, args);

            return _encoding.GetBytes(errorMsg);
        }

        byte[] CreateResponse(HttpListenerContext context)
        {
            var session = GetSession(context);
            var localPath = GetLocalPath(context.Request.Url);
            var code = File.ReadAllText(localPath);

            return _encoding.GetBytes(InterpretAphid(localPath, code, context, session));
        }

        private string InterpretAphid(
            string codeFile,
            string code,
            HttpListenerContext context,
            AphidObject session)
        {
            var interpreter = new AphidInterpreter()
            {
                GatorEmitFilter = WebUtility.HtmlEncode,
            };

            string body = "";

            if (context.Request.ContentLength64 > 0)
            {
                using (var reader = new StreamReader(context.Request.InputStream))
                {
                    body = reader.ReadToEnd();
                }
            }

            interpreter.CurrentScope.Add("context", new AphidObject(context));
            interpreter.CurrentScope.Add("query", CreateQueryObject(context));
            interpreter.CurrentScope.Add("session", session);
            interpreter.CurrentScope.Add("body", new AphidObject(body));
            interpreter.CurrentScope.Add("globals", _globals);
            
            interpreter.CurrentScope.Add(
                "post",
                context.Request.ContentType != null &&
                context.Request.ContentType.StartsWith(_formUrlEncoded) ?
                    CreateQueryObject(body) :
                    new AphidObject());

            interpreter.Loader.SearchPaths.Add(Path.GetDirectoryName(codeFile));

            using (interpreter.Out = new StringWriter())
            {
                interpreter.Interpret(code, isTextDocument: true);
                interpreter.Out.Flush();

                return interpreter.Out.ToString();
            }
        }

        private AphidObject CreateQueryObject(HttpListenerContext context)
        {
            return CreateQueryObject(context.Request.Url.Query);
        }

        private AphidObject CreateQueryObject(string query)
        {
            var s = HttpUtility.ParseQueryString(query);

            var table = s.Keys
                .OfType<string>()
                .ToDictionary(x => x, x => new AphidObject(s[x]));

            var obj = new AphidObject();

            foreach (var kvp in table)
            {
                obj.Add(kvp.Key, kvp.Value);
            }

            return obj;
        }

        private string GetLocalPath(Uri uri)
        {
            var relativePath = uri.LocalPath.Replace('/', '\\');

            if (relativePath.Any() && relativePath[0] == '\\')
            {
                relativePath = relativePath.Remove(0, 1);
            }

            var p = Path.GetFullPath(
                Path.Combine(
                    _webRoot,
                    relativePath));

            if (Directory.Exists(p) && !File.Exists(p))
            {
                p = Path.Combine(p, "Index.alx");
            }

            // Protect against directory traversal attacks.
            if (!p.StartsWith(_webRoot))
            {
                throw new SecurityException("Cannot read files outside of web root.");
            }

            // Just in case.
            if (Regex.IsMatch(p, @"([\\/]\.\.)|(\.\.[\\/])"))
            {
                throw new SecurityException("Invalid characters in path.");
            }

            return p;
        }

        private void WriteResponse(HttpListenerContext context, byte[] response)
        {
            var r = context.Response;

            using (r.OutputStream)
            {
                r.ContentType = "text/html";
                r.ContentLength64 = response.Length;
                r.OutputStream.Write(response, 0, response.Length);
            }

            Cli.WriteQueryMessage(
                "Client ~Green~{0}~R~ disconnected",
                context.Request.RemoteEndPoint.Address);
        }

        private AphidObject GetSession(HttpListenerContext context)
        {
            var cookie = _sessionManager.GetCookie(context);
            AphidObject session = null;

            if (cookie != null)
            {
                session = _sessionManager.GetSession(cookie.Value);
            }

            if (cookie == null || session == null)
            {
                cookie = _sessionManager.CreateCookie();
                context.Response.SetCookie(cookie);
                session = _sessionManager.CreateSession(cookie.Value);
            }

            return session;
        }
    }
}
