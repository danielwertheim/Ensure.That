namespace EnsureThat.UnitTests.CompareParamTests
{
    public class EnsureDoubleParamTests : EnsureCompareParamTests<double>
    {
        protected override Param<double> IsLt(CompareParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override CompareParamTestSpec<double> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<double> { Limit = 42.33, Value = 43.33 };
        }

        protected override CompareParamTestSpec<double> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<double> { Limit = 42.33, Value = 42.33 };
        }

        protected override CompareParamTestSpec<double> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<double> { Limit = 42.33, Value = 41.33 };
        }

        protected override Param<double> IsGt(CompareParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override Param<double> IsLte(CompareParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override Param<double> IsGte(CompareParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override Param<double> IsInRange(CompareParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override CompareParamTestSpec<double> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<double> { LowerLimit = 42.33, UpperLimit = 50, Value = 42.33 };
        }

        protected override CompareParamTestSpec<double> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<double> { LowerLimit = 42.33, UpperLimit = 50, Value = 50 };
        }

        protected override CompareParamTestSpec<double> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<double> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override CompareParamTestSpec<double> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<double> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override CompareParamTestSpec<double> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<double> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}