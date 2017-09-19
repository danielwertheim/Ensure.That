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
                () => Ensure.That(value, ParamName).IsNotDefault(),
                () => EnsureArg.IsNotDefault(value, ParamName));
        }

        [Fact]
        public void IsNotDefault_WhenIsNotDefault_It_should_not_throw()
        {
            const int value = 42;

            ShouldNotThrow(
                () => Ensure.That(value, ParamName).IsNotDefault(),
                () => EnsureArg.IsNotDefault(value, ParamName));
        }
    }
}