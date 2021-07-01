﻿using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace Components.Aphid.Library.Net.Http
{
    public class AphidSessionManager
    {
        private readonly Dictionary<string, AphidObject> _sessions =
            new();

        private readonly RNGCryptoServiceProvider _rng = new();

        public const string CookieName = "AphidSession";

        public const int IdSize = 0x20;

        public string NextSessionId()
        {
            var bytes = new byte[IdSize];

            lock (_rng)
            {
                _rng.GetBytes(bytes);
            }

            return string.Concat(bytes.Select(x => string.Format("{0:X2}", x)));
        }

        public Cookie CreateCookie() =>
            new(CookieName, NextSessionId()) { Expires = DateTime.Now.AddMinutes(60) };

        public static Cookie GetCookie(HttpListenerContext context) =>
            context.Request.Cookies[CookieName];

        public AphidObject GetSession(string key) =>
            _sessions.TryGetValue(key, out var session) ? session : null;

        public AphidObject CreateSession(string id)
        {
            lock (_sessions)
            {
                var session = AphidObject.Scope();
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
