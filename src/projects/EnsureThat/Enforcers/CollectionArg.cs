using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class CollectionArg
    {
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T HasItems<T>([ValidatedNotNull]T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IReadOnlyList<T> HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ISet<T> HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public Collection<T> HasItems<T>([ValidatedNotNull] Collection<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public List<T> HasItems<T>([ValidatedNotNull] List<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public HashSet<T> HasItems<T>([ValidatedNotNull] HashSet<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public Dictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]Dictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NETSTANDARD1_1
            if (value.Length != expected)
#else
            if (value.LongLength != expected)
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.ContainsKey(expectedKey))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Collections_ContainsKey_Failed, expectedKey),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> HasAny<T>([ValidatedNotNull]IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> HasAny<T>([ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] HasAny<T>([ValidatedNotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }
    }
}