using System;
using System.Threading.Tasks;
using System.Windows.Threading;
using Disp = System.Windows.Threading.Dispatcher;
using Op = System.Windows.Threading.DispatcherOperation;
using DO = System.Windows.Threading.DispatcherObject;
using static System.Array;

namespace AphidUI
{
    public static class DispatcherObjectExtension
    {
        public static void Invoke(this Disp dispatcher, Action action) =>
            dispatcher.Invoke(action, Empty<object>());

        public static void Sync(this Disp dispatcher, Action action) =>
            dispatcher.Invoke(action, Empty<object>());

        public static Op BeginInvoke(this Disp dispatcher, Action action, params object[] args) =>
            dispatcher.BeginInvoke(action, args);

        public static Op Async(this Disp dispatcher, Action action, params object[] args) =>
            dispatcher.BeginInvoke(action, args);

        public static Task Run(this Disp dispatcher, Action action, params object[] args) =>
            dispatcher.BeginInvoke(action, args).Task;        

        public static TResult Invoke<TResult>(this Disp dispatcher, Func<TResult> action) =>
            (TResult)dispatcher.Invoke(action, Empty<object>());

        public static TResult Sync<TResult>(this Disp dispatcher, Func<TResult> action) =>
            (TResult)dispatcher.Invoke(action, Empty<object>());

        public static Op BeginInvoke(this DO @do, Action action, params object[] args) =>
            @do.Dispatcher.BeginInvoke(action, args);

        public static Op Async(this DO @do, Action action, params object[] args) =>
            @do.Dispatcher.BeginInvoke(action, args);

        public static Task Run(this DO @do, Action action, params object[] args) =>
            @do.BeginInvoke(action, args).Task;

        public static void Invoke(this DO @do, Action action) =>
            @do.Dispatcher.Invoke(action, Empty<object>());

        public static void Sync(this DO @do, Action action) =>
            @do.Dispatcher.Invoke(action, Empty<object>());

        public static TResult Invoke<TResult>(this DO @do, Func<TResult> action) =>
            (TResult)@do.Dispatcher.Invoke(action, Empty<object>());

        public static TResult Sync<TResult>(this DO @do, Func<TResult> action) =>
            (TResult)@do.Dispatcher.Invoke(action, Empty<object>());

        public static DispatcherProcessingDisabled DisableProcessing(this DO @do) =>
            @do.Dispatcher.DisableProcessing();
    }
}
