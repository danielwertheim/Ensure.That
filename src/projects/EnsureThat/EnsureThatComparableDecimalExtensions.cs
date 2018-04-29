namespace EnsureThat
{
    public static class EnsureThatComparableDecimalExtensions
    {
        public static void Is(this Param<decimal> param, decimal expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this Param<decimal> param, decimal expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this Param<decimal> param, decimal min, decimal max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);
    }
}