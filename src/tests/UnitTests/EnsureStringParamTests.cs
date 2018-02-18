using System;
using System.Text.RegularExpressions;
using EnsureThat;

using UnitTests.TestWrappers;

using Xunit;

namespace UnitTests
{
    public class EnsureStringParamTests : UnitTestBase
    {
        private static void AssertIsNotNull(params Action[] actions) => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private static void AssertIsNotEmpty(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Strings_IsNotEmpty_Failed, actions);

        private static void AssertIsNotNullOrEmpty(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, actions);

        private static void AssertIsNotNullOrWhiteSpace(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, actions);
        
        /// <remarks>
        /// Would probably work to move this to the base class, making the base class take a type
        /// parameter for what validation type it runs on (e.g. IStringArg).
        /// 
        /// The primary concern is that writing the test should not involve the overhead/boilerplate
        /// of testing all the different syntaxes, the test should say what in and what out.
        /// 
        /// If we support this route, I'll look into how to even remove the RunTest from the tests, if
        /// xUnit provides a way to do a before/after iteration or maybe via Theory.
        /// </remarks>
        private static void RunTest(Action<IStringArg> testContents)
        {
            try
            {
                testContents(Ensure.String);
            }
            catch (Exception e)
            {
                throw new Exception(
                    message: "Method failed while invoking on validator syntax",
                    innerException: e);
            }
            try
            {
                testContents(new EnsureArgToStringArgAdapter());
            }
            catch (Exception e)
            {
                throw new Exception(
                    message: "Method failed while invoking on EnsureArg syntax",
                    innerException: e);
            }
            try
            {
                testContents(new EnsureThatToStringArgAdapter());
            }
            catch (Exception e)
            {
                throw new Exception(
                    message: "Method failed while invoking on Ensure.That syntax",
                    innerException: e);
            }
        }

        [Fact]
        public void IsNotNull_WhenStringIsNull_ThrowsArgumentNullException()
        {
            RunTest(
                validator =>
                {
                    string value = null;

                    AssertIsNotNull(
                        () => validator.IsNotNull(value, ParamName));
                });
        }

