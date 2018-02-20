using System;
using System.Collections;
using System.Collections.Generic;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface ICollectionArg
    {
        T HasItems<T>([ValidatedNotNull]T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : ICollection;
        ICollection<T> HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IReadOnlyList<T> HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        ISet<T> HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        T[] HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IList<T> HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        T[] SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        T[] SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        T SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : ICollection;
        T SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : ICollection;
        ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IList<T> SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IList<T> SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        IList<T> HasAny<T>([ValidatedNotNull]IList<T> value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        ICollection<T> HasAny<T>([ValidatedNotNull]ICollection<T> value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        T[] HasAny<T>([ValidatedNotNull]T[] value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
    }
}