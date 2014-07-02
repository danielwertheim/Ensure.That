namespace EnsureThat.UnitTests.NumericTests
{
    public class EnsureShortParamTests : EnsureNumericParamTests<short>
    {
        protected override Param<short> Test_for_IsLt(NumericParamTestSpec<short> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override NumericParamTestSpec<short> Spec_for_IsLt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 43 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsLt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 42 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsLt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 41 };
        }

        protected override Param<short> Test_for_IsGt(NumericParamTestSpec<short> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override NumericParamTestSpec<short> Spec_for_IsGt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 42 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsGt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 41 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsGt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 43 };
        }

        protected override Param<short> Test_for_IsLte(NumericParamTestSpec<short> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override NumericParamTestSpec<short> Spec_for_IsLte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 42 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsLte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 43 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsLte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 41 };
        }

        protected override Param<short> Test_for_IsGte(NumericParamTestSpec<short> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override NumericParamTestSpec<short> Spec_for_IsGte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 42 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsGte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 41 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsGte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<short> { Limit = 42, Value = 43 };
        }

        protected override Param<short> Test_for_IsInRange(NumericParamTestSpec<short> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override NumericParamTestSpec<short> Spec_for_IsInRange_WhenValueIsOnLowerLimit()
        {
            return new NumericParamTestSpec<short> { LowerLimit = 42, UpperLimit = 50, Value = 42 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsInRange_WhenValueIsOnUpperLimit()
        {
            return new NumericParamTestSpec<short> { LowerLimit = 42, UpperLimit = 50, Value = 50 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsInRange_WhenValueIsBetweenLimits()
        {
            return new NumericParamTestSpec<short> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsInRange_WhenValueIsLowerThanLowerLimit()
        {
            return new NumericParamTestSpec<short> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override NumericParamTestSpec<short> Spec_for_IsInRange_WhenValueIsGreaterThanUpperLimit()
        {
            return new NumericParamTestSpec<short> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}