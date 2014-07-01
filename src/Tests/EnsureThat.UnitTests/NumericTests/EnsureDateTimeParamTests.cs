using System;

namespace EnsureThat.Tests.UnitTests.NumericTests
{
    public class EnsureDateTimeParamTests : EnsureNumericParamTests<DateTime>
    {
        private static readonly DateTime BaseDateTime = new DateTime(1970, 1, 1);
        private static readonly DateTime BaseDateTimeUpOne = BaseDateTime.AddDays(1);
        private static readonly DateTime BaseDateTimeDownOne = BaseDateTime.AddDays(-1);

        protected override Param<DateTime> Test_for_IsLt(NumericParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsLt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeUpOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsLt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTime };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsLt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeDownOne };
        }

        protected override Param<DateTime> Test_for_IsGt(NumericParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsGt_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTime };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsGt_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeDownOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsGt_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeUpOne };
        }

        protected override Param<DateTime> Test_for_IsLte(NumericParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsLte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTime };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsLte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeUpOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsLte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeDownOne };
        }

        protected override Param<DateTime> Test_for_IsGte(NumericParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsGte_WhenValueIsEqualToLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTime };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsGte_WhenValueIsLtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeDownOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsGte_WhenValueIsGtLimit()
        {
            return new NumericParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeUpOne };
        }

        protected override Param<DateTime> Test_for_IsInRange(NumericParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsInRange_WhenValueIsOnLowerLimit()
        {
            return new NumericParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTimeDownOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsInRange_WhenValueIsOnUpperLimit()
        {
            return new NumericParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTimeUpOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsInRange_WhenValueIsBetweenLimits()
        {
            return new NumericParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTime };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsInRange_WhenValueIsLowerThanLowerLimit()
        {
            return new NumericParamTestSpec<DateTime> { LowerLimit = BaseDateTime, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTimeDownOne };
        }

        protected override NumericParamTestSpec<DateTime> Spec_for_IsInRange_WhenValueIsGreaterThanUpperLimit()
        {
            return new NumericParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTime, Value = BaseDateTimeUpOne };
        }
    }
}