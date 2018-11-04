﻿namespace EnsureThat
{
    public static class EnsureThatComparableDoubleExtensions
    {
        public static void Is(this Param<double> param, double expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this Param<double> param, double expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this Param<double> param, double limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this Param<double> param, double limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this Param<double> param, double limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this Param<double> param, double limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this Param<double> param, double min, double max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);
    }
}