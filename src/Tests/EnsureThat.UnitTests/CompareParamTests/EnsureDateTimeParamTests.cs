using System;

namespace EnsureThat.UnitTests.CompareParamTests
{
    public class EnsureDateTimeParamTests : EnsureCompareParamTests<DateTime>
    {
        private static readonly DateTime BaseDateTime = new DateTime(1970, 1, 1);
        private static readonly DateTime BaseDateTimeUpOne = BaseDateTime.AddDays(1);
        private static readonly DateTime BaseDateTimeDownOne = BaseDateTime.AddDays(-1);

        protected override Param<DateTime> IsLt(CompareParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeUpOne };
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTime };
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<DateTime> { Limit = BaseDateTime, Value = BaseDateTimeDownOne };
        }

        protected override Param<DateTime> IsGt(CompareParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override Param<DateTime> IsLte(CompareParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override Param<DateTime> IsGte(CompareParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override Param<DateTime> IsInRange(CompareParamTestSpec<DateTime> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTimeDownOne };
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTimeUpOne };
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTime };
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<DateTime> { LowerLimit = BaseDateTime, UpperLimit = BaseDateTimeUpOne, Value = BaseDateTimeDownOne };
        }

        protected override CompareParamTestSpec<DateTime> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<DateTime> { LowerLimit = BaseDateTimeDownOne, UpperLimit = BaseDateTime, Value = BaseDateTimeUpOne };
        }
    }
}