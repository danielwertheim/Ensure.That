using System;
using System.Text.RegularExpressions;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureStringParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotNull_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentNullException>(
                () => Ensure.That(value, ParamName).IsNotNull());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNull);
        }

        [Fact]
        public void IsNotNull_WhenStringIsNotNull_ReturnsPassedString()
        {
            var value = string.Empty;

            var returnedValue = Ensure.That(value, ParamName).IsNotNull();

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNull_ThrowsArgumentException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            string value = string.Empty;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNotNullOrEmpty_ReturnsPassedString()
        {
            var value = " ";

            var returnedValue = Ensure.That(value, ParamName).IsNotNull();

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringIsEmpty_ThrowsArgumentNullException()
        {
            string value = string.Empty;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringIsWhiteSpace_ThrowsArgumentNullException()
        {
            string value = " ";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringHasValue_ReturnsPassedString()
        {
            var value = "delta";

            var returnedValue = Ensure.That(value, ParamName).IsNotNullOrWhiteSpace();

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).HasLengthBetween(1, 2));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);
        }

        [Fact]
        public void HasLengthBetween_WhenStringIs1CharacterLong_ThrowsArgumentException()
        {
            string value = "a";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).HasLengthBetween(2, 4));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotInRange_ToShort, 2, 4, 1);
        }

        [Fact]
        public void HasLengthBetween_WhenStringIs5CharactersLong_ThrowsArgumentException()
        {
            string value = "abcde";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).HasLengthBetween(2, 4));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLong, 2, 4, 5);
        }

        [Fact]
        public void HasLengthBetween_WhenStringIs2CharactersLong_ReturnsPassedString()
        {
            var value = "ab";

            var returnedValue = Ensure.That(value, ParamName).HasLengthBetween(2, 4);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void HasLengthBetween_WhenStringIs4CharactersLong_ReturnsPassedString()
        {
            var value = "abcd";

            var returnedValue = Ensure.That(value, ParamName).HasLengthBetween(2, 4);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesStringPattern_ThrowsArgumentException()
        {
            var value = @"incorrect";
            var match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).Matches(match));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_NoMatch, value, match);
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesRegexPattern_ThrowsArgumentException()
        {
            var value = @"incorrect";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).Matches(match));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_NoMatch, value, match);
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesStringPattern_ReturnsPassedString()
        {
            var value = @"http://google.com:8080";
            var match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";

            var returnedValue = Ensure.That(value, ParamName).Matches(match);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesRegexPattern_ReturnsPassedString()
        {
            var value = @"http://google.com:8080";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

            var returnedValue = Ensure.That(value, ParamName).Matches(match);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void SizeIs_When_matching_length_of_array_It_returns_passed_values()
        {
            var value = "Some string";

            var returned = Ensure.That(value, ParamName).SizeIs(value.Length);

            AssertReturnedAsExpected(returned, value);
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_string_It_throws_ArgumentException()
        {
            var value = "Some string";
            var expected = value.Length + 1;

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(value, ParamName).SizeIs(expected));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_SizeIs_Wrong, expected, value.Length);
        }

        [Fact]
        public void IsEqualTo_When_same_values_It_returns_passed_value()
        {
            const string value = "The value";
            const string expected = value;

            var returnedValue = Ensure.That(value, ParamName).IsEqualTo(expected);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void IsEqualTo_When_same_values_by_specific_compare_It_returns_passed_value()
        {
            const string value = "The value";
            const string expected = "the value";

            var returnedValue = Ensure.That(value, ParamName).IsEqualTo(expected, StringComparison.OrdinalIgnoreCase);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void IsEqualTo_When_different_values_It_throws_ArgumentException()
        {
            var value = "The value";
            const string expected = "Other value";

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(value, ParamName).IsEqualTo(expected));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_Is_Failed, value, expected);
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_It_returns_passed_value()
        {
            var value = "The value";
            const string expected = "Other value";

            var returnedValue = Ensure.That(value, ParamName).IsNotEqualTo(expected);

            AssertReturnedAsExpected(returnedValue, value);
        }

        [Fact]
        public void IsNotEqualTo_When_same_values_It_throws_ArgumentException()
        {
            const string value = "The value";
            const string expected = value;

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(value, ParamName).IsNotEqualTo(expected));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNot_Failed, value, expected);
        }

        [Fact]
        public void IsGuid_When_is_not_Guid_throws_ArgumentException()
        {
            var value = "324-3243-123-23";
            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(value, ParamName).IsGuid());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotGuid, value);
        }

        [Fact]
        public void IsGuid_When_valid_Guid_returns_Guid()
        {
            var value = Guid.NewGuid().ToString();

            var returnedValue = Ensure.That(value, ParamName).IsGuid();

            AssertReturnedAsExpected(returnedValue, value);
        }
    }
}