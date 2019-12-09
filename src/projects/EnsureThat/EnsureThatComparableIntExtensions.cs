namespace EnsureThat
{
    public static class EnsureThatComparableIntExtensions
    {
        public static void Is(this in Param<int> param, int expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this in Param<int> param, int expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this in Param<int> param, int limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this in Param<int> param, int limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this in Param<int> param, int limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this in Param<int> param, int limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this in Param<int> param, int min, int max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);

        public static void IsPositive(this Param<int> param)
            => Ensure.Comparable.IsPositive(param.Value, param.Name, param.OptsFn);

        public static void IsNegative(this Param<int> param)
            => Ensure.Comparable.IsNegative(param.Value, param.Name, param.OptsFn);

        public static void IsNotNegative(this Param<int> param)
            => Ensure.Comparable.IsNotNegative(param.Value, param.Name, param.OptsFn);

        public static void IsApproximately(this Param<int> param, int target, int accuracy)
            => Ensure.Comparable.IsApproximately(param.Value, target, accuracy, param.Name, param.OptsFn);
    }
}