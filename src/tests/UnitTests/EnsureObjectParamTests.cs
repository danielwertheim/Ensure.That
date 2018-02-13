using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureObjectParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotNull_WhenRefTypeIsNull_ThrowsArgumentNullException()
        {
            object value = null;

            ShouldThrow<ArgumentNullException>(
                ExceptionMessages.Common_IsNotNull_Failed,
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName));
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNotNull_ShouldNotThrow()
        {
            var item = new { Value = 42 };

            ShouldNotThrow(
                () => Ensure.Any.IsNotNull(item, ParamName),
                () => EnsureArg.IsNotNull(item, ParamName));
        }

        [Fact]
        public void IsNotDefault_WhenIsDefault_ThrowsException()
        {
            int value = default(int);

            ShouldThrow<ArgumentException>(
                ExceptionMessages.ValueTypes_IsNotDefault_Failed,
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName));
        }

        [Fact]
        public void IsNotDefault_WhenIsNotDefault_ShouldNotThrow()
        {
            var value = 42;

            ShouldNotThrow(
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName));
        }
    }
}