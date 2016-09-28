using System;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureBoolParamTests : UnitTestBase
    {
        [Fact]
        public void IsTrue_WhenFalseExpression_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(false, ParamName).IsTrue());
            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotTrue);

            var ex2 = Assert.Throws<ArgumentException>(() => EnsureArg.IsTrue(false, ParamName));
            AssertThrowedAsExpected(ex2, ExceptionMessages.EnsureExtensions_IsNotTrue);
        }

        [Fact]
        public void IsTrue_WhenTrueExpression_ReturnsPassedValue()
        {
            var returnedValue = Ensure.That(true, ParamName).IsTrue();

            AssertReturnedAsExpected(returnedValue, true);
        }

        [Fact]
        public void IsFalse_WhenTrueExpression_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(true, ParamName).IsFalse());
            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotFalse);

            var ex2 = Assert.Throws<ArgumentException>(() => EnsureArg.IsFalse(true, ParamName));
            AssertThrowedAsExpected(ex2, ExceptionMessages.EnsureExtensions_IsNotFalse);
        }

        [Fact]
        public void IsFalse_WhenFalseExpression_ReturnsPassedValue()
        {
            var returnedValue = Ensure.That(false, ParamName).IsFalse();

            AssertReturnedAsExpected(returnedValue, false);
        }
    }
}