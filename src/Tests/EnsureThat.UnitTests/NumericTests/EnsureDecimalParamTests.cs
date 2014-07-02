namespace EnsureThat.UnitTests.NumericTests
{
    public class EnsureDecimalParamTests : EnsureNumericParamTests<decimal>
    {
        protected override Param<decimal> Test_for_IsLt(NumericParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsLt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 43.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsLt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 42.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsLt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 41.33m };
        }

        protected override Param<decimal> Test_for_IsGt(NumericParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsGt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 42.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsGt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 41.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsGt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 43.33m };
        }

        protected override Param<decimal> Test_for_IsLte(NumericParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsLte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 42.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsLte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 43.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsLte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 41.33m };
        }

        protected override Param<decimal> Test_for_IsGte(NumericParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsGte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 42.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsGte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 41.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsGte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<decimal> { Limit = 42.33m, Value = 43.33m };
        }

        protected override Param<decimal> Test_for_IsInRange(NumericParamTestSpec<decimal> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsInRange_WhenValueIsOnLowerLimit()
        {
            return new NumericParamTestSpec<decimal> { LowerLimit = 42.33m, UpperLimit = 50, Value = 42.33m };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsInRange_WhenValueIsOnUpperLimit()
        {
            return new NumericParamTestSpec<decimal> { LowerLimit = 42.33m, UpperLimit = 50, Value = 50 };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsInRange_WhenValueIsBetweenLimits()
        {
            return new NumericParamTestSpec<decimal> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsInRange_WhenValueIsLowerThanLowerLimit()
        {
            return new NumericParamTestSpec<decimal> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override NumericParamTestSpec<decimal> Spec_for_IsInRange_WhenValueIsGreaterThanUpperLimit()
        {
            return new NumericParamTestSpec<decimal> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}