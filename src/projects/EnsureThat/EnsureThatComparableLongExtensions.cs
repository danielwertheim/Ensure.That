namespace EnsureThat
{
    public static class EnsureThatComparableLongExtensions
    {
        public static void Is(this in Param<long> param, long expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this in Param<long> param, long expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this in Param<long> param, long limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this in Param<long> param, long limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this in Param<long> param, long limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this in Param<long> param, long limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this in Param<long> param, long min, long max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);

        public static void IsPositive(this Param<long> param)
            => Ensure.Comparable.IsPositive(param.Value, param.Name, param.OptsFn);

        public static void IsNegative(this Param<long> param)
            => Ensure.Comparable.IsNegative(param.Value, param.Name, param.OptsFn);

        public static void IsNotNegative(this Param<long> param)
            => Ensure.Comparable.IsNotNegative(param.Value, param.Name, param.OptsFn);

        public static void IsApproximately(this Param<long> param, long target, long accuracy)
            => Ensure.Comparable.IsApproximately(param.Value, target, accuracy, param.Name, param.OptsFn);
    }
}