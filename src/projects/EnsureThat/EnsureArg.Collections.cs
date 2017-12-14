using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        public static T HasItems<T>([ValidatedNotNull] T value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : ICollection
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static ICollection<T> HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static IReadOnlyList<T> HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static ISet<T> HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static T[] HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static IList<T> HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [NotNull]
        public static T[] SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static T[] SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static T SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static T SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static IList<T> SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static IList<T> SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [NotNull]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName, optsFn);

        [NotNull]
        public static IList<T> Any<T>([ValidatedNotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [NotNull]
        public static ICollection<T> Any<T>([ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [NotNull]
        public static T[] Any<T>([ValidatedNotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);
    }
}