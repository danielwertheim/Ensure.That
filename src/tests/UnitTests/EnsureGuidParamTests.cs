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
                () => Ensure.Guid.IsNotEmpty(Guid.Empty, ParamName),
                () => EnsureArg.IsNotEmpty(Guid.Empty, ParamName),
                () => Ensure.That(Guid.Empty, ParamName).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmpty_WhenNonEmptyGuid_ShouldNotThrow()
        {
            var guid = Guid.NewGuid();

            ShouldNotThrow(
                () => Ensure.Guid.IsNotEmpty(guid, ParamName),
                () => EnsureArg.IsNotEmpty(guid, ParamName),
                () => Ensure.That(guid,ParamName).IsNotEmpty());
        }
    }
}