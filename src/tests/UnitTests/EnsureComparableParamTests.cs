using System;
using EnsureThat;
using Xunit;

namespace UnitTests
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
        public void IsLt_When_value_is_lt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsLt(spec.Limit),
                () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName));
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
        public void IsGt_When_value_is_gt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_gt_than_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsGt(spec.Limit),
                () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsLte_When_value_is_equal_to_limit_It_should_not_throw()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsLte(spec.Limit),
                () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName));
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
        public void IsLte_When_value_is_lt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsLte(spec.Limit),
                () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsGte_When_value_is_equal_to_limit_It_should_not_throw()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsGte(spec.Limit),
                () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName));
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
        public void IsGte_When_value_is_gt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_gt_than_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsGte(spec.Limit),
                () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsInRange_When_value_is_lower_limit_It_should_not_throw()
        {
            var spec = When_value_is_lower_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName));
        }

        [Fact]
        public void IsInRange_When_value_is_upper_limit_It_should_not_throw()
        {
            var spec = When_value_is_upper_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName));
        }

        [Fact]
        public void IsInRange_When_value_is_between_limits_It_should_not_throw()
        {
            var spec = When_value_is_between_limits();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName));
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
        public void Is_When_same_values_It_should_not_throw()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).Is(spec.Limit),
                () => EnsureArg.Is(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void Is_When_different_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldThrow<ArgumentException>(
                string.Format(ExceptionMessages.Comp_Is_Failed, spec.Value, spec.Limit),
                () => Ensure.That(spec.Value, ParamName).Is(spec.Limit),
                () => EnsureArg.Is(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsNot_When_different_values_It_should_not_throw()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldNotThrow(
                () => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit),
                () => EnsureArg.IsNot(spec.Value, spec.Limit, ParamName));
        }

        [Fact]
        public void IsNot_When_same_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldThrow<ArgumentException>(
                string.Format(ExceptionMessages.Comp_IsNot_Failed, spec.Value, spec.Limit),
                () => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit),
                () => EnsureArg.IsNot(spec.Value, spec.Limit, ParamName));
        }

        private CompareParamTestSpec When_value_is_gt_than_limit() => new CompareParamTestSpec
        {
            Limit = 42,
            Value = 43
        };

        private CompareParamTestSpec When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec { Limit = 42, Value = 42 };
        }

        private CompareParamTestSpec When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec { Limit = 42, Value = 41 };
        }

        private CompareParamTestSpec When_value_is_lower_limit()
        {
            return new CompareParamTestSpec { LowerLimit = 42, UpperLimit = 50, Value = 42 };
        }

        private CompareParamTestSpec When_value_is_upper_limit()
        {
            return new CompareParamTestSpec { LowerLimit = 42, UpperLimit = 50, Value = 50 };
        }

        private CompareParamTestSpec When_value_is_between_limits()
        {
            return new CompareParamTestSpec { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        private CompareParamTestSpec When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        private CompareParamTestSpec When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }

        public void AssertIsLtScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), actions);

        public void AssertIsGtScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), actions);

        public void AssertIsLteScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), actions);

        public void AssertIsGteScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), actions);

        public void AssertIsRangeToLowScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, limit), actions);

        public void AssertIsRangeToHighScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, limit), actions);

        public class CustomComparable : IComparable<CustomComparable>, IEquatable<CustomComparable>
        {
            private readonly int _value;

            public CustomComparable(int value)
            {
                _value = value;
            }

            public int CompareTo(CustomComparable other)
            {
                var x = _value;
                var y = other._value;

                return x.CompareTo(y);
            }

            public bool Equals(CustomComparable other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return this._value == other._value;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((CustomComparable) obj);
            }

            public override int GetHashCode()
            {
                return this._value;
            }

            public static bool operator ==(CustomComparable left, CustomComparable right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(CustomComparable left, CustomComparable right)
            {
                return !Equals(left, right);
            }

            public static implicit operator CustomComparable(int value) => new CustomComparable(value);
        }

        public class CompareParamTestSpec
        {
            public CustomComparable Limit { get; set; }
            public CustomComparable LowerLimit { get; set; }
            public CustomComparable UpperLimit { get; set; }
            public CustomComparable Value { get; set; }
        }
    }
}