using System;
using EnsureThat.Resources;
using Xunit;

namespace EnsureThat.UnitTests.CompareParamTests
{
    public abstract class EnsureCompareParamTests<T> : UnitTestBase where T : struct, IComparable<T>
    {
        protected const string ParamName = "test";

        protected abstract Param<T> IsLt(CompareParamTestSpec<T> spec);
        protected abstract Param<T> IsGt(CompareParamTestSpec<T> spec);
        protected abstract Param<T> IsLte(CompareParamTestSpec<T> spec);
        protected abstract Param<T> IsGte(CompareParamTestSpec<T> spec);
        protected abstract Param<T> IsInRange(CompareParamTestSpec<T> spec);

        protected abstract CompareParamTestSpec<T> When_value_is_gt_than_limit();
        protected abstract CompareParamTestSpec<T> When_value_is_lt_than_limit();
        protected abstract CompareParamTestSpec<T> When_value_is_equal_to_limit();
        protected abstract CompareParamTestSpec<T> When_value_is_lower_limit();
        protected abstract CompareParamTestSpec<T> When_value_is_upper_limit();
        protected abstract CompareParamTestSpec<T> When_value_is_between_limits();
        protected abstract CompareParamTestSpec<T> When_value_is_lower_than_lower_limit();
        protected abstract CompareParamTestSpec<T> When_value_is_greater_than_upper_limit();

        [Fact]
        public void IsLt_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsLt(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotLt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsLt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsLt(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotLt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsLt_When_value_is_lt_than_limit_It_returns_passed_values()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = IsLt(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsGt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsGt(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotGt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsGt_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsGt(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotGt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsGt_When_value_is_gt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_gt_than_limit();

            var returnedValue = IsGt(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsLte_When_value_is_equal_to_limit_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = IsLte(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsLte_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsLte(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotLte, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsLte_When_value_is_lt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = IsLte(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsGte_When_value_is_equal_to_limit_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = IsGte(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsGte_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsGte(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotGte, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsGte_When_value_is_gt_than_limit_It_returns_passed_value()
        {
            var spec = When_value_is_gt_than_limit();

            var returnedValue = IsGte(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_lower_limit_It_returns_passed_value()
        {
            var spec = When_value_is_lower_limit();

            var returnedValue = IsInRange(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_upper_limit_It_returns_passed_value()
        {
            var spec = When_value_is_upper_limit();

            var returnedValue = IsInRange(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_between_limits_It_returns_passed_value()
        {
            var spec = When_value_is_between_limits();

            var returnedValue = IsInRange(spec);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsInRange_When_value_is_lower_than_lower_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lower_than_lower_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsInRange(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow, spec.Value, spec.LowerLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsInRange_When_value_is_greater_than_upper_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_greater_than_upper_limit();

            var ex = Assert.Throws<ArgumentException>(
                () => IsInRange(spec));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh, spec.Value, spec.UpperLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void Is_When_same_values_It_returns_passed_value()
        {
            var spec = When_value_is_equal_to_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).Is(spec.Limit);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void Is_When_different_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(spec.Value, ParamName).Is(spec.Limit));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_Is_Failed, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsNot_When_different_values_It_returns_passed_value()
        {
            var spec = When_value_is_lt_than_limit();

            var returnedValue = Ensure.That(spec.Value, ParamName).IsNot(spec.Limit);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(spec.Value, returnedValue.Value);
        }

        [Fact]
        public void IsNot_When_same_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit));

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(string.Format(ExceptionMessages.EnsureExtensions_IsNot_Failed, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }
    }
}