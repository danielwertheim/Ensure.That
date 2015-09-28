using System;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureObjectParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotNull_WhenRefTypeIsNull_ThrowsArgumentNullException()
        {
            object value = null;

            var ex = Assert.Throws<ArgumentNullException>(
                () => Ensure.That(value, ParamName).IsNotNull());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNull);
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNotNull_ReturnsPassedObjectInstance()
        {
            var item = new { Value = 42 };

            var returnedItem = Ensure.That(item, ParamName).IsNotNull();

            AssertReturnedAsExpected(returnedItem, item);
        }
    }
}