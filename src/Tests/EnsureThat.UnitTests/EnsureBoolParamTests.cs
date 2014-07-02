using System;
using EnsureThat.Resources;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureBoolParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Fact]
        public void IsTrue_WhenFalseExpression_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(false, ParamName).IsTrue());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsNotTrue
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsTrue_WhenTrueExpression_ReturnsPassedValue()
        {
            var returnedValue = Ensure.That(true, ParamName).IsTrue();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.True(returnedValue.Value);
        }

        [Fact]
        public void IsFalse_WhenTrueExpression_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(true, ParamName).IsFalse());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsNotFalse
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsFalse_WhenFalseExpression_ReturnsPassedValue()
        {
            var returnedValue = Ensure.That(false, ParamName).IsFalse();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.False(returnedValue.Value);
        }
    }
}