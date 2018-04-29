namespace EnsureThat
{
    public static class EnsureThatComparableIntExtensions
    {
        public static void Is(this Param<int> param, int expected)
            => Ensure.Comparable.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNot(this Param<int> param, int expected)
            => Ensure.Comparable.IsNot(param.Value, expected, param.Name, param.OptsFn);

        public static void IsLt(this Param<int> param, int limit)
            => Ensure.Comparable.IsLt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsLte(this Param<int> param, int limit)
            => Ensure.Comparable.IsLte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGt(this Param<int> param, int limit)
            => Ensure.Comparable.IsGt(param.Value, limit, param.Name, param.OptsFn);

        public static void IsGte(this Param<int> param, int limit)
            => Ensure.Comparable.IsGte(param.Value, limit, param.Name, param.OptsFn);

        public static void IsInRange(this Param<int> param, int min, int max)
            => Ensure.Comparable.IsInRange(param.Value, min, max, param.Name, param.OptsFn);
    }
}