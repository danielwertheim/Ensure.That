using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using EnsureThat.Extensions;
using System.Linq;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void HasItems<T>(T value, string paramName = Param.DefaultName) where T : class, ICollection
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(Collection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(ICollection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(T[] value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Length < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(List<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(IList<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<TKey, TValue>(IDictionary<TKey, TValue> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>(T[] value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, value.Length),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>(T[] value, long expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (value.Length != expected)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, value.Length),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>(T value, int expected, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return;

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs<T>(T value, long expected, string paramName = Param.DefaultName) where T : ICollection
        {
            if (!Ensure.IsActive)
                return;

            if (value.Count != expected)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, value.Count),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void ContainsKey<TKey, TValue>(IDictionary<TKey, TValue> value, TKey expectedKey, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.ContainsKey(expectedKey))
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_ContainsKey.Inject(expectedKey),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void ContainsKey<TKey, TValue>(Dictionary<TKey, TValue> value, TKey expectedKey, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.ContainsKey(expectedKey))
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_ContainsKey.Inject(expectedKey),
                    paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>(IList<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone, paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>(List<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone, paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>(ICollection<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone, paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>(Collection<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone, paramName);
        }

        [DebuggerStepThrough]
        public static void Any<T>(T[] value, Func<T, bool> predicate, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value.Any(predicate))
                throw new ArgumentException(ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone, paramName);
        }
    }
}