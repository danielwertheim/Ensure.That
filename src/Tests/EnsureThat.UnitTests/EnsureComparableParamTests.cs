using System;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureComparableParamTests : UnitTestBase
    {
        [Fact]
        public void IsLt_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsLt(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotLt, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsLt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsLt(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotLt, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsLt_When_value_is_lt_than_limit_It_returns_passed_values()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = IsLt(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsGt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsGt(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotGt, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsGt_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsGt(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotGt, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsGt_When_value_is_gt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_gt_than_limit();

            var returnedValue = IsGt(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsLte_When_value_is_equal_to_limit_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = IsLte(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsLte_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsLte(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotLte, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsLte_When_value_is_lt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = IsLte(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsGte_When_value_is_equal_to_limit_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = IsGte(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsGte_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsGte(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotGte, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsGte_When_value_is_gt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_gt_than_limit();

            var returnedValue = IsGte(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_lower_limit_It_returns_passed_value()
        {
            var spec = When_value_is_lower_limit();

            var returnedValue = IsInRange(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_upper_limit_It_returns_passed_value()
        {
            var spec = When_value_is_upper_limit();

            var returnedValue = IsInRange(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_between_limits_It_returns_passed_value()
        {
            var spec = When_value_is_between_limits();

            var returnedValue = IsInRange(spec);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_lower_than_lower_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lower_than_lower_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsInRange(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow, spec.Value, spec.LowerLimit);
        }

        [Fact]
        public void IsInRange_When_value_is_greater_than_upper_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_greater_than_upper_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsInRange(spec));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh, spec.Value, spec.UpperLimit);
        }

        [Fact]
        public void Is_When_same_values_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).Is(spec.Limit);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void Is_When_different_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(spec.Value, ParamName).Is(spec.Limit));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_Is_Failed, spec.Value, spec.Limit);
        }

        [Fact]
        public void IsNot_When_different_values_It_returns_passed_value()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsNot(spec.Limit);

            AssertReturnedAsExpected(returnedValue, spec.Value);
        }

        [Fact]
        public void IsNot_When_same_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNot_Failed, spec.Value, spec.Limit);
        }

        private Param<int> IsLt(CompareParamTestSpec<int> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
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

        private Param<int> IsGt(CompareParamTestSpec<int> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        private Param<int> IsLte(CompareParamTestSpec<int> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        private Param<int> IsGte(CompareParamTestSpec<int> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        private Param<int> IsInRange(CompareParamTestSpec<int> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
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
    }
}