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
        [DebuggerStepThrough]
        public T HasItems<T>([NotNull, ValidatedNotNull]T value, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
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

        [DebuggerStepThrough]
        public ICollection<T> HasItems<T>([NotNull, ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IReadOnlyCollection<T> HasItems<T>([NotNull, ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IReadOnlyList<T> HasItems<T>([NotNull, ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public ISet<T> HasItems<T>([NotNull, ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public T[] HasItems<T>([NotNull, ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IList<T> HasItems<T>([NotNull, ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> HasItems<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public T[] SizeIs<T>([NotNull, ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public T[] SizeIs<T>([NotNull, ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public T SizeIs<T>([NotNull, ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
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

        [DebuggerStepThrough]
        public T SizeIs<T>([NotNull, ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
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

        [DebuggerStepThrough]
        public ICollection<T> SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public ICollection<T> SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IList<T> SizeIs<T>([NotNull, ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IList<T> SizeIs<T>([NotNull, ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public IList<T> HasAny<T>([NotNull, ValidatedNotNull]IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public ICollection<T> HasAny<T>([NotNull, ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public T[] HasAny<T>([NotNull, ValidatedNotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
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