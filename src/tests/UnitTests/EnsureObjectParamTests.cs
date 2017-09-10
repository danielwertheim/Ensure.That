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
                () => Ensure.That(value, ParamName).IsNotNull(),
                () => EnsureArg.IsNotNull(value, ParamName));
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNotNull_ShouldNotThrow()
        {
            var item = new { Value = 42 };

            ShouldNotThrow(
                () => Ensure.That(item, ParamName).IsNotNull(),
                () => EnsureArg.IsNotNull(item, ParamName));
        }
    }
}