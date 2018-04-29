using System;
using EnsureThat;
using Xunit;

namespace UnitTests
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
            var value = (T?)null;

            ShouldThrow<ArgumentNullException>(
                ExceptionMessages.Common_IsNotNull_Failed,
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        private void Assert_IsNotNull_WhenNonNullInt_ShouldNotThrow<T>(T? value) where T : struct
        {
            ShouldNotThrow(
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }
    }
}