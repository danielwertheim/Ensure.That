using System;
using EnsureThat.Resources;
using NUnit.Framework;

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
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNull
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
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNullOrEmpty
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
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNullOrEmpty
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
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNullOrWhiteSpace
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
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNullOrWhiteSpace
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
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNullOrWhiteSpace
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
    }
}