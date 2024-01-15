using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static T Is<T>(T value, T expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.Is(value, expected, paramName);

        public static T Is<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.Is(value, expected, comparer, paramName);

        public static T IsNot<T>(T value, T expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsNot(value, expected, paramName);

        public static T IsNot<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsNot(value, expected, comparer, paramName);

        public static T IsLt<T>(T value, T limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsLt(value, limit, paramName);

        public static T IsLt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsLt(value, limit, comparer, paramName);

        public static T IsLte<T>(T value, T limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsLte(value, limit, paramName);

        public static T IsLte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsLte(value, limit, comparer, paramName);

        public static T IsGt<T>(T value, T limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsGt(value, limit, paramName);

        public static T IsGt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsGt(value, limit, comparer, paramName);

        public static T IsGte<T>(T value, T limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsGte(value, limit, paramName);

        public static T IsGte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsGte(value, limit, comparer, paramName);

        public static T IsInRange<T>(T value, T min, T max, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(value, min, max, paramName);

        public static T IsInRange<T>(T value, T min, T max, [NotNull] IComparer<T> comparer, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(value, min, max, comparer, paramName);
    }
}
