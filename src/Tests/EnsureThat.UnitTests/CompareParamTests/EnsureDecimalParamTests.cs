namespace EnsureThat.UnitTests.CompareParamTests
{
    public class EnsureDecimalParamTests : EnsureCompareParamTests<decimal>
    {
        protected override Param<decimal> IsLt(CompareParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override CompareParamTestSpec<decimal> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<decimal> { Limit = 42.33m, Value = 43.33m };
        }

        protected override CompareParamTestSpec<decimal> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<decimal> { Limit = 42.33m, Value = 42.33m };
        }

        protected override CompareParamTestSpec<decimal> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<decimal> { Limit = 42.33m, Value = 41.33m };
        }

        protected override Param<decimal> IsGt(CompareParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override Param<decimal> IsLte(CompareParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override Param<decimal> IsGte(CompareParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override Param<decimal> IsInRange(CompareParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override CompareParamTestSpec<decimal> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<decimal> { LowerLimit = 42.33m, UpperLimit = 50, Value = 42.33m };
        }

        protected override CompareParamTestSpec<decimal> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<decimal> { LowerLimit = 42.33m, UpperLimit = 50, Value = 50 };
        }

        protected override CompareParamTestSpec<decimal> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<decimal> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override CompareParamTestSpec<decimal> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<decimal> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override CompareParamTestSpec<decimal> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<decimal> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}