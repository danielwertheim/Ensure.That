using System;
using EnsureThat.Resources;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureNullableValueTypeParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Fact]
        public void IsNotNull_WhenNullInt_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<int>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullInt_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<int>(42);
        }

        [Fact]
        public void IsNotNull_WhenNullLong_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<long>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullLong_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<long>(42);
        }

        [Fact]
        public void IsNotNull_WhenNullDouble_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<double>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullDouble_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<double>(3.14);
        }

        [Fact]
        public void IsNotNull_WhenNullDecimal_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<decimal>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullDecimal_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<decimal>(3.14m);
        }

        [Fact]
        public void IsNotNull_WhenNullDateTime_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<DateTime>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullDateTime_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<DateTime>(new DateTime(2000, 1, 1));
        }

        [Fact]
        public void IsNotNull_WhenNullBool_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<bool>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullBool_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<bool>(true);
        }

        private void Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<T>() where T : struct 
        {
            var ex = Assert.Throws<ArgumentNullException>(
                () => Ensure.That((T?)null, ParamName).IsNotNull());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsNotNull
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        private void Assert_IsNotNull_WhenNonNullInt_ReturnsPassedValue<T>(T? value) where T : struct 
        {
            var returnedValue = Ensure.That(value, ParamName).IsNotNull();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(value, returnedValue.Value);
        }
    }
}