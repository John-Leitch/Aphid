using Components.Aphid.Interpreter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration.Shared
{
    public abstract class InteropTestBase : AphidTests
    {
        private static object _sync = new object();

        private TypeLoader _loader = new TypeLoader();

        protected TypeLoader Loader
        {
            get { return _loader; }
        }

        protected void StaticGetTest<TValue>(
            string fullMemberName,
            Action<TValue> assertActual)
        {
            StaticGetTest<TValue>(
                fullMemberName,
                default(TValue),
                setExpected: false);
        }

        // Todo: refactor fullMemberName into expression for strong typing
        protected void StaticGetTest<TValue>(
            string fullMemberName,
            TValue expected,
            bool setExpected = false)
        {
            Action<AphidInterpreter, MemberInfo> begin = null, end = null;

            TValue backup = default(TValue);

            if (setExpected)
            {
                begin = (x, member) =>
                {
                    var m = (dynamic)member;
                    backup = (TValue)m.GetValue(null);
                    m.SetValue(null, expected);
                };

                end = (x, member) =>
                {
                    ((dynamic)member).SetValue(null, backup);
                };
            }

            StaticPathTest<TValue>(
                fullMemberName,
                x => Assert.AreEqual(expected, x),
                begin,
                end);
        }

        protected void StaticPathTest<TValue>(
            string fullMemberName,
            Action<TValue> assertActual,
            Action<AphidInterpreter, MemberInfo> begin = null,
            Action<AphidInterpreter, MemberInfo> end = null)
        {
            lock (_sync)
            {
                StaticPathTestUnsafe(fullMemberName, assertActual, begin, end);
            }
        }

        protected void StaticPathTestUnsafe<TValue>(
            string fullMemberName,
            Action<TValue> assertActual,
            Action<AphidInterpreter, MemberInfo> begin = null,
            Action<AphidInterpreter, MemberInfo> end = null)
        {
            var interpreter = GetNextInterpreter();
            var member = (dynamic)GetMember(fullMemberName).Single();

            if (begin != null)
            {
                begin(interpreter, member);
            }

            try
            {
                // Todo: refactor into shared path parsing
                var fullTypeName = fullMemberName.RemoveAtLastIndexOf('.');
                var ns = fullTypeName.RemoveAtLastIndexOf('.');
                var memberPath = fullMemberName.Substring(ns.Length + 1);
                var script = string.Format("using {0}; ret {1}", ns, memberPath);
                var actual = (TValue)Execute(script).Value;
                assertActual(actual);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
                throw;
            }
            finally
            {
                if (end != null)
                {
                    end(interpreter, member);
                }
            }
        }

        private MemberInfo[] GetMember(string fullMemberName)
        {
            var memberName = fullMemberName.SubstringAtLastIndexOf('.', 1);
            var fullTypeName = fullMemberName.RemoveAtLastIndexOf('.');
            var ns = fullTypeName.RemoveAtLastIndexOf('.');
            var typeName = fullTypeName.SubstringAtLastIndexOf('.', 1);
            var type = _loader.ResolveFullType(fullTypeName);

            if (type == null)
            {
                throw new InvalidOperationException(
                    string.Format("Could not find type '{0}'.", fullTypeName));
            }

            return type.GetMember(memberName);
        }
    }
}
