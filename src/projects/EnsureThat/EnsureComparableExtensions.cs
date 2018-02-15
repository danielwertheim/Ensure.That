using System;
using System.Collections.Generic;

namespace EnsureThat
{
    public static class EnsureComparableExtensions
    {
        public static void Is<T>(this Param<T> param, T expected) where T : IComparable<T>
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void Is<T>(this Param<T> param, T expected, IComparer<T> comparer)
            => Ensure.Comparable.Is(param.Value, expected, comparer, param.Name, param.OptsFn);

        public static void IsNot<T>(this Param<T> param, T expected) where T : IComparable<T>
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot<T>(this Param<T> param, T expected, IComparer<T> comparer)
            => Ensure.Comparable.IsNot(param.Value, expected, comparer, param.Name, param.OptsFn);

        public static void IsLt<T>(this Param<T> param, T limit) where T : IComparable<T>
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLt<T>(this Param<T> param, T limit, IComparer<T> comparer)
            => Ensure.Comparable.IsLt(param.Value, limit, comparer, param.Name, param.OptsFn);

        public static void IsLte<T>(this Param<T> param, T limit) where T : IComparable<T>
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte<T>(this Param<T> param, T limit, IComparer<T> comparer)
            => Ensure.Comparable.IsLte(param.Value, limit, comparer, param.Name, param.OptsFn);

        public static void IsGt<T>(this Param<T> param, T limit) where T : IComparable<T>
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt<T>(this Param<T> param, T limit, IComparer<T> comparer)
            => Ensure.Comparable.IsGt(param.Value, limit, comparer, param.Name, param.OptsFn);

        public static void IsGte<T>(this Param<T> param, T limit) where T : IComparable<T>
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte<T>(this Param<T> param, T limit, IComparer<T> comparer)
            => Ensure.Comparable.IsGte(param.Value, limit, comparer, param.Name, param.OptsFn);

        public static void IsInRange<T>(this Param<T> param, T min, T max) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);

        public static void IsInRange<T>(this Param<T> param, T min, T max, IComparer<T> comparer)
            => Ensure.Comparable.IsInRange(param.Value, min, max, comparer, param.Name, param.OptsFn);
    }
}