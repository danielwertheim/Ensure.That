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
        public static T HasItems<T>([NotNull, ValidatedNotNull] T value, string paramName = Param.DefaultName) where T : ICollection
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static ICollection<T> HasItems<T>([NotNull, ValidatedNotNull]ICollection<T> value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static IReadOnlyCollection<T> HasItems<T>([NotNull, ValidatedNotNull]IReadOnlyCollection<T> value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static IReadOnlyList<T> HasItems<T>([NotNull, ValidatedNotNull]IReadOnlyList<T> value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static ISet<T> HasItems<T>([NotNull, ValidatedNotNull]ISet<T> value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static T[] HasItems<T>([NotNull, ValidatedNotNull]T[] value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static IList<T> HasItems<T>([NotNull, ValidatedNotNull] IList<T> value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, string paramName = Param.DefaultName)
            => Ensure.Collection.HasItems(value, paramName);

        [DebuggerStepThrough]
        public static T[] SizeIs<T>([NotNull, ValidatedNotNull]T[] value, int expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static T[] SizeIs<T>([NotNull, ValidatedNotNull]T[] value, long expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static T SizeIs<T>([NotNull, ValidatedNotNull]T value, int expected, string paramName = Param.DefaultName) where T : ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static T SizeIs<T>([NotNull, ValidatedNotNull]T value, long expected, string paramName = Param.DefaultName) where T : ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static ICollection<T> SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, int expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static ICollection<T> SizeIs<T>([NotNull, ValidatedNotNull]ICollection<T> value, long expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static IList<T> SizeIs<T>([NotNull, ValidatedNotNull] IList<T> value, int expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static IList<T> SizeIs<T>([NotNull, ValidatedNotNull]IList<T> value, long expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, int expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, long expected, string paramName = Param.DefaultName)
            => Ensure.Collection.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([NotNull, ValidatedNotNull]IDictionary<TKey, TValue> value, TKey expectedKey, string paramName = Param.DefaultName)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName);

        [DebuggerStepThrough]
        public static IList<T> Any<T>([NotNull, ValidatedNotNull] IList<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [DebuggerStepThrough]
        public static ICollection<T> Any<T>([NotNull, ValidatedNotNull]ICollection<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [DebuggerStepThrough]
        public static T[] Any<T>([NotNull, ValidatedNotNull]T[] value, Func<T, bool> predicate, string paramName = Param.DefaultName)
            => Ensure.Collection.HasAny(value, predicate, paramName);

        [DebuggerStepThrough]
        public static T Any<T, TItem>([NotNull, ValidatedNotNull]T value, Func<TItem, bool> predicate, string paramName = Param.DefaultName) where T : ICollection<TItem>
            => Ensure.Collection.HasAny(value, predicate, paramName);
    }
}