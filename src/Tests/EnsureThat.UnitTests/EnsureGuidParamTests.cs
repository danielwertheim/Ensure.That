using System;
using EnsureThat.Resources;
using Xunit;

namespace EnsureThat.Tests.UnitTests
{
    public class EnsureGuidParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Fact]
        public void IsNotEmpty_WhenEmptyGuid_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(Guid.Empty, ParamName).IsNotEmpty());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(
                ExceptionMessages.EnsureExtensions_IsEmptyGuid + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void IsNotEmpty_WhenNonEmptyGuid_ReturnsPassedGuid()
        {
            var guid = Guid.NewGuid();

            var returnedValue = Ensure.That(guid, ParamName).IsNotEmpty();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(guid, returnedValue.Value);
        }
    }
}