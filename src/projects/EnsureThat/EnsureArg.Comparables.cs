using System;
using System.Diagnostics;

namespace EnsureThat
{
    using System.Collections.Generic;

    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T Is<T>(T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.Is(value, expected, paramName);

        [DebuggerStepThrough]
        public static T Is<T>(T value, T expected, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.Is(value, expected, comparer, paramName);

        [DebuggerStepThrough]
        public static T IsNot<T>(T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsNot(value, expected, paramName);

        [DebuggerStepThrough]
        public static T IsNot<T>(T value, T expected, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.IsNot(value, expected, comparer, paramName);

        [DebuggerStepThrough]
        public static T IsLt<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLt(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsLt<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.IsLt(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static T IsLte<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLte(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsLte<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.IsLte(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static T IsGt<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGt(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsGt<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.IsGt(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static T IsGte<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGte(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsGte<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.IsGte(value, limit, comparer, paramName);

        [DebuggerStepThrough]
        public static T IsInRange<T>(T value, T min, T max, string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(value, min, max, paramName);

        [DebuggerStepThrough]
        public static T IsInRange<T>(T value, T min, T max, IComparer<T> comparer, string paramName = Param.DefaultName)
            => Ensure.Comparable.IsInRange(value, min, max, comparer, paramName);
    }
}
