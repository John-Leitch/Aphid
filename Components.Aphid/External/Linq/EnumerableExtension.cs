using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;


namespace Components
{
    public static class EnumerableExtension
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Prepend
        ////////////////////////////////////////////////////////////////////////////////////////////////
        //[DebuggerStepThrough]
        //public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T value)
        //{
        //    return new[] { value }.Concat(source);
        //}

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Append
        ////////////////////////////////////////////////////////////////////////////////////////////////
        //[DebuggerStepThrough]
        //public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T value)
        //{
        //    return source.Concat(new[] { value });
        //}

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // None
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static bool None<T>(this IEnumerable<T> source)
        {
            return !source.Any();
        }

        [DebuggerStepThrough]
        public static bool None<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return !source.Any(predicate);
        }

        [DebuggerStepThrough]
        public static bool None<T>(this IEnumerable<T> source, T value)
        {
            return !source.Contains(value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // All
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static bool All(this IEnumerable<bool> source)
        {
            return source.All(x => x);
        }

        [DebuggerStepThrough]
        public static bool All<T>(this IEnumerable<T> source, T value)
        {
            return source.All(x => x.Equals(value));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Join
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<T> Join<T>(this IEnumerable<IEnumerable<T>> source)
        {
            return source.SelectMany(x => x);
        }

        [DebuggerStepThrough]
        public static string Join<T>(this IEnumerable<string> source)
        {
            return source.Aggregate((x, y) => x + y);
        }

        [DebuggerStepThrough]
        public static string Join<T>(this IEnumerable<string> source, string separator)
        {
            return source.Aggregate((x, y) => x + separator + y);
        }

        [DebuggerStepThrough]
        public static IEnumerable<KeyValuePair<TInnerKey, TSource>>
            Join<TOuterKey, TInnerKey, TSource>(
            this IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source)
        {
            return source.SelectMany(x => x.Value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // ToDictionary
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TKey, TElement> ToDictionary<TKey, TElement>(
            this IEnumerable<KeyValuePair<TKey, TElement>> source)
        {
            return source.ToDictionary(x => x.Key, x => x.Value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GetOrCreate
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static TValue GetOrCreate<TKey, TValue>(this Dictionary<TKey, TValue> d, TKey key)
            where TValue : new()
        {
            TValue value;

            if (!d.TryGetValue(key, out value))
            {
                value = new TValue();
                d.Add(key, value);
            }

            return value;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereDictionary
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TKey, TElement> WhereDictionary<TKey, TElement>(
            this IEnumerable<KeyValuePair<TKey, TElement>> source,
            Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            return source.Where(predicate).ToDictionary();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // JoinValues
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TElement> JoinValues<TKey, TElement>(
            this IEnumerable<Dictionary<TKey, TElement>> source)
        {
            return source.SelectMany(x => x.Values);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // JoinKeys
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TKey> JoinKeys<TKey, TElement>(
            this IEnumerable<Dictionary<TKey, TElement>> source)
        {
            return source.SelectMany(x => x.Keys);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // DistinctKeys
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TKey> DistinctKeys<TKey, TElement>(
            this IEnumerable<Dictionary<TKey, TElement>> source)
        {
            return source.SelectMany(x => x.Keys).Distinct();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WithKey
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TResult, TElement> WithKey<TKey, TElement, TResult>(
            this Dictionary<TKey, TElement> source,
            Func<KeyValuePair<TKey, TElement>, TResult> keySelector)
        {
            return source.ToDictionary(keySelector, x => x.Value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WithValue
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TKey, TResult> WithValue<TKey, TElement, TResult>(
            this Dictionary<TKey, TElement> source,
            Func<KeyValuePair<TKey, TElement>, TResult> elementSelector)
        {
            return source.ToDictionary(x => x.Key, elementSelector);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // AsKeyFor
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TKey, TElement> AsKeyFor<TKey, TElement>(
            this IEnumerable<TKey> source,
            Func<TKey, TElement> elementSelector)
        {
            return source.ToDictionary(x => x, elementSelector);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereAny
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<IEnumerable<TElement>> WhereAny<TElement>(
            this IEnumerable<IEnumerable<TElement>> source,
            Func<TElement, bool> predicate)
        {
            return source.Where(x => x.Any(predicate));
        }

        [DebuggerStepThrough]
        public static IEnumerable<IEnumerable<TElement>> WhereAny<TElement>(
            this IEnumerable<IEnumerable<TElement>> source)
        {
            return source.Where(x => x.Any());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereNone
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<IEnumerable<TElement>> WhereNone<TElement>(
            this IEnumerable<IEnumerable<TElement>> source,
            Func<TElement, bool> predicate)
        {
            return source.Where(x => x.None(predicate));
        }

        [DebuggerStepThrough]
        public static IEnumerable<IEnumerable<TElement>> WhereNone<TElement>(
            this IEnumerable<IEnumerable<TElement>> source)
        {
            return source.Where(x => x.None());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereValue
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TKey>
            WhereValue<TKey, TElement>(
                this Dictionary<TKey, TElement> source,
                Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            return source.Where(predicate).Select(x => x.Key);
        }

        [DebuggerStepThrough]
        public static IEnumerable<TKey>
            WhereValue<TKeyOuter, TKey, TElement>(
                this KeyValuePair<TKeyOuter, Dictionary<TKey, TElement>> source,
                Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            return source.Value.WhereValue(predicate);
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, IEnumerable<TKey>>
            WhereValue<TKeyOuter, TKey, TElement>(
                this Dictionary<TKeyOuter, Dictionary<TKey, TElement>> source,
                Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            return source.WhereValue(predicate);
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(
                this KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, TElement>>> source,
                Func<KeyValuePair<TKeyInner, TElement>, bool> predicate)
        {
            return source.Value.WithValue(x => x.Value.WhereValue(predicate));
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(
                this Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, TElement>>> source,
                Func<KeyValuePair<TKeyInner, TElement>, bool> predicate)
        {
            return source.WithValue(x => x.Value.WhereValue(predicate));
        }
        
        [DebuggerStepThrough]
        public static IEnumerable<TKey> 
            WhereValue<TKey>(
                this Dictionary<TKey, bool> source)
        {
            return source.Where(x => x.Value).Select(x => x.Key);
        }

        [DebuggerStepThrough]
        public static IEnumerable<TKey> 
            WhereValue<TKey, TKeyOuter>(
                this KeyValuePair<TKeyOuter, Dictionary<TKey, bool>> source)
        {
            return source.Value.WhereValue();
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValue<TKeyInner, TKeyOuter>(
                this Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>> source)
        {
            return source.WithValue(x => x.Value.WhereValue());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2>(
                this KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            return source.Value.WithValue(x => x.Value.WhereValue());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2>(
                this Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            return source.WithValue(x => x.Value.WhereValue());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereValueNot
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TKey>
            WhereValueNot<TKey>(
                this Dictionary<TKey, bool> source)
        {
            return source.Where(x => !x.Value).Select(x => x.Key);
        }

        [DebuggerStepThrough]
        public static IEnumerable<TKey>
            WhereValueNot<TKey, TKeyOuter>(
                this KeyValuePair<TKeyOuter, Dictionary<TKey, bool>> source)
        {
            return source.Value.WhereValueNot();
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValueNot<TKeyInner, TKeyOuter>(
                this Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>> source)
        {
            return source.WithValue(x => x.Value.WhereValueNot());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValueNot<TKeyInner, TKeyOuter, TKeyOuter2>(
                this KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            return source.Value.WithValue(x => x.Value.WhereValueNot());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>>
            WhereValueNot<TKeyInner, TKeyOuter, TKeyOuter2>(
                this Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            return source.WithValue(x => x.Value.WhereValueNot());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereValueAny
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TKey, IEnumerable<TElement>>
            WhereValueAny<TKey, TElement>(
                this Dictionary<TKey, IEnumerable<TElement>> source)
        {
            return source.WhereDictionary(x => x.Value.Any());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>>
            WhereValueAny<TKey, TKeyOuter, TElement>(
                this Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>> source)
        {
            return source.WithValue(x => x.Value.WhereValueAny());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKey, IEnumerable<TElement>>
            WhereValueAny<TKey, TElement>(
                this Dictionary<TKey, IEnumerable<TElement>> source,
                Func<TElement, bool> predicate)
        {
            return source.WhereDictionary(x => x.Value.Any(predicate));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GroupJoin
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TInnerKey, IEnumerable<TSource>> GroupJoin<TOuterKey, TInnerKey, TSource>(
            this IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source)
        {
            return source.Join().GroupToDictionary();
        }

        [DebuggerStepThrough]
        public static Dictionary<TInnerKey, TElement> GroupJoin<TOuterKey, TInnerKey, TSource, TElement>(
            this IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source,
            Func<IEnumerable<KeyValuePair<TInnerKey, TSource>>, TElement> elementSelector)
        {
            return source.Join().GroupToDictionary(x => x.Key, elementSelector);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GroupToDictionary
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static Dictionary<TKey, IEnumerable<TSource>> GroupToDictionary<TKey, TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            return source
                .GroupBy(keySelector)
                .ToDictionary(x => x.Key, x => x.AsEnumerable());
        }

        [DebuggerStepThrough]
        public static Dictionary<TKey, TElement> GroupToDictionary<TSource, TKey, TElement>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<IGrouping<TKey, TSource>, TElement> elementSelector)
        {
            return source
                .GroupBy(keySelector)
                .ToDictionary(x => x.Key, elementSelector);
        }

        [DebuggerStepThrough]
        public static Dictionary<TKey, IEnumerable<TSource>> GroupToDictionary<TKey, TSource>(
            this IEnumerable<KeyValuePair<TKey, TSource>> source)
        {
            return source
                .GroupBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Select(y => y.Value));
        }

        [DebuggerStepThrough]
        public static Dictionary<TKey, TSource[]> GroupToArrayDictionary<TKey, TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            return source
                .GroupBy(keySelector)
                .ToDictionary(x => x.Key, x => x.ToArray());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereContains
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<IEnumerable<TSource>> WhereContains<TSource>(
            this IEnumerable<IEnumerable<TSource>> source,
            TSource value)
        {
            return source.Where(x => x.Contains(value));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Except
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TSource> Except<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            return source.Where(x => !predicate(x));
        }

        [DebuggerStepThrough]
        public static IEnumerable<TSource> ExceptNull<TSource>(this IEnumerable<TSource> source)
            where TSource : class
        {
            return source.Where(x => x != null);
        }

        [DebuggerStepThrough]
        public static IEnumerable<TSource> ExceptNull<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
            where TResult : class
        {
            return source.Where(x => selector(x) != null);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Distinct
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TSource> Distinct<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            return source.Distinct(new SelectorComparer<TSource, TKey>(keySelector));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GroupEvery
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<IEnumerable<T>> GroupEvery<T>(this IEnumerable<T> source, int groupSize)
        {
            return Enumerable
                .Range(0, (int)Math.Ceiling((double)source.Count() / groupSize))
                .Select(x => source.Skip(x * groupSize).Take(groupSize));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // TakeLast
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TSource> TakeLast<TSource>(this IEnumerable<TSource> source, int count)
        {
            return source.Skip(source.Count() - count);
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Iter
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static void Iter<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // AsyncIter
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static void AsyncIter<T>(this IEnumerable<T> source, Action<T> action)
        {
            var resets = new List<ManualResetEvent>();

            foreach (var item in source)
            {
                var i = item;
                var reset = new ManualResetEvent(false);

                resets.Add(reset);

                ThreadPool.QueueUserWorkItem(x =>
                {
                    action(i);
                    reset.Set();
                });
            }

            foreach (var reset in resets)
            {
                reset.WaitOne();
            }
        }

        private static Random _random = new Random();

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Shuffle
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
        {
            lock (_random)
            {
                return source.OrderBy(x => _random.NextDouble());
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // TakeRandom
        ////////////////////////////////////////////////////////////////////////////////////////////////
        [DebuggerStepThrough]
        public static T TakeRandom<T>(this IEnumerable<T> source)
        {
            lock (_random)
            {
                return source.ElementAt(_random.Next(0, source.Count()));
            }
        }

        [DebuggerStepThrough]
        public static IEnumerable<T> TakeRandom<T>(this IEnumerable<T> source, int count)
        {
            lock (_random)
            {
                var sourceList = source.ToList();
                var dstList = new List<T>();

                var taken = 0;

                while (taken < count && sourceList.Count != 0)
                {
                    var item = sourceList.TakeRandom();
                    sourceList.Remove(item);
                    dstList.Add(item);
                    taken++;
                }
                // 
                return dstList;
            }
        }
    }
}
