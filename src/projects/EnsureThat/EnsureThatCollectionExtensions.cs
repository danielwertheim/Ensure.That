using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EnsureThat
{
    public static class EnsureThatCollectionExtensions
    {
        public static void HasItems<T>(this Param<T> param) where T : class, ICollection
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<Collection<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<ICollection<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<T[]> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<List<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<IList<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<HashSet<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<ISet<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<TKey, TValue>(this Param<Dictionary<TKey, TValue>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<IReadOnlyCollection<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void HasItems<T>(this Param<IReadOnlyList<T>> param)
            => Ensure.Collection.HasItems(param.Value, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<T[]> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<T[]> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<T> param, int expected) where T : class, ICollection
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<T> param, long expected) where T : class, ICollection
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<ICollection<T>> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<ICollection<T>> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<IList<T>> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<T>(this Param<IList<T>> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param, int expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void SizeIs<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param, long expected)
            => Ensure.Collection.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void ContainsKey<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param, TKey key)
            => Ensure.Collection.ContainsKey(param.Value, key, param.Name, param.OptsFn);

        public static void ContainsKey<TKey, TValue>(this Param<Dictionary<TKey, TValue>> param, TKey key)
            => Ensure.Collection.ContainsKey(param.Value, key, param.Name, param.OptsFn);

        public static void HasAny<T>(this Param<IList<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this Param<List<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this Param<ICollection<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this Param<Collection<T>> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<TKey, TValue>(this Param<IDictionary<TKey, TValue>> param, Func<KeyValuePair<TKey, TValue>, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<TKey, TValue>(this Param<Dictionary<TKey, TValue>> param, Func<KeyValuePair<TKey, TValue>, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);

        public static void HasAny<T>(this Param<T[]> param, Func<T, bool> predicate)
            => Ensure.Collection.HasAny(param.Value, predicate, param.Name, param.OptsFn);
    }
}