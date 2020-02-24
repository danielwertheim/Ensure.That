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
            var item = EnumDummy.Valid;

            ShouldNotThrow(
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Theory]
        [InlineData((EnumDummy)2)]
        [InlineData((EnumDummy)0)]
        public void NotDefined_ShouldThrow(object itemAsObject)
        {
            var item = (EnumDummy)itemAsObject;
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(EnumDummy)),
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Fact]
        public void IsDefined_Strictly_ShouldNotThrow()
        {
            var item = EnumDummy.Valid;

            ShouldNotThrow(
                () => Ensure.Enum.IsStrictlyDefined(item, ParamName),
                () => EnsureArg.EnumIsStrictlyDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsStrictlyDefined());
        }

        [Theory]
        [InlineData((EnumDummy)2)]
        [InlineData((EnumDummy)0)]
        public void NotDefined_Strictly_ShouldThrow(object itemAsObject)
        {
            var item = (EnumDummy)itemAsObject;
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(EnumDummy)),
                () => Ensure.Enum.IsStrictlyDefined(item, ParamName),
                () => EnsureArg.EnumIsStrictlyDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsStrictlyDefined());
        }

        [Theory]
        [InlineData(FlagDummy.Bar)]
        [InlineData(FlagDummy.Bar | FlagDummy.Baz)]
        public void FlagIsDefined_ShouldNotThrow(object flagsAsObject)
        {
            var item = (FlagDummy)flagsAsObject;

            ShouldNotThrow(
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Theory]
        [InlineData((FlagDummy)3)]
        [InlineData((FlagDummy)0)]
        public void FlagNotDefined_ShouldThrow(object itemAsObject)
        {
            var item = (FlagDummy)itemAsObject;
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(FlagDummy)),
                () => Ensure.Enum.IsDefined(item, ParamName),
                () => EnsureArg.EnumIsDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsDefined());
        }

        [Fact]
        public void FlagIsDefined_Strictly_ShouldNotThrow_IfNotCombined()
        {
            var item = FlagDummy.Bar;

            ShouldNotThrow(
                () => Ensure.Enum.IsStrictlyDefined(item, ParamName),
                () => EnsureArg.EnumIsStrictlyDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsStrictlyDefined());
        }

        [Fact]
        public void FlagIsDefined_Strictly_ShouldThrow_IfCombined()
        {
            var item = FlagDummy.Bar | FlagDummy.Baz;

            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(FlagDummy)),
                () => Ensure.Enum.IsStrictlyDefined(item, ParamName),
                () => EnsureArg.EnumIsStrictlyDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsStrictlyDefined());
        }

        [Fact]
        public void FlagNotDefined_Strictly_ShouldThrow()
        {
            var item = (FlagDummy)3;
            ShouldThrow<ArgumentOutOfRangeException>(
                string.Format(ExceptionMessages.Enum_IsValidEnum, item, typeof(FlagDummy)),
                () => Ensure.Enum.IsStrictlyDefined(item, ParamName),
                () => EnsureArg.EnumIsStrictlyDefined(item, ParamName),
                () => Ensure.That(item, ParamName).IsStrictlyDefined());
        }

        private enum EnumDummy : byte
        {
            Valid = 1
        }

        [Flags]
        private enum FlagDummy : byte
        {
            Bar = 1 << 1,
            Baz = 1 << 2
        }
    }
}