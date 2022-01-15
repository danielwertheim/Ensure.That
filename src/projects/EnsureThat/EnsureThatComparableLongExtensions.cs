namespace EnsureThat
{
    public static class EnsureThatComparableLongExtensions
    {
        public static Param<long> Is(this in Param<long> param, long expected)
        {
            Ensure.Comparable.Is(param.Value, expected, param.Name);

            return param;
        }

        public static Param<long> IsNot(this in Param<long> param, long expected)
        {
            Ensure.Comparable.IsNot(param.Value, expected, param.Name);

            return param;
        }

        public static Param<long> IsLt(this in Param<long> param, long limit)
        {
            Ensure.Comparable.IsLt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<long> IsLte(this in Param<long> param, long limit)
        {
            Ensure.Comparable.IsLte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<long> IsGt(this in Param<long> param, long limit)
        {
            Ensure.Comparable.IsGt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<long> IsGte(this in Param<long> param, long limit)
        {
            Ensure.Comparable.IsGte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<long> IsInRange(this in Param<long> param, long min, long max)
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, param.Name);

            return param;
        }
    }
}
