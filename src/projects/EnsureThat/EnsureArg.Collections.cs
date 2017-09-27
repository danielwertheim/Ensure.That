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
        public static void HasItems<T>([NotNull, ValidatedNotNull]T value, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>([NotNull, ValidatedNotNull]ICollection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>([NotNull, ValidatedNotNull]T[] value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Length < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>([NotNull, ValidatedNotNull]IList<T> value, string paramName = Param.DefaultName)
            => HasItems(value as ICollection<T>, paramName);

        [DebuggerStepThrough]
        public static void HasItems<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]T[] value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Length),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]T[] value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Length),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]T value, int expected, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]T value, long expected, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]IList<T> value, int expected, string paramName = Param.DefaultName)
            => SizeIs(value as ICollection<T>, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([NotNull, ValidatedNotNull]IList<T> value, long expected, string paramName = Param.DefaultName)
            => SizeIs(value as ICollection<T>, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void ContainsKey<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (!value.ContainsKey(expectedKey))
                throw new ArgumentException(
                    ExceptionMessages.Collections_ContainsKey_Failed.Inject(expectedKey),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>([NotNull, ValidatedNotNull]IList<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName) => Any(value as ICollection<T>, predicate, paramName);

        [DebuggerStepThrough]
        public static void Any<T>([NotNull, ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>([NotNull, ValidatedNotNull]T[] value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.Collections_Any_Failed, paramName);
        }
    }
}