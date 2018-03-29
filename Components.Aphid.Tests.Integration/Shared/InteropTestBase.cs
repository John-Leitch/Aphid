﻿using Components.Aphid.Interpreter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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

        protected virtual Type TestClassType
        {
            get { return typeof(TestClass); }
        }

        protected void StaticGetTest<TValue>(
            LambdaExpression fullMemberName,
            Action<TValue> assertActual)
        {
            StaticGetTest<TValue>(
                fullMemberName,
                default(TValue),
                setExpected: false);
        }

        // Todo: refactor fullMemberName into expression for strong typing
        protected void StaticGetTest<TValue>(
            LambdaExpression fullMemberName,
            TValue expected,
            bool setExpected = false)
        {
            StaticSetGetTest(fullMemberName, null, expected, setExpected);
        }
        
        protected void StaticSetGetTest<TValue>(
            LambdaExpression fullMemberName,
            string setExpression,
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
                setExpression,
                x => Assert.AreEqual(expected, x),
                begin,
                end);
        }

        protected void StaticPathTest<TValue>(
            LambdaExpression fullMemberName,
            string setExpression,
            Action<TValue> assertActual,
            Action<AphidInterpreter, MemberInfo> begin = null,
            Action<AphidInterpreter, MemberInfo> end = null)
        {
            lock (_sync)
            {
                StaticPathTestUnsafe(fullMemberName, setExpression, assertActual, begin, end);
            }
        }

        protected void StaticPathTestUnsafe<TValue>(
            LambdaExpression memberSelector,
            string setExpression,
            Action<TValue> assertActual,
            Action<AphidInterpreter, MemberInfo> begin = null,
            Action<AphidInterpreter, MemberInfo> end = null)
        {
            var interpreter = GetNextInterpreter();
            var memberExp = GetMemberExp(memberSelector);
            var member = memberExp.Member;

            if (begin != null)
            {
                begin(interpreter, member);
            }

            try
            {
                var fullMemberName = GetFullStaticMemberPath(memberSelector);
                // Todo: refactor into shared path parsing
                var fullTypeName = fullMemberName.RemoveAtLastIndexOf('.');
                var ns = fullTypeName.RemoveAtLastIndexOf('.');
                var memberPath = fullMemberName.Substring(ns.Length + 1);
                
                var script = string.Format(
                    setExpression == null ?
                        "using {0}; ret {1}" :
                        "using {0}; {1} = ({2}); ret {1}",
                    ns,
                    memberPath,
                    setExpression);

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

        protected MemberExpression GetMemberExp(LambdaExpression expr)
        {
            var curExp = expr.Body;
            MemberExpression m;

            while (true)
            {
                if ((m = curExp as MemberExpression) != null)
                {
                    return m;
                }
                else
                {
                    curExp = ((dynamic)curExp).Operand;
                }
            }
        }

        protected object GetValue(LambdaExpression expr)
        {
            var m = GetMemberExp(expr);
            return ((dynamic)m.Member).GetValue(null);
        }

        protected string GetFullStaticMemberPath(LambdaExpression expr)
        {
            var s = GetMemberExp(expr).ToString();

            return TestClassType.FullName.RemoveAtLastIndexOf('.') + "." + s;
        }
    }
}