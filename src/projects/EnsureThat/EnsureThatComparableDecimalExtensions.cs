namespace EnsureThat
{
    public static class EnsureThatComparableDecimalExtensions
    {
        public static void Is(this in Param<decimal> param, decimal expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this in Param<decimal> param, decimal expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this in Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this in Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this in Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this in Param<decimal> param, decimal limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this in Param<decimal> param, decimal min, decimal max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);

        public static void IsPositive(this Param<decimal> param, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither)
            => Ensure.Comparable.IsPositive(param.Value, zeroSignMode, param.Name, param.OptsFn);

        public static void IsNegative(this Param<decimal> param, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither)
            => Ensure.Comparable.IsNegative(param.Value, zeroSignMode, param.Name, param.OptsFn);

        public static void IsNotNegative(this Param<decimal> param, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither)
            => Ensure.Comparable.IsNotNegative(param.Value, zeroSignMode, param.Name, param.OptsFn);

        public static void IsApproximately(this Param<decimal> param, decimal target, decimal accuracy)
            => Ensure.Comparable.IsApproximately(param.Value, target, accuracy, param.Name, param.OptsFn);
    }
}