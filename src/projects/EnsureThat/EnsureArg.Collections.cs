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
        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull] T value, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull]ICollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull]ISet<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull]T[] value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<T>([ValidatedNotNull] IList<T> value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void HasItems<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]T[] value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]T[] value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]T value, int expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]T value, long expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<T>([ValidatedNotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void SizeIs<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void ContainsKey<TKey, TValue>([ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName);

        [DebuggerStepThrough]
        public static void Any<T>([ValidatedNotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [DebuggerStepThrough]
        public static void Any<T>([ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [DebuggerStepThrough]
        public static void Any<T>([ValidatedNotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Collection.HasAny(value, predicate, paramName);
    }
}