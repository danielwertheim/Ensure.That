using System;
using FluentAssertions;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureNullableValueTypeParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotNull_WhenNullInt_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<int>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullInt_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<int>(42);
        }

        [Fact]
        public void IsNotNull_WhenNullLong_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<long>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullLong_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<long>(42);
        }

        [Fact]
        public void IsNotNull_WhenNullDouble_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<double>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullDouble_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<double>(3.14);
        }

        [Fact]
        public void IsNotNull_WhenNullDecimal_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<decimal>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullDecimal_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<decimal>(3.14m);
        }

        [Fact]
        public void IsNotNull_WhenNullDateTime_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<DateTime>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullDateTime_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<DateTime>(new DateTime(2000, 1, 1));
        }

        [Fact]
        public void IsNotNull_WhenNullBool_ThrowsArgumentException()
        {
            Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<bool>();
        }

        [Fact]
        public void IsNotNull_WhenNonNullBool_ReturnsPassedValue()
        {
            Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<bool>(true);
        }

        private void Assert_IsNotNull_WhenNullInt_ThrowsArgumentException<T>() where T : struct 
        {
            AssertAll<ArgumentNullException>(
                ExceptionMessages.EnsureExtensions_IsNotNull,
                () => Ensure.That((T?)null, ParamName).IsNotNull(),
                () => EnsureArg.IsNotNull((T?)null, ParamName));
        }

        private void Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<T>(T? value) where T : struct 
        {
            var returnedValue = Ensure.That(value, ParamName).IsNotNull();
            AssertReturnedAsExpected(returnedValue, value);

            Action a = () => EnsureArg.IsNotNull(value, ParamName);
            a.ShouldNotThrow();
        }
    }
}