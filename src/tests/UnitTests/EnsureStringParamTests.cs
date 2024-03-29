using System;
using System.Globalization;
using System.Text.RegularExpressions;
using EnsureThat;
using EnsureThat.Internals;
using Xunit;
#pragma warning disable 618

namespace UnitTests
{
    public class EnsureStringParamTests : UnitTestBase
    {
        private static void AssertIsNotNull(params Action[] actions) => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private static void AssertIsNotEmpty(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Strings_IsNotEmpty_Failed, actions);

        private static void AssertIsNotNullOrEmpty(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, actions);

        private static void AssertIsNotNullOrWhiteSpace(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, actions);

        [Fact]
        public void IsNotNull_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.String.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotNull_WhenStringIsNotNull_It_should_not_throw()
        {
            var value = string.Empty;

            ShouldNotThrow(
                () => Ensure.String.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.String.IsNotNullOrEmpty(value, ParamName),
                () => EnsureArg.IsNotNullOrEmpty(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            var value = string.Empty;

            AssertIsNotNullOrEmpty(
                () => Ensure.String.IsNotNullOrEmpty(value, ParamName),
                () => EnsureArg.IsNotNullOrEmpty(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNotNullOrEmpty_It_should_not_throw()
        {
            var value = " ";

            ShouldNotThrow(
                () => Ensure.String.IsNotNullOrEmpty(value, ParamName),
                () => EnsureArg.IsNotNullOrEmpty(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotEmptyOrWhiteSpace_WhenNull_It_should_not_throw()
        {
            string value = null;
            ShouldNotThrow(
                () => Ensure.String.IsNotEmptyOrWhiteSpace(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmptyOrWhiteSpace(),
                () => EnsureArg.IsNotEmptyOrWhiteSpace(value, ParamName));
        }

        [Fact]
        public void IsNotEmptyOrWhiteSpace_WhenEmpty_ThrowsArgumentException()
        {
            string value = "";
            ShouldThrow<ArgumentException>(
                ExceptionMessages.Strings_IsNotEmptyOrWhiteSpace_Failed,
                () => Ensure.String.IsNotEmptyOrWhiteSpace(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmptyOrWhiteSpace(),
                () => EnsureArg.IsNotEmptyOrWhiteSpace(value, ParamName));
        }

        [Fact]
        public void IsNotEmptyOrWhiteSpace_WhenWhiteSpace_ThrowsArgumentException()
        {
            string value = "        ";
            ShouldThrow<ArgumentException>(
                ExceptionMessages.Strings_IsNotEmptyOrWhiteSpace_Failed,
                () => Ensure.String.IsNotEmptyOrWhiteSpace(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmptyOrWhiteSpace(),
                () => EnsureArg.IsNotEmptyOrWhiteSpace(value, ParamName));
        }

        [Fact]
        public void IsNotEmptyOrWhiteSpace_WhenPartialWhiteSpace_It_should_not_throw()
        {
            string value = "  string with whitespace in it  ";
            ShouldNotThrow(
                () => Ensure.String.IsNotEmptyOrWhiteSpace(value, ParamName),
                () => EnsureArg.IsNotEmptyOrWhiteSpace(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmptyOrWhiteSpace());
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.String.IsNotNullOrWhiteSpace(value, ParamName),
                () => EnsureArg.IsNotNullOrWhiteSpace(value, ParamName));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void IsNotNullOrWhiteSpace_WhenStringIsInvalid_ThrowsArgumentException(string value)
        {
            AssertIsNotNullOrWhiteSpace(
                () => Ensure.String.IsNotNullOrWhiteSpace(value, ParamName),
                () => EnsureArg.IsNotNullOrWhiteSpace(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringHasValue_It_should_not_throw()
        {
            var value = "delta";

            ShouldNotThrow(
                () => Ensure.String.IsNotNullOrWhiteSpace(value, ParamName),
                () => EnsureArg.IsNotNullOrWhiteSpace(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());
        }

        [Fact]
        public void IsNotEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            var value = string.Empty;

            AssertIsNotEmpty(
                () => Ensure.String.IsNotEmpty(value, ParamName),
                () => EnsureArg.IsNotEmpty(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmpty_WhenStringHasValue_It_should_not_throw()
        {
            var value = "delta";

            ShouldNotThrow(
                () => Ensure.String.IsNotEmpty(value, ParamName),
                () => EnsureArg.IsNotEmpty(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmpty_WhenStringIsNull_It_should_not_throw()
        {
            string value = null;

            ShouldNotThrow(
                () => Ensure.String.IsNotEmpty(value, ParamName),
                () => EnsureArg.IsNotEmpty(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEmpty());
        }

        [Fact]
        public void HasLength_When_null_It_throws_ArgumentNullException()
        {
            string value = null;
            var expected = 1;

            AssertIsNotNull(
                () => Ensure.String.HasLength(value, expected, ParamName),
                () => EnsureArg.HasLength(value, expected, ParamName),
                () => Ensure.That(value, ParamName).HasLength(expected));
        }

        [Fact]
        public void HasLength_When_non_matching_length_of_string_It_throws_ArgumentException()
        {
            var value = "Some string";
            var expected = value.Length + 1;

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_SizeIs_Failed, expected, value.Length),
                () => Ensure.String.HasLength(value, expected, ParamName),
                () => EnsureArg.HasLength(value, expected, ParamName),
                () => Ensure.That(value, ParamName).HasLength(expected));
        }

        [Fact]
        public void HasLength_When_matching_constraint_It_should_not_throw()
        {
            var value = "Some string";

            ShouldNotThrow(
                () => Ensure.String.HasLength(value, value.Length, ParamName),
                () => EnsureArg.HasLength(value, value.Length, ParamName));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            AssertIsNotNull(
                () => Ensure.String.HasLengthBetween(value, 1, 2, ParamName),
                () => EnsureArg.HasLengthBetween(value, 1, 2, ParamName),
                () => Ensure.That(value, ParamName).HasLengthBetween(1, 2));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsToShort_ThrowsArgumentException()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', low - 1);

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort, low, high, value.Length),
                () => Ensure.String.HasLengthBetween(value, low, high, ParamName),
                () => EnsureArg.HasLengthBetween(value, low, high, ParamName),
                () => Ensure.That(value, ParamName).HasLengthBetween(low, high));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsToLong_ThrowsArgumentException()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', high + 1);

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong, low, high, value.Length),
                () => Ensure.String.HasLengthBetween(value, low, high, ParamName),
                () => EnsureArg.HasLengthBetween(value, low, high, ParamName),
                () => Ensure.That(value, ParamName).HasLengthBetween(low, high));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsLowLimit_It_should_not_throw()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', low);

            ShouldNotThrow(
                () => Ensure.String.HasLengthBetween(value, low, high, ParamName),
                () => EnsureArg.HasLengthBetween(value, low, high, ParamName),
                () => Ensure.That(value, ParamName).HasLengthBetween(low, high));
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsHighLimit_It_should_not_throw()
        {
            const int low = 2;
            const int high = 4;
            var value = new string('a', high);

            ShouldNotThrow(
                () => Ensure.String.HasLengthBetween(value, low, high, ParamName),
                () => EnsureArg.HasLengthBetween(value, low, high, ParamName),
                () => Ensure.That(value, ParamName).HasLengthBetween(low, high));
        }

        [Fact]
        public void Matches_WhenUrlStringDoesNotMatchStringPattern_ThrowsArgumentException()
        {
            const string value = @"incorrect";
            const string match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_Matches_Failed, value, match),
                () => Ensure.String.Matches(value, match, ParamName),
                () => EnsureArg.Matches(value, match, ParamName),
                () => Ensure.That(value, ParamName).Matches(match));
        }

        [Fact]
        public void Matches_WhenUrlStringDoesNotMatchRegex_ThrowsArgumentException()
        {
            const string value = @"incorrect";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_Matches_Failed, value, match),
                () => Ensure.String.Matches(value, match, ParamName),
                () => EnsureArg.Matches(value, match, ParamName),
                () => Ensure.That(value, ParamName).Matches(match));
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesStringPattern_It_should_not_throw()
        {
            const string value = @"http://google.com:8080";
            const string match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";

            ShouldNotThrow(
                () => Ensure.String.Matches(value, match, ParamName),
                () => EnsureArg.Matches(value, match, ParamName),
                () => Ensure.That(value, ParamName).Matches(match));
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesRegex_It_should_not_throw()
        {
            const string value = @"http://google.com:8080";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

            ShouldNotThrow(
                () => Ensure.String.Matches(value, match, ParamName),
                () => EnsureArg.Matches(value, match, ParamName),
                () => Ensure.That(value, ParamName).Matches(match));
        }

        [Fact]
        public void SizeIs_When_null_It_throws_ArgumentNullException()
        {
            string value = null;
            var expected = 1;

            AssertIsNotNull(
                () => Ensure.String.SizeIs(value, expected, ParamName),
                () => EnsureArg.SizeIs(value, expected, ParamName),
                () => Ensure.That(value, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_string_It_throws_ArgumentException()
        {
            var value = "Some string";
            var expected = value.Length + 1;

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_SizeIs_Failed, expected, value.Length),
                () => Ensure.String.SizeIs(value, expected, ParamName),
                () => EnsureArg.SizeIs(value, expected, ParamName),
                () => Ensure.That(value, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_constraint_It_should_not_throw()
        {
            var value = "Some string";

            ShouldNotThrow(
                () => Ensure.String.SizeIs(value, value.Length, ParamName),
                () => EnsureArg.SizeIs(value, value.Length, ParamName));
        }

        [Fact]
        public void IsEqualTo_When_different_values_It_throws_ArgumentException()
        {
            const string value = "The value";
            const string expected = "Other value";

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_IsEqualTo_Failed, value, expected),
                () => Ensure.String.IsEqualTo(value, expected, ParamName),
                () => EnsureArg.IsEqualTo(value, expected, ParamName),
                () => Ensure.That(value, ParamName).IsEqualTo(expected));
        }

        [Fact]
        public void IsEqualTo_When_same_value_It_should_not_throw()
        {
            const string value = "The value";
            const string expected = value;

            ShouldNotThrow(
                () => Ensure.String.IsEqualTo(value, expected, ParamName),
                () => EnsureArg.IsEqualTo(value, expected, ParamName),
                () => Ensure.That(value, ParamName).IsEqualTo(expected),
                () => Ensure.String.Is(value, expected, ParamName),
                () => EnsureArg.Is(value, expected, ParamName),
                () => Ensure.That(value, ParamName).Is(expected));
        }

        [Fact]
        public void IsEqualTo_When_same_value_by_specific_compare_It_should_not_throw()
        {
            const string value = "The value";
            const string expected = "the value";

            ShouldNotThrow(
                () => Ensure.String.IsEqualTo(value, expected, StringComparison.OrdinalIgnoreCase, ParamName),
                () => EnsureArg.IsEqualTo(value, expected, StringComparison.OrdinalIgnoreCase, ParamName),
                () => Ensure.That(value, ParamName).IsEqualTo(expected, StringComparison.OrdinalIgnoreCase),
                () => Ensure.String.Is(value, expected, StringComparison.OrdinalIgnoreCase, ParamName),
                () => EnsureArg.Is(value, expected, StringComparison.OrdinalIgnoreCase, ParamName),
                () => Ensure.That(value, ParamName).Is(expected, StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void IsNotEqualTo_When_same_values_It_throws_ArgumentException()
        {
            const string value = "The value";

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNot_Failed, value, value),
                () => Ensure.String.IsNotEqualTo(value, value, ParamName),
                () => EnsureArg.IsNotEqualTo(value, value, ParamName),
                () => Ensure.That(value, ParamName).IsNotEqualTo(value),
                () => Ensure.String.IsNot(value, value, ParamName),
                () => EnsureArg.IsNot(value, value, ParamName),
                () => Ensure.That(value, ParamName).IsNot(value));
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_by_casing_using_non_case_sensitive_compare_It_throws_ArgumentException()
        {
            const string value = "The value";
            var compareTo = value.ToLower(CultureInfo.CurrentCulture);

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNot_Failed, value, compareTo),
                () => Ensure.String.IsNotEqualTo(value, compareTo, StringComparison.OrdinalIgnoreCase, ParamName),
                () => EnsureArg.IsNotEqualTo(value, compareTo, StringComparison.OrdinalIgnoreCase, ParamName),
                () => Ensure.That(value, ParamName).IsNotEqualTo(compareTo, StringComparison.OrdinalIgnoreCase),
                () => Ensure.String.IsNot(value, compareTo, StringComparison.OrdinalIgnoreCase, ParamName),
                () => EnsureArg.IsNot(value, compareTo, StringComparison.OrdinalIgnoreCase, ParamName),
                () => Ensure.That(value, ParamName).IsNot(compareTo, StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_It_should_not_throw()
        {
            var value = "The value";

            ShouldNotThrow(
                () => Ensure.String.IsNotEqualTo(value, value + "a", ParamName),
                () => EnsureArg.IsNotEqualTo(value, value + "a", ParamName),
                () => Ensure.That(value, ParamName).IsNotEqualTo(value + "a"),
                () => Ensure.String.IsNot(value, value + "a", ParamName),
                () => EnsureArg.IsNot(value, value + "a", ParamName),
                () => Ensure.That(value, ParamName).IsNot(value + "a"));
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_by_casing_using_case_sensitive_compare_It_should_not_throw()
        {
            var value = "The value";
            var compareTo = value.ToLower(CultureInfo.CurrentCulture);

            ShouldNotThrow(
                () => Ensure.String.IsNotEqualTo(value, compareTo, StringComparison.Ordinal, ParamName),
                () => EnsureArg.IsNotEqualTo(value, compareTo, StringComparison.Ordinal, ParamName),
                () => Ensure.That(value, ParamName).IsNotEqualTo(compareTo, StringComparison.Ordinal),
                () => Ensure.String.IsNot(value, compareTo, StringComparison.Ordinal, ParamName),
                () => EnsureArg.IsNot(value, compareTo, StringComparison.Ordinal, ParamName),
                () => Ensure.That(value, ParamName).IsNot(compareTo, StringComparison.Ordinal));
        }

        [Fact]
        public void IsGuid_When_null_It_should_not_throw_ArgumentNullException()
        {
            string value = null;

            ShouldThrowButNot<ArgumentNullException>(
                () => Ensure.String.IsGuid(value, ParamName),
                () => EnsureArg.IsGuid(value, ParamName),
                () => Ensure.That(value, ParamName).IsGuid());
        }

        [Fact]
        public void IsGuid_When_null_It_should_throw_ArgumentException()
        {
            string value = null;

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_IsGuid_Failed, value),
                () => Ensure.String.IsGuid(value, ParamName),
                () => EnsureArg.IsGuid(value, ParamName),
                () => Ensure.That(value, ParamName).IsGuid());
        }

        [Fact]
        public void IsGuid_When_is_not_Guid_throws_ArgumentException()
        {
            const string value = "324-3243-123-23";

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_IsGuid_Failed, value),
                () => Ensure.String.IsGuid(value, ParamName),
                () => EnsureArg.IsGuid(value, ParamName),
                () => Ensure.That(value, ParamName).IsGuid());
        }

        [Fact]
        public void IsGuid_When_valid_Guid_It_should_not_throw_and_should_return_Guid()
        {
            var value = Guid.NewGuid();
            var valueAsString = value.ToString();

            ShouldNotThrow(
                () => Ensure.String.IsGuid(valueAsString, ParamName),
                () => EnsureArg.IsGuid(valueAsString, ParamName),
                () => Ensure.That(valueAsString, ParamName).IsGuid());

            ShouldReturn(
                value,
                () => Ensure.String.IsGuid(valueAsString),
                () => EnsureArg.IsGuid(valueAsString));
        }

        [Fact]
        public void StartsWith_When_DoesStartWith_It_should_not_throw()
        {
            var value = "startsWith_foobar";
            var startPart = "startsWith";

            ShouldNotThrow(
                () => Ensure.String.StartsWith(value, startPart, ParamName),
                () => EnsureArg.StartsWith(value, startPart, ParamName),
                () => Ensure.That(value, ParamName).StartsWith(startPart));
        }

        [Fact]
        public void StartsWith_When_DoesNotStartWith_It_should_throw()
        {
            var value = "startsWith_foobar";
            var startPart = "otherString";

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_StartsWith_Failed, value, startPart),
                () => Ensure.String.StartsWith(value, startPart, ParamName),
                () => EnsureArg.StartsWith(value, startPart, ParamName),
                () => Ensure.That(value, ParamName).StartsWith(startPart));
        }

        [Fact]
        public void IsAllLettersOrDigits_WhenStringIsAllLettersAndDigits_It_should_not_throw()
        {
            const string value = "aBcDeFgHiJkLmNoPqRsTuVwXyZ0123456789";

            ShouldNotThrow(
                () => Ensure.String.IsAllLettersOrDigits(value, ParamName),
                () => EnsureArg.IsAllLettersOrDigits(value, ParamName),
                () => Ensure.That(value, ParamName).IsAllLettersOrDigits());
        }

        [Fact]
        public void IsAllLettersOrDigits_WhenStringIsAllDigits_It_should_not_throw()
        {
            const string value = "0123456789";

            ShouldNotThrow(
                () => Ensure.String.IsAllLettersOrDigits(value, ParamName),
                () => EnsureArg.IsAllLettersOrDigits(value, ParamName),
                () => Ensure.That(value, ParamName).IsAllLettersOrDigits());
        }

        [Fact]
        public void IsAllLettersOrDigits_WhenStringIsAllLetters_It_should_not_throw()
        {
            const string value = "aBcDeFgHiJkLmNoPqRsTuVwXyZ";

            ShouldNotThrow(
                () => Ensure.String.IsAllLettersOrDigits(value, ParamName),
                () => EnsureArg.IsAllLettersOrDigits(value, ParamName),
                () => Ensure.That(value, ParamName).IsAllLettersOrDigits());
        }

        [Fact]
        public void IsAllLettersOrDigits_WhenStringDoesNotHaveLettersOrDigits_It_should_throw()
        {
            const string value = "<:)-+-<";

            ShouldThrow<ArgumentException>(
                string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Strings_IsAllLettersOrDigits_Failed, value),
                () => Ensure.String.IsAllLettersOrDigits(value, ParamName),
                () => EnsureArg.IsAllLettersOrDigits(value, ParamName),
                () => Ensure.That(value, ParamName).IsAllLettersOrDigits());
        }
    }
}
