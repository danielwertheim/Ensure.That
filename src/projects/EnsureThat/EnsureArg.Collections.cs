using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using EnsureThat.Extensions;
using System.Linq;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T HasItems<T>([NotNull, ValidatedNotNull]T value, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static ICollection<T> HasItems<T>([NotNull, ValidatedNotNull]ICollection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IReadOnlyCollection<T> HasItems<T>([NotNull, ValidatedNotNull]IReadOnlyCollection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static ISet<T> HasItems<T>([NotNull, ValidatedNotNull]ISet<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T[] HasItems<T>([NotNull, ValidatedNotNull]T[] value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Length < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IList<T> HasItems<T>([NotNull, ValidatedNotNull] IList<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T[] SizeIs<T>([NotNull, ValidatedNotNull]T[] value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Length),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T[] SizeIs<T>([NotNull, ValidatedNotNull]T[] value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Length),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T SizeIs<T>([NotNull, ValidatedNotNull]T value, int expected, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T SizeIs<T>([NotNull, ValidatedNotNull]T value, long expected, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static ICollection<T> SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static ICollection<T> SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IList<T> SizeIs<T>([NotNull, ValidatedNotNull] IList<T> value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IList<T> SizeIs<T>([NotNull, ValidatedNotNull]IList<T> value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (!value.ContainsKey(expectedKey))
                throw new ArgumentException(
                    ExceptionMessages.Collections_ContainsKey_Failed.Inject(expectedKey),
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static IList<T> Any<T>([NotNull, ValidatedNotNull]IList<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static ICollection<T> Any<T>([NotNull, ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T[] Any<T>([NotNull, ValidatedNotNull]T[] value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);

            return value;
        }
    }
}