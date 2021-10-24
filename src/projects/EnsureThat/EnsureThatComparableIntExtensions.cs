namespace EnsureThat
{
    public static class EnsureThatComparableIntExtensions
    {
        public static Param<int> Is(this in Param<int> param, int expected)
        {
            Ensure.Comparable.Is(param.Value, expected, param.Name);

            return param;
        }

        public static Param<int> IsNot(this in Param<int> param, int expected)
        {
            Ensure.Comparable.IsNot(param.Value, expected, param.Name);

            return param;
        }

        public static Param<int> IsLt(this in Param<int> param, int limit)
        {
            Ensure.Comparable.IsLt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<int> IsLte(this in Param<int> param, int limit)
        {
            Ensure.Comparable.IsLte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<int> IsGt(this in Param<int> param, int limit)
        {
            Ensure.Comparable.IsGt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<int> IsGte(this in Param<int> param, int limit)
        {
            Ensure.Comparable.IsGte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<int> IsInRange(this in Param<int> param, int min, int max)
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, param.Name);

            return param;
        }
    }
}
