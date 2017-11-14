using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public static T Is<T>([NotNull] T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.Is(value, expected, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsNot<T>([NotNull] T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsNot(value, expected, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsLt<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLt(value, limit, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsLte<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLte(value, limit, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsGt<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGt(value, limit, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsGte<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGte(value, limit, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsInRange<T>([NotNull] T value, T min, T max, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}
