using System;
using System.Text.RegularExpressions;
using FluentAssertions;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureStringParamTests : UnitTestBase
    {
        private void AssertIsNotNull(params Action[] actions) => AssertAll<ArgumentNullException>(ExceptionMessages.EnsureExtensions_IsNotNull, actions);

        private void AssertIsNotEmpty(params Action[] actions) => AssertAll<ArgumentException>(ExceptionMessages.EnsureExtensions_IsEmptyString, actions);

        private void AssertIsNotNullOrEmpty(params Action[] actions) => AssertAll<ArgumentException>(ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty, actions);

        private void AssertIsNotNullOrWhiteSpace(params Action[] actions) => AssertAll<ArgumentException>(ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace, actions);

        [Fact]
        public void IsNotNull_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.That(value, ParamName).IsNotNull(),
                () => EnsureArg.IsNotNull(value, ParamName));
        }

        [Fact]
        public void IsNotNull_WhenStringIsNotNull_It_should_not_throw()
        {
            var value = string.Empty;

            var returned = Ensure.That(value, ParamName).IsNotNull();
            AssertReturnedAsExpected(returned, value);

            Action a = () => EnsureArg.IsNotNull(value, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty(),
                () => EnsureArg.IsNotNullOrEmpty(value, ParamName));
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            var value = string.Empty;

            AssertIsNotNullOrEmpty(
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty(),
                () => EnsureArg.IsNotNullOrEmpty(value, ParamName));
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNotNullOrEmpty_It_should_not_throw()
        {
            var value = " ";

            var returned = Ensure.That(value, ParamName).IsNotNullOrEmpty();
            AssertReturnedAsExpected(returned, value);

            Action a = () => EnsureArg.IsNotNullOrEmpty(value, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace(),
                () => EnsureArg.IsNotNullOrWhiteSpace(value, ParamName));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void IsNotNullOrWhiteSpace_WhenStringIsInvalid_ThrowsArgumentException(string value)
        {
            AssertIsNotNullOrWhiteSpace(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace(),
                () => EnsureArg.IsNotNullOrWhiteSpace(value, ParamName));
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringHasValue_It_should_not_throw()
        {
            var value = "delta";

            var returned = Ensure.That(value, ParamName).IsNotNullOrWhiteSpace();
            AssertReturnedAsExpected(returned, value);

            Action a = () => EnsureArg.IsNotNullOrWhiteSpace(value, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsNotEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            var value = string.Empty;

            AssertIsNotEmpty(
                () => Ensure.That(value, ParamName).IsNotEmpty(),
                () => EnsureArg.IsNotEmpty(value, ParamName));
        }

        [Fact]
        public void IsNotEmpty_WhenStringHasValue_It_should_not_throw()
        {
            var value = "delta";

            var returned = Ensure.That(value, ParamName).IsNotEmpty();
            AssertReturnedAsExpected(returned, value);

            Action a = () => EnsureArg.IsNotEmpty(value, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.That(value, ParamName).HasLengthBetween(1, 2),
                () => EnsureArg.HasLengthBetween(value, 1, 2, ParamName));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsToShort_ThrowsArgumentException()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', low - 1);

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToShort, low, high, value.Length),
                () => Ensure.That(value, ParamName).HasLengthBetween(2, high),
                () => EnsureArg.HasLengthBetween(value, low, high, ParamName));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsToLong_ThrowsArgumentException()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', high + 1);

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToLong, low, high, value.Length),
                () => Ensure.That(value, ParamName).HasLengthBetween(2, high),
                () => EnsureArg.HasLengthBetween(value, low, high, ParamName));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsLowLimit_It_should_not_throw()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', low);

            var returnedValue = Ensure.That(value, ParamName).HasLengthBetween(low, high);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.HasLengthBetween(value, low, high, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsHighLimit_It_should_not_throw()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', high);

            var returnedValue = Ensure.That(value, ParamName).HasLengthBetween(low, high);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.HasLengthBetween(value, low, high, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Matches_WhenUrlStringDoesNotMatchStringPattern_ThrowsArgumentException()
        {
            const string value = @"incorrect";
            const string match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_NoMatch, value, match),
                () => Ensure.That(value, ParamName).Matches(match),
                () => EnsureArg.Matches(value, match, ParamName));
        }

        [Fact]
        public void Matches_WhenUrlStringDoesNotMatchRegex_ThrowsArgumentException()
        {
            const string value = @"incorrect";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_NoMatch, value, match),
                () => Ensure.That(value, ParamName).Matches(match),
                () => EnsureArg.Matches(value, match, ParamName));
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesStringPattern_It_should_not_throw()
        {
            const string value = @"http://google.com:8080";
            const string match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";

            var returnedValue = Ensure.That(value, ParamName).Matches(match);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.Matches(value, match, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesRegex_It_should_not_throw()
        {
            const string value = @"http://google.com:8080";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

            var returnedValue = Ensure.That(value, ParamName).Matches(match);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.Matches(value, match, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_string_It_throws_ArgumentException()
        {
            var value = "Some string";
            var expected = value.Length + 1;

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_SizeIs_Wrong, expected, value.Length),
                () => Ensure.That(value, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(value, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_constraint_It_should_not_throw()
        {
            var value = "Some string";

            var returned = Ensure.That(value, ParamName).SizeIs(value.Length);
            AssertReturnedAsExpected(returned, value);

            Action a = () => EnsureArg.SizeIs(value, value.Length, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsEqualTo_When_different_values_It_throws_ArgumentException()
        {
            const string value = "The value";
            const string expected = "Other value";

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsEqualTo_Failed, value, expected),
                () => Ensure.That(value, ParamName).IsEqualTo(expected),
                () => EnsureArg.IsEqualTo(value, expected, ParamName));
        }

        [Fact]
        public void IsEqualTo_When_same_value_It_should_not_throw()
        {
            const string value = "The value";
            const string expected = value;

            var returnedValue = Ensure.That(value, ParamName).IsEqualTo(expected);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.IsEqualTo(value, expected, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsEqualTo_When_same_value_by_specific_compare_It_should_not_throw()
        {
            const string value = "The value";
            const string expected = "the value";

            var returnedValue = Ensure.That(value, ParamName).IsEqualTo(expected, StringComparison.OrdinalIgnoreCase);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.IsEqualTo(value, expected, StringComparison.OrdinalIgnoreCase, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsNotEqualTo_When_same_values_It_throws_ArgumentException()
        {
            const string value = "The value";

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsNot_Failed, value, value),
                () => Ensure.That(value, ParamName).IsNotEqualTo(value),
                () => EnsureArg.IsNotEqualTo(value, value, ParamName));
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_by_casing_using_non_case_sensitive_compare_It_throws_ArgumentException()
        {
            const string value = "The value";
            var compareTo = value.ToLower();

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsNot_Failed, value, compareTo),
                () => Ensure.That(value, ParamName).IsNotEqualTo(compareTo, StringComparison.OrdinalIgnoreCase),
                () => EnsureArg.IsNotEqualTo(value, compareTo, StringComparison.OrdinalIgnoreCase, ParamName));
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_It_should_not_throw()
        {
            var value = "The value";

            var returnedValue = Ensure.That(value, ParamName).IsNotEqualTo(value + "a");
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.IsNotEqualTo(value, value + "a", ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_by_casing_using_case_sensitive_compare_It_should_not_throw()
        {
            var value = "The value";

            var returnedValue = Ensure.That(value, ParamName).IsNotEqualTo(value.ToLower(), StringComparison.Ordinal);
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.IsNotEqualTo(value, value.ToLower(), StringComparison.Ordinal, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsGuid_When_is_not_Guid_throws_ArgumentException()
        {
            const string value = "324-3243-123-23";

            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.EnsureExtensions_IsGuid_Failed, value),
                () => Ensure.That(value, ParamName).IsGuid(),
                () => EnsureArg.IsGuid(value, ParamName));
        }

        [Fact]
        public void IsGuid_When_valid_Guid_returns_Guid()
        {
            var value = Guid.NewGuid().ToString();

            var returnedValue = Ensure.That(value, ParamName).IsGuid();
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.IsGuid(value, ParamName);
            a.ShouldNotThrow();
        }
    }
}