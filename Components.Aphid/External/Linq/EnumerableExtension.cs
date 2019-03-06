using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
//using Set = System.Collections.Generic.IEnumerable;
using static System.Linq.Enumerable;


namespace Components
{
#if DBG_STEPTHROUGH
    [DebuggerStepThrough]
#endif
   public static class EnumerableExtension
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////
        // None
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static bool None<T>(this IEnumerable<T> source) =>
            !source.Any();

        public static bool None<T>(this IEnumerable<T> source, Func<T, bool> predicate) =>
            !source.Any(predicate);

        public static bool None<T>(this IEnumerable<T> source, T value) =>
            !source.Contains(value);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // All
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static bool All(this IEnumerable<bool> source) =>
            source.All(x => x);

        public static bool All<T>(this IEnumerable<T> source, T value) =>
            source.All(x => x.Equals(value));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Join
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<T> Join<T>(this IEnumerable<IEnumerable<T>> source) =>
            source.SelectMany(x => x);

        public static string Join<T>(this IEnumerable<string> source) =>
            source.Aggregate((x, y) => x + y);

        public static string Join<T>(this IEnumerable<string> source, string separator) =>
            source.Aggregate((x, y) => x + separator + y);

        public static IEnumerable<KeyValuePair<TInnerKey, TSource>>
            Join<TOuterKey, TInnerKey, TSource>(
            this IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source) =>
            source.SelectMany(x => x.Value);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // ToDictionary
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TKey, TElement> ToDictionary<TKey, TElement>(
            this IEnumerable<KeyValuePair<TKey, TElement>> source) =>
            source.ToDictionary(x => x.Key, x => x.Value);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GetOrAdd
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> d, TKey key)
            where TValue : new()
        {
            if (!d.TryGetValue(key, out var value))
            {
                d.Add(key, value = new TValue());
            }

            return value;
        }

        public static TValue GetOrAdd<TKey, TValue>(
            this Dictionary<TKey, TValue> d,
            TKey key,
            TValue defaultValue)
        {
            if (!d.TryGetValue(key, out var value))
            {
                d.Add(key, value = defaultValue);
            }

            return value;
        }

        public static TValue GetOrAdd<TKey, TValue>(
            this Dictionary<TKey, TValue> d,
            TKey key,
            Func<TValue> createDefaultValue)
        {
            if (!d.TryGetValue(key, out var value))
            {
                d.Add(key, value = createDefaultValue());
            }

            return value;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereDictionary
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TKey, TElement> WhereDictionary<TKey, TElement>(
            this IEnumerable<KeyValuePair<TKey, TElement>> source,
            Func<KeyValuePair<TKey, TElement>, bool> predicate) =>
            source.Where(predicate).ToDictionary();

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // JoinValues
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TElement> JoinValues<TKey, TElement>(
            this IEnumerable<Dictionary<TKey, TElement>> source) =>
            source.SelectMany(x => x.Values);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // JoinKeys
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TKey> JoinKeys<TKey, TElement>(
            this IEnumerable<Dictionary<TKey, TElement>> source) =>
            source.SelectMany(x => x.Keys);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // DistinctKeys
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TKey> DistinctKeys<TKey, TElement>(
            this IEnumerable<Dictionary<TKey, TElement>> source) =>
            source.SelectMany(x => x.Keys).Distinct();

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WithKey
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TResult, TElement> WithKey<TKey, TElement, TResult>(
            this Dictionary<TKey, TElement> source,
            Func<KeyValuePair<TKey, TElement>, TResult> keySelector) =>
            source.ToDictionary(keySelector, x => x.Value);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WithValue
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TKey, TResult> WithValue<TKey, TElement, TResult>(
            this Dictionary<TKey, TElement> source,
            Func<KeyValuePair<TKey, TElement>, TResult> elementSelector) =>
            source.ToDictionary(x => x.Key, elementSelector);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // AsKeyFor
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TKey, TElement> AsKeyFor<TKey, TElement>(
            this IEnumerable<TKey> source,
            Func<TKey, TElement> elementSelector) =>
            source.ToDictionary(x => x, elementSelector);

        public static Dictionary<TKey, TValue> AsKeyFor<TKey, TValue>(
            this IEnumerable<TKey> source,
            IEnumerable<TValue> second) =>
            source
                .Zip(second, (x, y) => new { Key = x, Value = y })
                .ToDictionary(x => x.Key, x => x.Value);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereAny
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<IEnumerable<TElement>> WhereAny<TElement>(
            this IEnumerable<IEnumerable<TElement>> source,
            Func<TElement, bool> predicate) =>
            source.Where(x => x.Any(predicate));

        public static IEnumerable<IEnumerable<TElement>> WhereAny<TElement>(
            this IEnumerable<IEnumerable<TElement>> source) =>
            source.Where(x => x.Any());

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereNone
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<IEnumerable<TElement>> WhereNone<TElement>(
            this IEnumerable<IEnumerable<TElement>> source,
            Func<TElement, bool> predicate) =>
            source.Where(x => x.None(predicate));

        public static IEnumerable<IEnumerable<TElement>> WhereNone<TElement>(
            this IEnumerable<IEnumerable<TElement>> source) =>
            source.Where(x => x.None());

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereValue
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TKey>
            WhereValue<TKey, TElement>(
                this Dictionary<TKey, TElement> source,
                Func<KeyValuePair<TKey, TElement>, bool> predicate) =>
            source.Where(predicate).Select(x => x.Key);

        public static IEnumerable<TKey>
            WhereValue<TKeyOuter, TKey, TElement>(
                this KeyValuePair<TKeyOuter, Dictionary<TKey, TElement>> source,
                Func<KeyValuePair<TKey, TElement>, bool> predicate) =>
            source.Value.WhereValue(predicate);

        public static Dictionary<TKeyOuter, IEnumerable<TKey>>
            WhereValue<TKeyOuter, TKey, TElement>(
                this Dictionary<TKeyOuter, Dictionary<TKey, TElement>> source,
                Func<KeyValuePair<TKey, TElement>, bool> predicate) =>
            source.WhereValue(predicate);

        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(
                this KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, TElement>>> source,
                Func<KeyValuePair<TKeyInner, TElement>, bool> predicate) =>
            source.Value.WithValue(x => x.Value.WhereValue(predicate));

        public static Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(
                this Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, TElement>>> source,
                Func<KeyValuePair<TKeyInner, TElement>, bool> predicate) =>
            source.WithValue(x => x.Value.WhereValue(predicate));

        public static IEnumerable<TKey>
            WhereValue<TKey>(
                this Dictionary<TKey, bool> source) =>
            source.Where(x => x.Value).Select(x => x.Key);

        public static IEnumerable<TKey>
            WhereValue<TKey, TKeyOuter>(
                this KeyValuePair<TKeyOuter, Dictionary<TKey, bool>> source) =>
            source.Value.WhereValue();

        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValue<TKeyInner, TKeyOuter>(
                this Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>> source) =>
            source.WithValue(x => x.Value.WhereValue());

        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2>(
                this KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source) =>
            source.Value.WithValue(x => x.Value.WhereValue());

        public static Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>>
            WhereValue<TKeyInner, TKeyOuter, TKeyOuter2>(
                this Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source) =>
            source.WithValue(x => x.Value.WhereValue());

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereValueNot
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TKey>
            WhereValueNot<TKey>(
                this Dictionary<TKey, bool> source) =>
            source.Where(x => !x.Value).Select(x => x.Key);

        public static IEnumerable<TKey>
            WhereValueNot<TKey, TKeyOuter>(
                this KeyValuePair<TKeyOuter, Dictionary<TKey, bool>> source) =>
            source.Value.WhereValueNot();

        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValueNot<TKeyInner, TKeyOuter>(
                this Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>> source) =>
            source.WithValue(x => x.Value.WhereValueNot());

        public static Dictionary<TKeyOuter, IEnumerable<TKeyInner>>
            WhereValueNot<TKeyInner, TKeyOuter, TKeyOuter2>(
                this KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source) =>
            source.Value.WithValue(x => x.Value.WhereValueNot());

        public static Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>>
            WhereValueNot<TKeyInner, TKeyOuter, TKeyOuter2>(
                this Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source) =>
            source.WithValue(x => x.Value.WhereValueNot());

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereValueAny
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TKey, IEnumerable<TElement>>
            WhereValueAny<TKey, TElement>(
                this Dictionary<TKey, IEnumerable<TElement>> source) =>
            source.WhereDictionary(x => x.Value.Any());

        public static Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>>
            WhereValueAny<TKey, TKeyOuter, TElement>(
                this Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>> source) =>
            source.WithValue(x => x.Value.WhereValueAny());

        public static Dictionary<TKey, IEnumerable<TElement>>
            WhereValueAny<TKey, TElement>(
                this Dictionary<TKey, IEnumerable<TElement>> source,
                Func<TElement, bool> predicate) =>
            source.WhereDictionary(x => x.Value.Any(predicate));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereMany
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TElement> WhereMany<TElement>(
            this IEnumerable<TElement> source,
            params Func<TElement, bool>[] predicate) =>
            source.Where(x => predicate.All(y => y(x)));

        public static IEnumerable<TElement> WhereMany<TElement>(
            this IEnumerable<TElement> source,
            params Func<TElement, int, bool>[] predicate) =>
            source.Where((x, i) => predicate.All(y => y(x, i)));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GroupJoin
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TInnerKey, IEnumerable<TSource>> GroupJoin<TOuterKey, TInnerKey, TSource>(
            this IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source) =>
            source.Join().GroupToDictionary();

        public static Dictionary<TInnerKey, TElement> GroupJoin<TOuterKey, TInnerKey, TSource, TElement>(
            this IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source,
            Func<IEnumerable<KeyValuePair<TInnerKey, TSource>>, TElement> elementSelector) =>
            source.Join().GroupToDictionary(x => x.Key, elementSelector);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GroupToDictionary
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static Dictionary<TKey, IEnumerable<TSource>> GroupToDictionary<TKey, TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector) =>
            source.GroupBy(keySelector).ToDictionary(x => x.Key, x => x.AsEnumerable());

        public static Dictionary<TKey, TElement> GroupToDictionary<TSource, TKey, TElement>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<IGrouping<TKey, TSource>, TElement> elementSelector) =>
            source.GroupBy(keySelector).ToDictionary(x => x.Key, elementSelector);

        public static Dictionary<TKey, IEnumerable<TSource>> GroupToDictionary<TKey, TSource>(
            this IEnumerable<KeyValuePair<TKey, TSource>> source) =>
            source.GroupBy(x => x.Key).ToDictionary(x => x.Key, x => x.Select(y => y.Value));

        public static Dictionary<TKey, TSource[]> GroupToArrayDictionary<TKey, TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector) =>
            source.GroupBy(keySelector).ToDictionary(x => x.Key, x => x.ToArray());

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // WhereContains
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<IEnumerable<TSource>> WhereContains<TSource>(
            this IEnumerable<IEnumerable<TSource>> source,
            TSource value) =>
            source.Where(x => x.Contains(value));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Except
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TSource> Except<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate) =>
            source.Where(x => !predicate(x));

        public static IEnumerable<TSource> ExceptNull<TSource>(this IEnumerable<TSource> source)
            where TSource : class =>
            source.Where(x => x != null);

        public static IEnumerable<TSource> ExceptNull<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
            where TResult : class =>
            source.Where(x => selector(x) != null);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // ExceptKey
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<KeyValuePair<TKey, TSource>> ExceptKey<TKey, TSource>(
            this IEnumerable<KeyValuePair<TKey, TSource>> source,
            Func<TKey, bool> predicate) =>
            source.Except(x => predicate(x.Key));

        public static IEnumerable<KeyValuePair<TKey, TSource>> ExceptKey<TKey, TSource>(
            this IEnumerable<KeyValuePair<TKey, TSource>> source,
            params TKey[] keys) =>
            source.Except(x => keys.Contains(x.Key));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Distinct
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TSource> Distinct<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector) =>
            source.Distinct(new SelectorComparer<TSource, TKey>(keySelector));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // GroupEvery
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<IEnumerable<T>> GroupEvery<T>(this IEnumerable<T> source, int groupSize) =>

                Range(0, (int)Math.Ceiling((double)source.Count() / groupSize))
                .Select(x => source.Skip(x * groupSize).Take(groupSize));

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // TakeLast
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<TSource> TakeLast<TSource>(this IEnumerable<TSource> source, int count) =>
            source.Skip(source.Count() - count);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Iter/ForEach/For
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public static IEnumerable<T> Iter<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }

            return source;
        }

        public static IEnumerable<T> Iter<T>(this IEnumerable<T> source, Action<T, int> action)
        {
            var i = 0;

            foreach (var item in source)
            {
                action(item, i++);
            }

            return source;
        }

        public static IEnumerable<T> For<T>(this IEnumerable<T> source, Action<T> action) =>
            source.Iter(action);

        public static IEnumerable<T> For<T>(this IEnumerable<T> source, Action<T, int> action) =>
            source.Iter(action);

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action) =>
            source.Iter(action);

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T, int> action) =>
            source.Iter(action);

        public static IEnumerable<T> Each<T>(this IEnumerable<T> source, Action<T> action) =>
            source.Iter(action);

        public static IEnumerable<T> Each<T>(this IEnumerable<T> source, Action<T, int> action) =>
            source.Iter(action);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // AsyncIter
        ////////////////////////////////////////////////////////////////////////////////////////////////
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

        private static readonly Random _random = new Random();

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Shuffle
        ////////////////////////////////////////////////////////////////////////////////////////////////
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
        public static T TakeRandom<T>(this IEnumerable<T> source)
        {
            lock (_random)
            {
                return source.ElementAt(_random.Next(0, source.Count()));
            }
        }

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

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Then/Do
        ////////////////////////////////////////////////////////////////////////////////////////////////
        //public static IEnumerable<TSource> Then<TSource>(
        //    this IEnumerable<TSource> source,
        //    SetAction<TSource> action)
        //{
        //    action(source);

        //    return source;
        //}

        //public delegate void SetAction<in T>(IEnumerable<T> collection);

        //public static IEnumerable<TSource> Do<TSource>(
        //    this IEnumerable<TSource> source,
        //    SetAction<TSource> action) =>
        //    source.Then(action);
    }
}
