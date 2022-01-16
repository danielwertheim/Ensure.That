using System;
using EnsureThat;
using Xunit;

// ReSharper disable ExpressionIsAlwaysNull

namespace UnitTests
{

    public class EnsureAnyParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotNull_WhenValueTypeIsNull_ThrowsArgumentNullException()
        {
            int? value = null;

            ShouldThrow<ArgumentNullException>(
                ExceptionMessages.Common_IsNotNull_Failed,
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotNull_WhenValueTypeIsNotNull_ShouldNotThrow()
        {
            int? value = 1;

            ShouldNotThrow(
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNull_ThrowsArgumentNullException()
        {
            object value = null;

            ShouldThrow<ArgumentNullException>(
                ExceptionMessages.Common_IsNotNull_Failed,
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNotNull_ShouldNotThrow()
        {
            var item = new { Value = 42 };

            ShouldNotThrow(
                () => Ensure.Any.IsNotNull(item, ParamName),
                () => EnsureArg.IsNotNull(item, ParamName),
                () => Ensure.That(item, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotDefault_WhenIsDefault_ThrowsException()
        {
            int value = default(int);

            ShouldThrow<ArgumentException>(
                ExceptionMessages.ValueTypes_IsNotDefault_Failed,
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotDefault());
        }

        [Fact]
        public void IsNotDefault_WhenIsNotDefault_ShouldNotThrow()
        {
            var value = 42;

            ShouldNotThrow(
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotDefault());
        }
    }
}
