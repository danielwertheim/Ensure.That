using System;
using System.Collections.Generic;

namespace EnsureThat
{
    public static class EnsureThatComparableExtensions
    {
        public static Param<T> Is<T>(this in Param<T> param, T expected) where T : IComparable<T>
        {
            Ensure.Comparable.Is(param.Value, expected, param.Name);

            return param;
        }

        public static Param<T> Is<T>(this in Param<T> param, T expected, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.Is(param.Value, expected, comparer, param.Name);

            return param;
        }

        public static Param<T> IsNot<T>(this in Param<T> param, T expected) where T : IComparable<T>
        {
            Ensure.Comparable.IsNot(param.Value, expected, param.Name);

            return param;
        }

        public static Param<T> IsNot<T>(this in Param<T> param, T expected, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.IsNot(param.Value, expected, comparer, param.Name);

            return param;
        }

        public static Param<T> IsLt<T>(this in Param<T> param, T limit) where T : IComparable<T>
        {
            Ensure.Comparable.IsLt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<T> IsLt<T>(this in Param<T> param, T limit, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.IsLt(param.Value, limit, comparer, param.Name);

            return param;
        }

        public static Param<T> IsLte<T>(this in Param<T> param, T limit) where T : IComparable<T>
        {
            Ensure.Comparable.IsLte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<T> IsLte<T>(this in Param<T> param, T limit, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.IsLte(param.Value, limit, comparer, param.Name);

            return param;
        }

        public static Param<T> IsGt<T>(this in Param<T> param, T limit) where T : IComparable<T>
        {
            Ensure.Comparable.IsGt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<T> IsGt<T>(this in Param<T> param, T limit, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.IsGt(param.Value, limit, comparer, param.Name);

            return param;
        }

        public static Param<T> IsGte<T>(this in Param<T> param, T limit) where T : IComparable<T>
        {
            Ensure.Comparable.IsGte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<T> IsGte<T>(this in Param<T> param, T limit, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.IsGte(param.Value, limit, comparer, param.Name);

            return param;
        }

        public static Param<T> IsInRange<T>(this in Param<T> param, T min, T max) where T : IComparable<T>
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, param.Name);

            return param;
        }

        public static Param<T> IsInRange<T>(this in Param<T> param, T min, T max, IComparer<T> comparer) where T : IComparable<T>
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, comparer, param.Name);

            return param;
        }
    }
}
