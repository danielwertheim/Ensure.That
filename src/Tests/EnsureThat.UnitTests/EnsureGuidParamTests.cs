using System;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureGuidParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotEmpty_WhenEmptyGuid_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(Guid.Empty, ParamName).IsNotEmpty());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyGuid);
        }

        [Fact]
        public void IsNotEmpty_WhenNonEmptyGuid_ReturnsPassedGuid()
        {
            var guid = Guid.NewGuid();

            var returnedValue = Ensure.That(guid, ParamName).IsNotEmpty();

            AssertReturnedAsExpected(returnedValue, guid);
        }
    }
}