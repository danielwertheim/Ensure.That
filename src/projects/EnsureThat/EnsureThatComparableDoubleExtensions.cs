namespace EnsureThat
{
    public static class EnsureThatComparableDoubleExtensions
    {
        public static Param<double> Is(this in Param<double> param, double expected)
        {
            Ensure.Comparable.Is(param.Value, expected, param.Name);

            return param;
        }

        public static Param<double> IsNot(this in Param<double> param, double expected)
        {
            Ensure.Comparable.IsNot(param.Value, expected, param.Name);

            return param;
        }

        public static Param<double> IsLt(this in Param<double> param, double limit)
        {
            Ensure.Comparable.IsLt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<double> IsLte(this in Param<double> param, double limit)
        {
            Ensure.Comparable.IsLte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<double> IsGt(this in Param<double> param, double limit)
        {
            Ensure.Comparable.IsGt(param.Value, limit, param.Name);

            return param;
        }

        public static Param<double> IsGte(this in Param<double> param, double limit)
        {
            Ensure.Comparable.IsGte(param.Value, limit, param.Name);

            return param;
        }

        public static Param<double> IsInRange(this in Param<double> param, double min, double max)
        {
            Ensure.Comparable.IsInRange(param.Value, min, max, param.Name);

            return param;
        }
    }
}
