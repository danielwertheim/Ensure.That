using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests.NumericTests
{
    [TestFixture]
    public class EnsureDoubleParamTests : EnsureNumericParamTests<double>
    {
        protected override Param<double> Test_for_IsLt(NumericParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override NumericParamTestSpec<double> Spec_for_IsLt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 43.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsLt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 42.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsLt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 41.33 };
        }

        protected override Param<double> Test_for_IsGt(NumericParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override NumericParamTestSpec<double> Spec_for_IsGt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 42.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsGt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 41.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsGt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 43.33 };
        }

        protected override Param<double> Test_for_IsLte(NumericParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override NumericParamTestSpec<double> Spec_for_IsLte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 42.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsLte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 43.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsLte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 41.33 };
        }

        protected override Param<double> Test_for_IsGte(NumericParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override NumericParamTestSpec<double> Spec_for_IsGte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 42.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsGte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 41.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsGte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<double> { Limit = 42.33, Value = 43.33 };
        }

        protected override Param<double> Test_for_IsInRange(NumericParamTestSpec<double> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override NumericParamTestSpec<double> Spec_for_IsInRange_WhenValueIsOnLowerLimit()
        {
            return new NumericParamTestSpec<double> { LowerLimit = 42.33, UpperLimit = 50, Value = 42.33 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsInRange_WhenValueIsOnUpperLimit()
        {
            return new NumericParamTestSpec<double> { LowerLimit = 42.33, UpperLimit = 50, Value = 50 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsInRange_WhenValueIsBetweenLimits()
        {
            return new NumericParamTestSpec<double> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsInRange_WhenValueIsLowerThanLowerLimit()
        {
            return new NumericParamTestSpec<double> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override NumericParamTestSpec<double> Spec_for_IsInRange_WhenValueIsGreaterThanUpperLimit()
        {
            return new NumericParamTestSpec<double> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}