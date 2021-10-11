namespace EnsureThat
{
    public static class EnsureThatComparableDecimalExtensions
    {
        public static Param<decimal> Is(this in Param<decimal> param, decimal expected)
        {
            Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

            return param;
        }

        public static Param<decimal> IsNot(this in Param<decimal> param, decimal expected)
        {
            Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

            return param;
        }

        public static Param<decimal> IsLt(this in Param<decimal> param, decimal limit)
        {
            Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

            return param;
        }

        public static Param<decimal> IsLte(this in Param<decimal> param, decimal limit)
        {
            Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

            return param;
        }

        public static Param<decimal> IsGt(this in Param<decimal> param, decimal limit)
        {
            Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

            return param;
        }

        public static Param<decimal> IsGte(this in Param<decimal> param, decimal limit)
        {
            Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

            return param;
        }

        public static Param<decimal> IsInRange(this in Param<decimal> param, decimal min, decimal max)
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);

            return param;
        }
    }
}
