using System;
using EnsureThat;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class EnsureValueTypeParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotDefault_WhenDefault_ThrowsArgumentException()
        {
            int value = default(int);

            AssertAll<ArgumentException>(
                ExceptionMessages.ValueTypes_IsNotDefault_Failed,
                () => Ensure.That(value, ParamName).IsNotDefault(),
                () => EnsureArg.IsNotDefault(value, ParamName));
        }

        [Fact]
        public void IsNotDefault_WhenIsNotDefault_It_should_not_throw()
        {
            var value = 42;

            var returned = Ensure.That(value, ParamName).IsNotDefault();
            AssertReturnedAsExpected(returned, value);

            Action a = () => EnsureArg.IsNotDefault(value, ParamName);
            a.ShouldNotThrow();
        }
    }
}