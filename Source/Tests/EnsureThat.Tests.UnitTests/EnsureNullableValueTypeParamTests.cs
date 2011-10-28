using System;
using EnsureThat.Resources;
using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class EnsureNullableValueTypeParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Test]
        public void IsNotNull_WhenNullInt_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<int>();
        }

        [Test]
        public void IsNotNull_WhenNonNullInt_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<int>(42);
        }

        [Test]
        public void IsNotNull_WhenNullLong_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<long>();
        }

        [Test]
        public void IsNotNull_WhenNonNullLong_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<long>(42);
        }

        [Test]
        public void IsNotNull_WhenNullDouble_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<double>();
        }

        [Test]
        public void IsNotNull_WhenNonNullDouble_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<double>(3.14);
        }

        [Test]
        public void IsNotNull_WhenNullDecimal_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<decimal>();
        }

        [Test]
        public void IsNotNull_WhenNonNullDecimal_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<decimal>(3.14m);
        }

        [Test]
        public void IsNotNull_WhenNullDateTime_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<DateTime>();
        }

        [Test]
        public void IsNotNull_WhenNonNullDateTime_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<DateTime>(new DateTime(2000, 1, 1));
        }

        [Test]
        public void IsNotNull_WhenNullBool_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<bool>();
        }

        [Test]
        public void IsNotNull_WhenNonNullBool_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<bool>(true);
        }

        private void Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<T>() where T : struct 
        {
            var ex = Assert.Throws<ArgumentNullException>(
                () => Ensure.That((T?)null, ParamName).IsNotNull());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNull
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        private void Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<T>(T? value) where T : struct 
        {
            var returnedValue = Ensure.That(value, ParamName).IsNotNull();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }
    }
}