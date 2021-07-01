﻿using System;

namespace Components
{
#if DBG_STEPTHROUGH
    [DebuggerStepThrough]
#endif
    public static partial class FluentExtensions
    {
        public static T Do<T>(this T obj, Action action)
        {
            action();
            return obj;
        }

        public static T Do<T>(this T obj, Action<T> action)
        {
            action(obj);
            return obj;
        }

        public static T DoIf<T>(this T obj, bool condition, Action<T> trueAction)
        {
            if (condition)
            {
                trueAction(obj);
            }

            return obj;
        }

        public static T DoIf<T>(this T obj, Func<bool> condition, Action<T> trueAction)
        {
            if (condition())
            {
                trueAction(obj);
            }

            return obj;
        }

        public static T DoIf<T>(this T obj, Func<T, bool> condition, Action<T> trueAction)
        {
            if (condition(obj))
            {
                trueAction(obj);
            }

            return obj;
        }

        public static T DoIf<T>(this T obj, bool condition, Action<T> trueAction, Action<T> falseAction)
        {
            if (condition)
            {
                trueAction(obj);
            }
            else
            {
                falseAction(obj);
            }

            return obj;
        }

        public static T DoIf<T>(this T obj, Func<bool> condition, Action<T> trueAction, Action<T> falseAction)
        {
            if (condition())
            {
                trueAction(obj);
            }
            else
            {
                falseAction(obj);
            }

            return obj;
        }

        public static T DoIf<T>(this T obj, Func<T, bool> condition, Action<T> trueAction, Action<T> falseAction)
        {
            if (condition(obj))
            {
                trueAction(obj);
            }
            else
            {
                falseAction(obj);
            }

            return obj;
        }

        public static T As<T>(this object obj, Action<T> action)
        {
            var x = (T)obj;
            action(x);

            return x;
        }

        public static K As<T, K>(this T obj, Func<T, K> func) => func(obj);

        public static TResult Then<T, TResult>(this T obj, Func<T, TResult> func) => func(obj);

        public static void Then(this Action first, Action action)
        {
            first();
            action();            
        }

        public static void Then<T>(this Func<T> first, Action action)
        {
            first();
            action();
        }

        public static void Then<T>(this Func<T> first, Action<T> action) => action(first());

        public static TResult Then<TResult>(this Action first, Func<TResult> func)
        {
            first();

            return func();
        }

        public static TResult Then<T, TResult>(this Func<T> first, Func<T, TResult> func) => func(first());

        public static Delegate Then(this Delegate @delegate, Action action)
        {
            action();

            return @delegate;
        }

        public static IfContext<TInput, TResult> If<TInput, TResult>(
            this TInput input,
            bool condition,
            Func<TInput, TResult> ifResult) =>
            new(input, condition, ifResult);

        public static IfContext<TInput, TResult> If<TInput, TResult>(
            this TInput input,
            Func<TInput, bool> condition,
            Func<TInput, TResult> ifResult) =>
            new(input, condition, ifResult);

        public static void Using<TDisposable>(this TDisposable obj, Action action)
            where TDisposable : IDisposable
        {
            using (obj)
            {
                action();
            }
        }

        public static void Using<TDisposable>(this TDisposable obj, Action<TDisposable> action)
            where TDisposable : IDisposable
        {
            using (obj)
            {
                action(obj);
            }
        }

        public static void Using<TSource, TDisposable>(
            this TSource obj,
            Func<TSource, TDisposable> selector,
            Action<TSource> action)
            where TDisposable : IDisposable
        {
            using (selector(obj))
            {
                action(obj);
            }
        }

        public static TResult Using<TDisposable, TResult>(
            this TDisposable obj,
            Func<TDisposable, TResult> func)
            where TDisposable : IDisposable
        {
            using (obj)
            {
                return func(obj);
            }
        }

        public static TResult Using<TSource, TDisposable, TResult>(
            this TSource obj,
            Func<TSource, TDisposable> selector,
            Func<TSource, TResult> func)
            where TDisposable : IDisposable
        {
            using (selector(obj))
            {
                return func(obj);
            }
        }
    }
}
