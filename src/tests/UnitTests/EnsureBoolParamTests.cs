using System;
using EnsureThat;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class EnsureBoolParamTests : UnitTestBase
    {
        [Fact]
        public void IsTrue_WhenFalseExpression_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            ExceptionMessages.Booleans_IsTrueFailed,
            () => Ensure.Bool.IsTrue(false, ParamName),
            () => EnsureArg.IsTrue(false, ParamName),
            () => Ensure.That(false, ParamName).IsTrue());

        [Fact]
        public void IsTrue_WhenTrueExpression_ShouldNotThrow() => ShouldNotThrow(
            () => Ensure.Bool.IsTrue(true, ParamName),
            () => EnsureArg.IsTrue(true, ParamName),
            () => Ensure.That(true, ParamName).IsTrue());

        [Fact]
        public void IsFalse_WhenTrueExpression_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            ExceptionMessages.Booleans_IsFalseFailed,
            () => Ensure.Bool.IsFalse(true, ParamName),
            () => EnsureArg.IsFalse(true, ParamName),
            () => Ensure.That(true, ParamName).IsFalse());

        [Fact]
        public void IsFalse_WhenFalseExpression_ShouldNotThrow() => ShouldNotThrow(
            () => Ensure.Bool.IsFalse(false, ParamName),
            () => EnsureArg.IsFalse(false, ParamName),
            () => Ensure.That(false, ParamName).IsFalse());

        [Fact]
        public void IsNullOrTrue_Should_Throw_ArgumentException_When_Value_IsFalse()
        {
            var act = new Action(() => Ensure.Bool.IsNullOrTrue(false));
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void IsNullOrTrue_Should_Return_Null_When_Value_IsNull()
        {
            var value = Ensure.Bool.IsNullOrTrue(null);
            value.Should().BeNull();
        }

        [Fact]
        public void IsNullOrTrue_Should_Return_True_When_Value_IsTrue()
        {
            var value = Ensure.Bool.IsNullOrTrue(true);
            value.Should().BeTrue();
        }

        [Fact]
        public void IsNullOrFalse_Should_Throw_ArgumentException_When_Value_IsTrue()
        {
            var act = new Action(() => Ensure.Bool.IsNullOrFalse(true));
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void IsNullOrFalse_Should_Return_Null_When_Value_IsNull()
        {
            var value = Ensure.Bool.IsNullOrFalse(null);
            value.Should().BeNull();
        }

        [Fact]
        public void IsNullOrFalse_Should_Return_False_When_Value_IsFalse()
        {
            var value = Ensure.Bool.IsNullOrFalse(false);
            value.Should().BeFalse();
        }
    }
}
