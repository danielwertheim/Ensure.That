using System;
using FluentAssertions;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureComparableParamTests : UnitTestBase
    {
        [Fact]
        public void IsLt_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            AssertIsLtScenario(spec.Value, spec.Limit,
                () => Ensure.That(spec.Value, ParamName).IsLt(spec.Limit),
                () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsLt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            AssertIsLtScenario(spec.Value, spec.Limit,
                () => Ensure.That(spec.Value, ParamName).IsLt(spec.Limit),
                () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsLt_When_value_is_lt_than_limit_It_returns_passed_values()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsGt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            AssertIsGtScenario(spec.Value, spec.Limit,
                () => Ensure.That(spec.Value, ParamName).IsGt(spec.Limit),
                () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsGt_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            AssertIsGtScenario(spec.Value, spec.Limit,
                () => Ensure.That(spec.Value, ParamName).IsGt(spec.Limit),
                () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsGt_When_value_is_gt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_gt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsLte_When_value_is_equal_to_limit_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsLte_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            AssertIsLteScenario(spec.Value, spec.Limit,
                () => Ensure.That(spec.Value, ParamName).IsLte(spec.Limit),
                () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsLte_When_value_is_lt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsGte_When_value_is_equal_to_limit_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsGte_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            AssertIsGteScenario(spec.Value, spec.Limit,
                () => Ensure.That(spec.Value, ParamName).IsGte(spec.Limit),
                () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsGte_When_value_is_gt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_gt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsInRange_When_value_is_lower_limit_It_returns_passed_value()
        {
            var spec = When_value_is_lower_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsInRange_When_value_is_upper_limit_It_returns_passed_value()
        {
            var spec = When_value_is_upper_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsInRange_When_value_is_between_limits_It_returns_passed_value()
        {
            var spec = When_value_is_between_limits();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsInRange_When_value_is_lower_than_lower_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lower_than_lower_limit();

            AssertIsRangeToLowScenario(spec.Value, spec.LowerLimit,
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName));
        }

        [Fact]
        public void IsInRange_When_value_is_greater_than_upper_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_greater_than_upper_limit();

            AssertIsRangeToHighScenario(spec.Value, spec.UpperLimit,
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName));
        }

        [Fact]
        public void Is_When_same_values_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).Is(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.Is(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Is_When_different_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_Is_Failed, spec.Value, spec.Limit),
                () => Ensure.That(spec.Value, ParamName).Is(spec.Limit),
                () => EnsureArg.Is(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsNot_When_different_values_It_returns_passed_value()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsNot(spec.Limit);
            AssertReturnedAsExpected(returnedValue, spec.Value);

            Action a = () => EnsureArg.IsNot(spec.Value, spec.Limit, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsNot_When_same_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsNot_Failed, spec.Value, spec.Limit),
                () => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit),
                () => EnsureArg.IsNot(spec.Value, spec.Limit, ParamName));
        }

        private CompareParamTestSpec<int> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<int> { Limit = 42, Value = 43 };
        }

        private CompareParamTestSpec<int> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<int> { Limit = 42, Value = 42 };
        }

        private CompareParamTestSpec<int> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<int> { Limit = 42, Value = 41 };
        }

        private CompareParamTestSpec<int> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<int> { LowerLimit = 42, UpperLimit = 50, Value = 42 };
        }

        private CompareParamTestSpec<int> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<int> { LowerLimit = 42, UpperLimit = 50, Value = 50 };
        }

        private CompareParamTestSpec<int> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<int> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        private CompareParamTestSpec<int> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<int> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        private CompareParamTestSpec<int> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<int> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }

        public void AssertIsLtScenario(int value, int limit, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_IsNotLt, value, limit), actions);

        public void AssertIsGtScenario(int value, int limit, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_IsNotGt, value, limit), actions);

        public void AssertIsLteScenario(int value, int limit, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_IsNotLte, value, limit), actions);

        public void AssertIsGteScenario(int value, int limit, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_IsNotGte, value, limit), actions);

        public void AssertIsRangeToLowScenario(int value, int limit, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow, value, limit), actions);

        public void AssertIsRangeToHighScenario(int value, int limit, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh, value, limit), actions);

        public class CompareParamTestSpec<T> where T : struct
        {
            public T Limit { get; set; }

            public T LowerLimit { get; set; }

            public T UpperLimit { get; set; }

            public T Value { get; set; }
        }
    }
}