        [Fact]
        public void IsNotNull_WhenStringIsNotNull_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = string.Empty;
                    ShouldNotThrow(
                        () => validator.IsNotNull(value, ParamName));
                });
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNull_ThrowsArgumentNullException()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    AssertIsNotNull(
                        () => validator.IsNotNullOrEmpty(value, ParamName));
                });
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            RunTest(
                validator =>
                {
                    var value = string.Empty;
                    AssertIsNotNullOrEmpty(
                        () => validator.IsNotNullOrEmpty(value, ParamName));
                });
        }

        [Fact]
        public void IsNotNullOrEmpty_WhenStringIsNotNullOrEmpty_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = " ";
                    ShouldNotThrow(
                        () => validator.IsNotNullOrEmpty(value, ParamName));
                });
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringIsNull_ThrowsArgumentNullException()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    AssertIsNotNull(() => validator.IsNotNullOrWhiteSpace(value, ParamName));
                });
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void IsNotNullOrWhiteSpace_WhenStringIsInvalid_ThrowsArgumentException(string value)
        {
            RunTest(
                validator =>
                {
                    AssertIsNotNullOrWhiteSpace(
                        () => validator.IsNotNullOrWhiteSpace(value, ParamName));
                });
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenStringHasValue_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = "delta";
                    ShouldNotThrow(
                        () => validator.IsNotNullOrWhiteSpace(value, ParamName));
                });
        }

        [Fact]
        public void IsNotEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            RunTest(
                validator =>
                {
                    var value = string.Empty;
                    AssertIsNotEmpty(
                        () => validator.IsNotEmpty(value, ParamName));
                });
        }

        [Fact]
        public void IsNotEmpty_WhenStringHasValue_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = "delta";
                    ShouldNotThrow(
                        () => validator.IsNotEmpty(value, ParamName));
                });
        }

        [Fact]
        public void IsNotEmpty_WhenStringIsNull_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    ShouldNotThrow(
                        () => validator.IsNotEmpty(value, ParamName));
                });
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsNull_ThrowsArgumentNullException()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    AssertIsNotNull(
                        () => validator.HasLengthBetween(value, 1, 2, ParamName));
                });
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsToShort_ThrowsArgumentException()
        {
            RunTest(
                validator =>
                {
                    const int low = 2;
                    const int high = 4;
                    var value = new string('a', low - 1);
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort, low, high, value.Length),
                        () => validator.HasLengthBetween(value, low, high, ParamName));
                });
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsToLong_ThrowsArgumentException()
        {
            RunTest(
                validator =>
                {
                    const int low = 2;
                    const int high = 4;
                    var value = new string('a', high + 1);
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong, low, high, value.Length),
                        () => validator.HasLengthBetween(value, low, high, ParamName));
                });
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsLowLimit_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    const int low = 2;
                    const int high = 4;
                    var value = new string('a', low);
                    ShouldNotThrow(
                        () => validator.HasLengthBetween(value, low, high, ParamName));
                });
        }

        [Fact]
        public void HasLengthBetween_WhenStringIsHighLimit_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    const int low = 2;
                    const int high = 4;
                    var value = new string('a', high);
                    ShouldNotThrow(
                        () => validator.HasLengthBetween(value, low, high, ParamName));
                });
        }

        [Fact]
        public void Matches_WhenUrlStringDoesNotMatchStringPattern_ThrowsArgumentException()
        {
            RunTest(
                validator =>
                {
                    const string value = @"incorrect";
                    const string match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_Matches_Failed, value, match),
                        () => validator.Matches(value, match, ParamName));
                });
        }

        [Fact]
        public void Matches_WhenUrlStringDoesNotMatchRegex_ThrowsArgumentException()
        {
            RunTest(
                validator =>
                {
                    const string value = @"incorrect";
                    var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_Matches_Failed, value, match),
                        () => validator.Matches(value, match, ParamName));
                });
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesStringPattern_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    const string value = @"http://google.com:8080";
                    const string match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";
                    ShouldNotThrow(
                        () => validator.Matches(value, match, ParamName));
                });
        }

        [Fact]
        public void Matches_WhenUrlStringMatchesRegex_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    const string value = @"http://google.com:8080";
                    var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");
                    ShouldNotThrow(
                        () => validator.Matches(value, match, ParamName));
                });
        }

        [Fact]
        public void SizeIs_When_null_It_throws_ArgumentNullException()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    var expected = 1;
                    AssertIsNotNull(
                        () => validator.SizeIs(value, expected, ParamName));
                });
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_string_It_throws_ArgumentException()
        {
            RunTest(
                validator =>
                {
                    var value = "Some string";
                    var expected = value.Length + 1;
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_SizeIs_Failed, expected, value.Length),
                        () => validator.SizeIs(value, expected, ParamName));
                });
        }

        [Fact]
        public void SizeIs_When_matching_constraint_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = "Some string";
                    ShouldNotThrow(() => validator.SizeIs(value, value.Length, ParamName));
                });
        }

        [Fact]
        public void IsEqualTo_When_different_values_It_throws_ArgumentException()
        {
            RunTest(
                validator =>
                {
                    const string value = "The value";
                    const string expected = "Other value";
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_IsEqualTo_Failed, value, expected),
                        () => validator.IsEqualTo(value, expected, ParamName));
                });
        }

        [Fact]
        public void IsEqualTo_When_same_value_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    const string value = "The value";
                    const string expected = value;
                    ShouldNotThrow(
                        () => validator.IsEqualTo(value, expected, ParamName));
                });
        }

        [Fact]
        public void IsEqualTo_When_same_value_by_specific_compare_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    const string value = "The value";
                    const string expected = "the value";
                    ShouldNotThrow(
                        () => validator.IsEqualTo(value, expected, StringComparison.OrdinalIgnoreCase, ParamName));
                });
        }

        [Fact]
        public void IsNotEqualTo_When_same_values_It_throws_ArgumentException()
        {
            RunTest(
                validator =>
                {
                    const string value = "The value";
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Comp_IsNot_Failed, value, value),
                        () => validator.IsNotEqualTo(value, value, ParamName));
                });
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_by_casing_using_non_case_sensitive_compare_It_throws_ArgumentException()
        {
            RunTest(
                validator =>
                {
                    const string value = "The value";
                    var compareTo = value.ToLower();
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Comp_IsNot_Failed, value, compareTo),
                        () => validator.IsNotEqualTo(value, compareTo, StringComparison.OrdinalIgnoreCase, ParamName));
                });
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = "The value";
                    ShouldNotThrow(
                        () => validator.IsNotEqualTo(value, value + "a", ParamName));
                });
        }

        [Fact]
        public void IsNotEqualTo_When_different_values_by_casing_using_case_sensitive_compare_It_should_not_throw()
        {
            RunTest(
                validator =>
                {
                    var value = "The value";
                    ShouldNotThrow(
                        () => validator.IsNotEqualTo(value, value.ToLower(), StringComparison.Ordinal, ParamName));
                });
        }

        [Fact]
        public void IsGuid_When_null_It_should_not_throw_ArgumentNullException()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    ShouldThrowButNot<ArgumentNullException>(
                        () => validator.IsGuid(value, ParamName));
                });
        }

        [Fact]
        public void IsGuid_When_null_It_should_throw_ArgumentException()
        {
            RunTest(
                validator =>
                {
                    string value = null;
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_IsGuid_Failed, value),
                        () => validator.IsGuid(value, ParamName));
                });
        }

        [Fact]
        public void IsGuid_When_is_not_Guid_throws_ArgumentException()
        {
            RunTest(
                validator =>
                {
                    const string value = "324-3243-123-23";
                    ShouldThrow<ArgumentException>(
                        string.Format(ExceptionMessages.Strings_IsGuid_Failed, value),
                        () => validator.IsGuid(value, ParamName));
                });
        }

        [Fact]
        public void IsGuid_When_valid_Guid_returns_Guid()
        {
            RunTest(
                validator =>
                {
                    var value = Guid.NewGuid().ToString();
                    
                    ShouldNotThrow(() => validator.IsGuid(value, ParamName));
                });
        }
    }
}