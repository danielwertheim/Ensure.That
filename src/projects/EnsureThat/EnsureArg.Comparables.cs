using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void Is<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.Is(value, expected, paramName);

        [DebuggerStepThrough]
        public static void Is<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.Is(value, expected, comparer, paramName);

        [DebuggerStepThrough]
        public static void IsNot<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsNot(value, expected, paramName);

        [DebuggerStepThrough]
        public static void IsNot<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.IsNot(value, expected, comparer, paramName);

        [DebuggerStepThrough]
        public static void IsLt<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLt(value, limit, paramName);

        [DebuggerStepThrough]
        public static void IsLt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.IsLt(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static void IsLte<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLte(value, limit, paramName);

        [DebuggerStepThrough]
        public static void IsLte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.IsLte(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static void IsGt<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGt(value, limit, paramName);

        [DebuggerStepThrough]
        public static void IsGt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.IsGt(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static void IsGte<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGte(value, limit, paramName);

        [DebuggerStepThrough]
        public static void IsGte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.IsGte(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static void IsInRange<T>([NotNull] T value, T min, T max, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(value, min, max, paramName);

        [DebuggerStepThrough]
        public static void IsInRange<T>(T value, T min, T max, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Comparable.IsInRange(value, min, max, comparer, paramName);
    }
}
