using System;

namespace EnsureThat
{
    public static class EnsureThatComparableDateTimeExtensions
    {
        public static Param<DateTime> Is(this in Param<DateTime> param, DateTime expected)
        {
            Ensure.Comparable.Is(param.Value, expected, param.Name);

            return param;
        }

        public static Param<DateTime> IsNot(this in Param<DateTime> param, DateTime expected)
        {
            Ensure.Comparable.IsNot(param.Value, expected, param.Name);

            return param;
        }

        public static Param<DateTime> IsLt(this in Param<DateTime> param, DateTime limit)
        {
            Ensure.Comparable.IsLt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<DateTime> IsLte(this in Param<DateTime> param, DateTime limit)
        {
            Ensure.Comparable.IsLte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<DateTime> IsGt(this in Param<DateTime> param, DateTime limit)
        {
            Ensure.Comparable.IsGt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<DateTime> IsGte(this in Param<DateTime> param, DateTime limit)
        {
            Ensure.Comparable.IsGte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<DateTime> IsInRange(this in Param<DateTime> param, DateTime min, DateTime max)
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, param.Name);

            return param;
        }
    }
}
