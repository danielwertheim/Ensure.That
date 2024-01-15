using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T HasItems<T>([ValidatedNotNull, NotNull] T value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class, ICollection
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasItems<T>([ValidatedNotNull, NotNull]ICollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyCollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ISet<T> HasItems<T>([ValidatedNotNull, NotNull]ISet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasItems<T>([ValidatedNotNull, NotNull]T[] value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasItems<T>([ValidatedNotNull, NotNull] IList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasItems(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull, NotNull]T value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull, NotNull]T value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull, NotNull] IList<T> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull, NotNull]IList<T> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasAny<T>([ValidatedNotNull, NotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasAny<T>([ValidatedNotNull, NotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasAny<T>([ValidatedNotNull, NotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Collection.HasAny(value, predicate, paramName);
    }
}
