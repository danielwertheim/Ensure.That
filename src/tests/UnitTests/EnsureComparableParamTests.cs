using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    using System.Collections.Generic;

    public class EnsureComparableParamTests : UnitTestBase
    {
        [Fact]
        public void IsLt_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            AssertIsLtScenario(spec.Value, spec.Limit,
                () => Ensure.Comparable.IsLt(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsLt(spec.Limit));
        }

        [Fact]
        public void IsLt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            AssertIsLtScenario(spec.Value, spec.Limit,
                () => Ensure.Comparable.IsLt(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsLt(spec.Limit));
        }

        [Fact]
        public void IsLt_When_value_is_lt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsLt(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsLt(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsLt(spec.Limit));
        }

        [Fact]
        public void IsLt_Comparer_arg_is_used()
        {
            // Sp < sa when case sensitive (S < s), but Sp > sa case insensitive (p > a)
            var Sp = "Sp";
            var sa = "sa";
            IComparer<string> ordinal = StringComparer.Ordinal;
            ShouldNotThrow(
                () => Ensure.Comparable.IsLt(Sp, sa, ordinal, ParamName),
                () => EnsureArg.IsLt(Sp, sa, ordinal, ParamName),
                () => Ensure.That(Sp, ParamName).IsLt(sa, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldNotThrow(
                () => Ensure.Comparable.IsLt(sa, Sp, ignoreCase, ParamName),
                () => EnsureArg.IsLt(sa, Sp, ignoreCase, ParamName),
                () => Ensure.That(sa, ParamName).IsLt(Sp, ignoreCase));
        }

        [Fact]
        public void IsGt_When_value_is_equal_to_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            AssertIsGtScenario(spec.Value, spec.Limit,
                () => Ensure.Comparable.IsGt(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsGt(spec.Limit));
        }

        [Fact]
        public void IsGt_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            AssertIsGtScenario(spec.Value, spec.Limit,
                () => Ensure.Comparable.IsGt(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsGt(spec.Limit));
        }

        [Fact]
        public void IsGt_When_value_is_gt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_gt_than_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsGt(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsGt(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsGt(spec.Limit));
        }

        [Fact]
        public void IsGt_Comparer_arg_is_used()
        {
            // sa > Sp when case sensitive (s > S), but sa < Sp case insensitive (a < p)
            var sa = "sa";
            var Sp = "Sp";
            IComparer<string> ordinal = StringComparer.Ordinal;
            ShouldNotThrow(
                () => Ensure.Comparable.IsGt(sa, Sp, ordinal, ParamName),
                () => EnsureArg.IsGt(sa, Sp, ordinal, ParamName),
                () => Ensure.That(sa, ParamName).IsGt(Sp, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldNotThrow(
                () => Ensure.Comparable.IsGt(Sp, sa, ignoreCase, ParamName),
                () => EnsureArg.IsGt(Sp, sa, ignoreCase, ParamName),
                () => Ensure.That(Sp, ParamName).IsGt(sa, ignoreCase));
        }

        [Fact]
        public void IsLte_When_value_is_equal_to_limit_It_should_not_throw()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsLte(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsLte(spec.Limit));
        }

        [Fact]
        public void IsLte_When_value_is_gt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_gt_than_limit();

            AssertIsLteScenario(spec.Value, spec.Limit,
                () => Ensure.Comparable.IsLte(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsLte(spec.Limit));
        }

        [Fact]
        public void IsLte_When_value_is_lt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsLte(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsLte(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsLte(spec.Limit));
        }

        [Fact]
        public void IsLte_Comparer_arg_is_used()
        {
            // sa > Sa when case sensitive, but sa == Sp when case insensitive
            var sa = "sa";
            var Sa = "Sa";
            IComparer<string> ordinal = StringComparer.Ordinal;
            AssertIsLteScenario(sa, Sa,
                () => Ensure.Comparable.IsLte(sa, Sa, ordinal, ParamName),
                () => EnsureArg.IsLte(sa, Sa, ordinal, ParamName),
                () => Ensure.That(sa, ParamName).IsLte(Sa, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldNotThrow(
                () => Ensure.Comparable.IsLte(sa, Sa, ignoreCase, ParamName),
                () => EnsureArg.IsLte(sa, Sa, ignoreCase, ParamName),
                () => Ensure.That(sa, ParamName).IsLte(Sa, ignoreCase));
        }

        [Fact]
        public void IsGte_When_value_is_equal_to_limit_It_should_not_throw()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsGte(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsGte(spec.Limit));
        }

        [Fact]
        public void IsGte_When_value_is_lt_than_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            AssertIsGteScenario(spec.Value, spec.Limit,
                () => Ensure.Comparable.IsGte(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsGte(spec.Limit));
        }

        [Fact]
        public void IsGte_When_value_is_gt_than_limit_It_should_not_throw()
        {
            var spec = When_value_is_gt_than_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsGte(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsGte(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsGte(spec.Limit));
        }

        [Fact]
        public void IsGte_Comparer_arg_is_used()
        {
            // Sa < sa when case sensitive, but Sa == sa when case insensitive
            var Sa = "Sa";
            var sa = "sa";
            IComparer<string> ordinal = StringComparer.Ordinal;
            AssertIsGteScenario(Sa, sa,
                () => Ensure.Comparable.IsGte(Sa, sa, ordinal, ParamName),
                () => EnsureArg.IsGte(Sa, sa, ordinal, ParamName),
                () => Ensure.That(Sa, ParamName).IsGte(sa, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldNotThrow(
                () => Ensure.Comparable.IsGte(Sa, sa, ignoreCase, ParamName),
                () => EnsureArg.IsGte(Sa, sa, ignoreCase, ParamName),
                () => Ensure.That(Sa, ParamName).IsGte(sa, ignoreCase));
        }

        [Fact]
        public void IsInRange_When_value_is_lower_limit_It_should_not_throw()
        {
            var spec = When_value_is_lower_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit));
        }

        [Fact]
        public void IsInRange_When_value_is_upper_limit_It_should_not_throw()
        {
            var spec = When_value_is_upper_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit));
        }

        [Fact]
        public void IsInRange_When_value_is_between_limits_It_should_not_throw()
        {
            var spec = When_value_is_between_limits();

            ShouldNotThrow(
                () => Ensure.Comparable.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit));
        }

        [Fact]
        public void IsInRange_When_value_is_lower_than_lower_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_lower_than_lower_limit();

            AssertIsRangeToLowScenario(spec.Value, spec.LowerLimit,
                () => Ensure.Comparable.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit));
        }

        [Fact]
        public void IsInRange_When_value_is_greater_than_upper_limit_It_throws_ArgumentException()
        {
            var spec = When_value_is_greater_than_upper_limit();

            AssertIsRangeToHighScenario(spec.Value, spec.UpperLimit,
                () => Ensure.Comparable.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => EnsureArg.IsInRange(spec.Value, spec.LowerLimit, spec.UpperLimit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit));
        }

        [Fact]
        public void IsInRange_Comparer_arg_is_used()
        {
            // sa < Sb < sc when case sensitive, but not when case insensitive
            var sa = "sa";
            var Sb = "Sb";
            var sc = "sc";
            IComparer<string> ordinal = StringComparer.Ordinal;
            AssertIsRangeToLowScenario(Sb, sa,
                () => Ensure.Comparable.IsInRange(Sb, sa, sc, ordinal, ParamName),
                () => EnsureArg.IsInRange(Sb, sa, sc, ordinal, ParamName),
                () => Ensure.That(Sb, ParamName).IsInRange(sa, sc, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldNotThrow(
                () => Ensure.Comparable.IsInRange(Sb, sa, sc, ignoreCase, ParamName),
                () => EnsureArg.IsInRange(Sb, sa, sc, ignoreCase, ParamName),
                () => Ensure.That(Sb, ParamName).IsInRange(sa, sc, ignoreCase));
        }

        [Fact]
        public void Is_When_same_values_It_should_not_throw()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.Is(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.Is(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).Is(spec.Limit));
        }

        [Fact]
        public void Is_When_different_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldThrow<ArgumentException>(
                string.Format(ExceptionMessages.Comp_Is_Failed, spec.Value, spec.Limit),
                () => Ensure.Comparable.Is(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.Is(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).Is(spec.Limit));
        }

        [Fact]
        public void Is_Comparer_arg_is_used()
        {
            // sa < Sb < sc when case sensitive, but not when case insensitive
            var sa = "sa";
            var Sa = "Sa";
            IComparer<string> ordinal = StringComparer.Ordinal;
            ShouldThrow<ArgumentException>(
                string.Format(ExceptionMessages.Comp_Is_Failed, sa, Sa),
                () => Ensure.Comparable.Is(sa, Sa, ordinal, ParamName),
                () => EnsureArg.Is(sa, Sa, ordinal, ParamName),
                () => Ensure.That(sa, ParamName).Is(Sa, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldNotThrow(
                () => Ensure.Comparable.Is(sa, Sa, ignoreCase, ParamName),
                () => EnsureArg.Is(sa, Sa, ignoreCase, ParamName),
                () => Ensure.That(sa, ParamName).Is(Sa, ignoreCase));
        }

        [Fact]
        public void IsNot_When_different_values_It_should_not_throw()
        {
            var spec = When_value_is_lt_than_limit();

            ShouldNotThrow(
                () => Ensure.Comparable.IsNot(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsNot(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit));
        }

        [Fact]
        public void IsNot_When_same_values_It_throws_ArgumentException()
        {
            var spec = When_value_is_equal_to_limit();

            ShouldThrow<ArgumentException>(
                string.Format(ExceptionMessages.Comp_IsNot_Failed, spec.Value, spec.Limit),
                () => Ensure.Comparable.IsNot(spec.Value, spec.Limit, ParamName),
                () => EnsureArg.IsNot(spec.Value, spec.Limit, ParamName),
                () => Ensure.That(spec.Value, ParamName).IsNot(spec.Limit));
        }

        [Fact]
        public void IsNot_Comparer_arg_is_used()
        {
            // sa < Sb < sc when case sensitive, but not when case insensitive
            var sa = "sa";
            var Sa = "Sa";
            IComparer<string> ordinal = StringComparer.Ordinal;
            ShouldNotThrow(
                () => Ensure.Comparable.IsNot(sa, Sa, ordinal, ParamName),
                () => EnsureArg.IsNot(sa, Sa, ordinal, ParamName),
                () => Ensure.That(sa, ParamName).IsNot(Sa, ordinal));

            // Validate with comparer (order is reversed)
            IComparer<string> ignoreCase = StringComparer.OrdinalIgnoreCase;
            ShouldThrow<ArgumentException>(
                string.Format(ExceptionMessages.Comp_IsNot_Failed, sa, Sa),
                () => Ensure.Comparable.IsNot(sa, Sa, ignoreCase, ParamName),
                () => EnsureArg.IsNot(sa, Sa, ignoreCase, ParamName),
                () => Ensure.That(sa, ParamName).IsNot(Sa, ignoreCase));
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

        private static void AssertIsLtScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), actions);

        private static void AssertIsGtScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), actions);

        private static void AssertIsLteScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), actions);

        private static void AssertIsGteScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), actions);

        private static void AssertIsRangeToLowScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, limit), actions);

        private static void AssertIsRangeToHighScenario<T>(T value, T limit, params Action[] actions)
            => ShouldThrow<ArgumentOutOfRangeException>(string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, limit), actions);

        public class CustomComparable : IComparable<CustomComparable>
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