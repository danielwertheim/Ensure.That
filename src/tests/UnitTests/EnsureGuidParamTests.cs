using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureGuidParamTests : UnitTestBase
    {
        [Fact]
        public void IsNotEmpty_WhenEmptyGuid_ThrowsArgumentException()
        {
            ShouldThrow<ArgumentException>(
                ExceptionMessages.Guids_IsNotEmpty_Failed,
                () => Ensure.That(Guid.Empty, ParamName).IsNotEmpty(),
                () => EnsureArg.IsNotEmpty(Guid.Empty, ParamName));
        }

        [Fact]
        public void IsNotEmpty_WhenNonEmptyGuid_ShouldNotThrow()
        {
            var guid = Guid.NewGuid();

            ShouldNotThrow(
                () => Ensure.That(guid, ParamName).IsNotEmpty(),
                () => EnsureArg.IsNotEmpty(guid, ParamName));
        }
    }
}