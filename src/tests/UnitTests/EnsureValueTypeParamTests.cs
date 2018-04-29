using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureValueTypeParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotDefault_WhenDefault_ThrowsArgumentException()
        {
            const int value = default(int);

            ShouldThrow<ArgumentException>(
                ExceptionMessages.ValueTypes_IsNotDefault_Failed,
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotDefault());
        }

        [Fact]
        public void IsNotDefault_WhenIsNotDefault_It_should_not_throw()
        {
            const int value = 42;

            ShouldNotThrow(
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotDefault());
        }
    }
}