namespace EnsureThat.UnitTests.CompareParamTests
{
    public class EnsureFloatParamTests : EnsureCompareParamTests<float>
    {
        protected override Param<float> IsLt(CompareParamTestSpec<float> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override CompareParamTestSpec<float> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<float> { Limit = 42.33f, Value = 43.33f };
        }

        protected override CompareParamTestSpec<float> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<float> { Limit = 42.33f, Value = 42.33f };
        }

        protected override CompareParamTestSpec<float> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<float> { Limit = 42.33f, Value = 41.33f };
        }

        protected override Param<float> IsGt(CompareParamTestSpec<float> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override Param<float> IsLte(CompareParamTestSpec<float> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override Param<float> IsGte(CompareParamTestSpec<float> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override Param<float> IsInRange(CompareParamTestSpec<float> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override CompareParamTestSpec<float> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<float> { LowerLimit = 42.33f, UpperLimit = 50, Value = 42.33f };
        }

        protected override CompareParamTestSpec<float> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<float> { LowerLimit = 42.33f, UpperLimit = 50, Value = 50 };
        }

        protected override CompareParamTestSpec<float> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<float> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override CompareParamTestSpec<float> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<float> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override CompareParamTestSpec<float> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<float> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}