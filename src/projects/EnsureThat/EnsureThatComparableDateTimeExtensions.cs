using System;

namespace EnsureThat
{
    public static class EnsureThatComparableDateTimeExtensions
    {
        public static void Is(this Param<DateTime> param, DateTime expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this Param<DateTime> param, DateTime expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this Param<DateTime> param, DateTime limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this Param<DateTime> param, DateTime limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this Param<DateTime> param, DateTime limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this Param<DateTime> param, DateTime limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this Param<DateTime> param, DateTime min, DateTime max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);
    }
}