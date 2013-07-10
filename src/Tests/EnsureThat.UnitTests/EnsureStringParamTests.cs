using System;
using EnsureThat.Resources;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class EnsureStringParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Test]
        public void IsNotNull_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentNullException>(
                () => Ensure.That(value, ParamName).IsNotNull());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNull
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsNotNull_WhenStringIsNotNull_ReturnsPassedString()
        {
            var value = string.Empty;

            var returnedValue = Ensure.That(value, ParamName).IsNotNull();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsNotNullOrEmpty_WhenStringIsNull_ThrowsArgumentException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsNotNullOrEmpty_WhenStringIsEmpty_ThrowsArgumentException()
        {
            string value = string.Empty;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrEmpty());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsNotNullOrEmpty_WhenStringIsNotNullOrEmpty_ReturnsPassedString()
        {
            var value = " ";

            var returnedValue = Ensure.That(value, ParamName).IsNotNull();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsNotNullOrWhiteSpace_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsNotNullOrWhiteSpace_WhenStringIsEmpty_ThrowsArgumentNullException()
        {
            string value = string.Empty;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsNotNullOrWhiteSpace_WhenStringIsWhiteSpace_ThrowsArgumentNullException()
        {
            string value = " ";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsNotNullOrWhiteSpace());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsNotNullOrWhiteSpace_WhenStringHasValue_ReturnsPassedString()
        {
            var value = "delta";

            var returnedValue = Ensure.That(value, ParamName).IsNotNullOrWhiteSpace();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void HasLengthBetween_WhenStringIsNull_ThrowsArgumentNullException()
        {
            string value = null;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).HasLengthBetween(1, 2));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasLengthBetween_WhenStringIs1CharacterLong_ThrowsArgumentException()
        {
            string value = "a";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).HasLengthBetween(2, 4));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(String.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToShort, 2, 4, 1)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasLengthBetween_WhenStringIs5CharactersLong_ThrowsArgumentException()
        {
            string value = "abcde";

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).HasLengthBetween(2, 4));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(String.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToLong, 2, 4, 5)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasLengthBetween_WhenStringIs2CharactersLong_ReturnsPassedString()
        {
            var value = "ab";

            var returnedValue = Ensure.That(value, ParamName).HasLengthBetween(2, 4);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void HasLengthBetween_WhenStringIs4CharactersLong_ReturnsPassedString()
        {
            var value = "abcd";

            var returnedValue = Ensure.That(value, ParamName).HasLengthBetween(2, 4);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Matches_WhenUrlStringMatchesStringPattern_ThrowsArgumentException()
        {
            var value = @"incorrect";
            var match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).Matches(match));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(String.Format(ExceptionMessages.EnsureExtensions_NoMatch, value, match)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Matches_WhenUrlStringMatchesRegexPattern_ThrowsArgumentException()
        {
            var value = @"incorrect";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).Matches(match));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(String.Format(ExceptionMessages.EnsureExtensions_NoMatch, value, match)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Matches_WhenUrlStringMatchesStringPattern_ReturnsPassedString()
        {
            var value = @"http://google.com:8080";
            var match = @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*";
            var returnedValue = Ensure.That(value, ParamName).Matches(match);
            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Matches_WhenUrlStringMatchesRegexPattern_ReturnsPassedString()
        {
            var value = @"http://google.com:8080";
            var match = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");
            var returnedValue = Ensure.That(value, ParamName).Matches(match);
            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }
    }
}