using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureBoolParamTests : UnitTestBase
    {
        [Fact]
        public void IsTrue_WhenFalseExpression_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            ExceptionMessages.Booleans_IsTrueFailed,
            () => Ensure.That(false, ParamName).IsTrue(),
            () => EnsureArg.IsTrue(false, ParamName));

        [Fact]
        public void IsTrue_WhenTrueExpression_ShouldNotThrow() => ShouldNotThrow(
            () => Ensure.That(true, ParamName).IsTrue(),
            () => EnsureArg.IsTrue(true, ParamName));

        [Fact]
        public void IsFalse_WhenTrueExpression_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            ExceptionMessages.Booleans_IsFalseFailed,
            () => Ensure.That(true, ParamName).IsFalse(),
            () => EnsureArg.IsFalse(true, ParamName));

        [Fact]
        public void IsFalse_WhenFalseExpression_ShouldNotThrow() => ShouldNotThrow(
            () => Ensure.That(false, ParamName).IsFalse(),
            () => EnsureArg.IsFalse(false, ParamName));
    }
}