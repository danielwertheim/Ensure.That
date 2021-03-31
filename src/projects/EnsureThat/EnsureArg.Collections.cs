using System;
using System.Collections;
using System.Collections.Generic;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T HasItems<T>([ValidatedNotNull, NotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasItems<T>([ValidatedNotNull, NotNull]ICollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ISet<T> HasItems<T>([ValidatedNotNull, NotNull]ISet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasItems<T>([ValidatedNotNull, NotNull]T[] value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasItems<T>([ValidatedNotNull, NotNull] IList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull, NotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull, NotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull, NotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull, NotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasAny<T>([ValidatedNotNull, NotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasAny<T>([ValidatedNotNull, NotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasAny<T>([ValidatedNotNull, NotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);
    }
}
