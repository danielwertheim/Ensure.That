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
            () => Ensure.Bool.IsTrue(false, ParamName),
            () => EnsureArg.IsTrue(false, ParamName));

        [Fact]
        public void IsTrue_WhenTrueExpression_ShouldNotThrow() => ShouldNotThrow(
            () => Ensure.Bool.IsTrue(true, ParamName),
            () => EnsureArg.IsTrue(true, ParamName));

        [Fact]
        public void IsFalse_WhenTrueExpression_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            ExceptionMessages.Booleans_IsFalseFailed,
            () => Ensure.Bool.IsFalse(true, ParamName),
            () => EnsureArg.IsFalse(true, ParamName));

        [Fact]
        public void IsFalse_WhenFalseExpression_ShouldNotThrow() => ShouldNotThrow(
            () => Ensure.Bool.IsFalse(false, ParamName),
            () => EnsureArg.IsFalse(false, ParamName));
    }
}