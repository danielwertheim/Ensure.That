using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EnsureThat
{
    public static class EnsureThatCollectionExtensions
    {
        public static Param<T> HasItems<T>(this in Param<T> param) where T : class, ICollection
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<Collection<T>> HasItems<T>(this in Param<Collection<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<ICollection<T>> HasItems<T>(this in Param<ICollection<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<T[]> HasItems<T>(this in Param<T[]> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<List<T>> HasItems<T>(this in Param<List<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<IList<T>> HasItems<T>(this in Param<IList<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<HashSet<T>> HasItems<T>(this in Param<HashSet<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<ISet<T>> HasItems<T>(this in Param<ISet<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<Dictionary<TKey, TValue>> HasItems<TKey, TValue>(this in Param<Dictionary<TKey, TValue>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<IDictionary<TKey, TValue>> HasItems<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<IReadOnlyCollection<T>> HasItems<T>(this in Param<IReadOnlyCollection<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<IReadOnlyList<T>> HasItems<T>(this in Param<IReadOnlyList<T>> param)
        {
            Ensure.Collection.HasItems(param.Value, param.Name);

            return param;
        }

        public static Param<T[]> SizeIs<T>(this in Param<T[]> param, int expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<T[]> SizeIs<T>(this in Param<T[]> param, long expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<T> SizeIs<T>(this in Param<T> param, int expected) where T : class, ICollection
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<T> SizeIs<T>(this in Param<T> param, long expected) where T : class, ICollection
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<ICollection<T>> SizeIs<T>(this in Param<ICollection<T>> param, int expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<ICollection<T>> SizeIs<T>(this in Param<ICollection<T>> param, long expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<IList<T>> SizeIs<T>(this in Param<IList<T>> param, int expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<IList<T>> SizeIs<T>(this in Param<IList<T>> param, long expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<IDictionary<TKey, TValue>> SizeIs<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, int expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<IDictionary<TKey, TValue>> SizeIs<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, long expected)
        {
            Ensure.Collection.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static Param<IDictionary<TKey, TValue>> ContainsKey<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, TKey key)
        {
            Ensure.Collection.ContainsKey(param.Value, key, param.Name);

            return param;
        }

        public static Param<Dictionary<TKey, TValue>> ContainsKey<TKey, TValue>(this in Param<Dictionary<TKey, TValue>> param, TKey key)
        {
            Ensure.Collection.ContainsKey(param.Value, key, param.Name);

            return param;
        }

        public static Param<IList<T>> HasAny<T>(this in Param<IList<T>> param, Func<T, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }

        public static Param<List<T>> HasAny<T>(this in Param<List<T>> param, Func<T, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }

        public static Param<ICollection<T>> HasAny<T>(this in Param<ICollection<T>> param, Func<T, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }

        public static Param<Collection<T>> HasAny<T>(this in Param<Collection<T>> param, Func<T, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }

        public static Param<IDictionary<TKey, TValue>> HasAny<TKey, TValue>(this in Param<IDictionary<TKey, TValue>> param, Func<KeyValuePair<TKey, TValue>, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }

        public static Param<Dictionary<TKey, TValue>> HasAny<TKey, TValue>(this in Param<Dictionary<TKey, TValue>> param, Func<KeyValuePair<TKey, TValue>, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }

        public static Param<T[]> HasAny<T>(this in Param<T[]> param, Func<T, bool> predicate)
        {
            Ensure.Collection.HasAny(param.Value, predicate, param.Name);

            return param;
        }
    }
}
