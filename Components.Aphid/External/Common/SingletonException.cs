using System;
using E = System.Exception;
using SE = Components.SingletonException;

namespace Components
{

    public class SingletonException : E
    {
        public Type SingeltonType { get; }

        public SingletonException(Type t)
            : this(t, default(E))
        {

        }

        public SingletonException(Type t, string message)
            : this(t, message, null)
        {

        }

        public SingletonException(Type t, E innerException)
            : this(
                t,
                $"Can only construct one instance of singleton type {t}",
                innerException)
        {

        }

        public SingletonException(Type t, string message, E innerException)
            : this(
                message,
                innerException)
        {
            SingeltonType = t;
        }

        public SingletonException()
        {
        }

        public SingletonException(string message) :
            base(message)
        {
        }

        public SingletonException(string message, E innerException) :
            base(message, innerException)
        {
        }

        public static SE Create<T>() => new SE(typeof(T));

        public static SE Create<T>(string message) => new SE(typeof(T), message);

        public static SE Create<T>(E innerException) => new SE(typeof(T), innerException);

        public static SE Create<T>(string message, E innerException) => new SE(typeof(T), message, innerException);

        public static SE Throw<T>() => throw Create<T>();

        public static SE Throw<T>(string message) => throw Create<T>(message);

        public static SE Throw<T>(E innerException) => throw Create<T>(innerException);

        public static SE Throw<T>(string message, E innerException) => throw Create<T>(message, innerException);
    }
}
