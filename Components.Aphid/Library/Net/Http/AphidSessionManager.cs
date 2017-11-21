using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net.Http
{
    public class AphidSessionManager
    {
        private Dictionary<string, AphidObject> _sessions =
            new Dictionary<string, AphidObject>();

        public const string CookieName = "AphidSession";

        public const int IdSize = 0x20;

        public string NextSessionId()
        {
            var bytes = new byte[IdSize];
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);

            return string.Join("", bytes.Select(x => string.Format("{0:X2}", x)));
        }

        public Cookie CreateCookie()
        {
            var c = new Cookie(CookieName, NextSessionId());
            c.Expires = DateTime.Now.AddMinutes(60);
            return c;
        }

        public Cookie GetCookie(HttpListenerContext context)
        {
            return context.Request.Cookies[AphidSessionManager.CookieName];
        }

        public AphidObject GetSession(string key)
        {
            AphidObject session;

            return _sessions.TryGetValue(key, out session) ? session : null;
        }

        public AphidObject CreateSession(string id)
        {
            lock (_sessions)
            {
                var session = new AphidObject();
                _sessions.Add(id, session);

                return session;
            }
        }

        public void DestroySession(string id)
        {
            lock (_sessions)
            {
                _sessions.Remove(id);
            }
        }
    }
}
