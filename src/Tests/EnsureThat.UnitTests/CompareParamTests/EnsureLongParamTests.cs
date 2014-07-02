namespace EnsureThat.UnitTests.CompareParamTests
{
    public class EnsureLongParamTests : EnsureCompareParamTests<long>
    {
        protected override Param<long> IsLt(CompareParamTestSpec<long> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override CompareParamTestSpec<long> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<long> { Limit = 42, Value = 43 };
        }

        protected override CompareParamTestSpec<long> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<long> { Limit = 42, Value = 42 };
        }

        protected override CompareParamTestSpec<long> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<long> { Limit = 42, Value = 41 };
        }

        protected override Param<long> IsGt(CompareParamTestSpec<long> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override Param<long> IsLte(CompareParamTestSpec<long> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override Param<long> IsGte(CompareParamTestSpec<long> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override Param<long> IsInRange(CompareParamTestSpec<long> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override CompareParamTestSpec<long> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<long> { LowerLimit = 42, UpperLimit = 50, Value = 42 };
        }

        protected override CompareParamTestSpec<long> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<long> { LowerLimit = 42, UpperLimit = 50, Value = 50 };
        }

        protected override CompareParamTestSpec<long> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<long> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override CompareParamTestSpec<long> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<long> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override CompareParamTestSpec<long> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<long> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}