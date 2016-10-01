using FluentAssertions;
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
            AssertThrowedAsExpected(ex, ExceptionMessages.Booleans_IsTrueFailed);

            var ex2 = Assert.Throws<ArgumentException>(() => EnsureArg.IsTrue(false, ParamName));
            AssertThrowedAsExpected(ex2, ExceptionMessages.Booleans_IsTrueFailed);
        }

        [Fact]
        public void IsTrue_WhenTrueExpression_ShouldNotThrow()
        {
            var returnedValue = Ensure.That(true, ParamName).IsTrue();
            AssertReturnedAsExpected(returnedValue, true);

            Action a = () => EnsureArg.IsTrue(true, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void IsFalse_WhenTrueExpression_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(true, ParamName).IsFalse());
            AssertThrowedAsExpected(ex, ExceptionMessages.Booleans_IsFalseFailed);

            var ex2 = Assert.Throws<ArgumentException>(() => EnsureArg.IsFalse(true, ParamName));
            AssertThrowedAsExpected(ex2, ExceptionMessages.Booleans_IsFalseFailed);
        }

        [Fact]
        public void IsFalse_WhenFalseExpression_ShouldNotThrow()
        {
            var returnedValue = Ensure.That(false, ParamName).IsFalse();
            AssertReturnedAsExpected(returnedValue, false);

            Action a = () => EnsureArg.IsFalse(false, ParamName);
            a.ShouldNotThrow();
        }
    }
}