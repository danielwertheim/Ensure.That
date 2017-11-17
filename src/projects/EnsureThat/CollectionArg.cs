using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class CollectionArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public T HasItems<T>([ValidatedNotNull]T value, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public ICollection<T> HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IReadOnlyList<T> HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public ISet<T> HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T[] HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IList<T> HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T[] SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Length),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T[] SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

#if NETSTANDARD1_1
            if (value.Length != expected)
#else
            if (value.LongLength != expected)
#endif
            throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Length),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public ICollection<T> SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IList<T> SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IList<T> SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (!value.ContainsKey(expectedKey))
                throw new ArgumentException(
                    ExceptionMessages.Collections_ContainsKey_Failed.Inject(expectedKey),
                    paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public IList<T> HasAny<T>([ValidatedNotNull]IList<T> value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public ICollection<T> HasAny<T>([ValidatedNotNull]ICollection<T> value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T[] HasAny<T>([ValidatedNotNull]T[] value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }
    }
}