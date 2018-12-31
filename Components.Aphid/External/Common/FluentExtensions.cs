using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public static partial class FluentExtensions
    {
        public static T Do<T>(this T obj, Action<T> action)
        {
            action(obj);
            return obj;
        }

        public static T As<T>(this object obj, Action<T> action)
        {
            var x = (T)obj;
            action(x);

            return x;
        }

        public static K Then<T, K>(this T obj, Func<T, K> func) => func(obj);        

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
            new IfContext<TInput, TResult>(input, condition, ifResult);
    }
}
