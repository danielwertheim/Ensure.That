using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureEnumParamTests : UnitTestBase
    {
        [Fact]
        public void IsDefined_ShouldNotThrow()
        {
            var item = Only1IsValid.Valid;

            ShouldNotThrow(
                () => Ensure.Enum.IsValidEnum(item, ParamName),
                () => EnsureArg.IsValidEnum(item, ParamName),
                () => Ensure.That(item, ParamName).IsValidEnum());
        }

        [Fact]
        public void IsNotDefined_ShouldThrow()
        {
            var item = (Only1IsValid)2;

            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(Only1IsValid)),
                () => Ensure.Enum.IsValidEnum(item, ParamName),
                () => EnsureArg.IsValidEnum(item, ParamName),
                () => Ensure.That(item, ParamName).IsValidEnum());
        }

        private enum Only1IsValid
        {
            Valid = 1
        }
    }
}