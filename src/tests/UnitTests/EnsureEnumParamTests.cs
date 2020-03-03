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
            var item = Only1IsValidEnum.Valid;

            ShouldNotThrow(
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Theory]
        [InlineData((Only1IsValidEnum)2)]
        [InlineData((Only1IsValidEnum)0)]
        public void NotDefined_ShouldThrow(Only1IsValidEnum item)
        {
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(Only1IsValidEnum)),
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Fact]
        public void IsDefinedWithFlagsSupport_ShouldNotThrow()
        {
            var item = Only1IsValidEnum.Valid;

            ShouldNotThrow(
                () => Ensure.Enum.IsDefinedWithFlagsSupport(item, ParamName),
                () => EnsureArg.EnumIsDefinedWithFlagsSupport(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefinedWithFlagsSupport());
        }

        [Theory]
        [InlineData((Only1IsValidEnum)2)]
        [InlineData((Only1IsValidEnum)0)]
        public void NotDefined_Extended_ShouldThrow(Only1IsValidEnum item)
        {
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(Only1IsValidEnum)),
                () => Ensure.Enum.IsDefinedWithFlagsSupport(item, ParamName),
                () => EnsureArg.EnumIsDefinedWithFlagsSupport(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefinedWithFlagsSupport());
        }

        [Fact]
        public void FlagIsDefined_ShouldNotThrow_IfNotCombined()
        {
            var item = TestFlagsEnum.Bar;

            ShouldNotThrow(
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Fact]
        public void FlagIsDefined_ShouldThrow_IfCombined()
        {
            var item = TestFlagsEnum.Bar | TestFlagsEnum.Baz;

            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(TestFlagsEnum)),
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Fact]
        public void FlagNotDefined_ShouldThrow()
        {
            var item = (TestFlagsEnum)3;
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(TestFlagsEnum)),
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }
        
        [Theory]
        [InlineData(TestFlagsEnum.Bar)]
        [InlineData(TestFlagsEnum.Bar | TestFlagsEnum.Baz)]
        public void FlagIsDefined_Extended_ShouldNotThrow(TestFlagsEnum item)
        {
            ShouldNotThrow(
                () => Ensure.Enum.IsDefinedWithFlagsSupport(item, ParamName),
                () => EnsureArg.EnumIsDefinedWithFlagsSupport(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefinedWithFlagsSupport());
        }

        [Theory]
        [InlineData((TestFlagsEnum)4)]
        [InlineData((TestFlagsEnum)0)]
        public void FlagNotDefined_Extended_ShouldThrow(TestFlagsEnum item)
        {
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(TestFlagsEnum)),
                () => Ensure.Enum.IsDefinedWithFlagsSupport(item, ParamName),
                () => EnsureArg.EnumIsDefinedWithFlagsSupport(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefinedWithFlagsSupport());
        }
        
        [Theory]
        [InlineData(TestFlagsOfWhateverPower.A)]
        [InlineData(TestFlagsOfWhateverPower.B)]
        [InlineData(TestFlagsOfWhateverPower.C)]
        [InlineData(TestFlagsOfWhateverPower.A | TestFlagsOfWhateverPower.C)]
        [InlineData(TestFlagsOfWhateverPower.B | TestFlagsOfWhateverPower.C)]
        public void FlagOfWhateverPowerIsDefined_ShouldNotThrow(TestFlagsOfWhateverPower item)
        {
            ShouldNotThrow(
                () => Ensure.Enum.IsDefinedWithFlagsSupport(item, ParamName),
                () => EnsureArg.EnumIsDefinedWithFlagsSupport(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefinedWithFlagsSupport());
        }

        [Fact]
        public void FlagOfWhateverPowerIsNotDefined_ShouldThrow()
        {
            var item = (TestFlagsOfWhateverPower)9;
            
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(TestFlagsOfWhateverPower)),
                () => Ensure.Enum.IsDefinedWithFlagsSupport(item, ParamName),
                () => EnsureArg.EnumIsDefinedWithFlagsSupport(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefinedWithFlagsSupport());
        }

        public enum Only1IsValidEnum : byte
        {
            Valid = 1
        }

        [Flags]
        public enum TestFlagsEnum : byte
        {
            Bar = 1,
            Baz = 1 << 1
        }

        [Flags]
        public enum TestFlagsOfWhateverPower : byte
        {
            A = 4,
            B = 5,
            C = 8
        }
    }
}