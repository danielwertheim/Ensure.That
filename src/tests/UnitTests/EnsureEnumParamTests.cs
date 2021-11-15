using System;
using EnsureThat;
using FluentAssertions;
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

        [Fact]
        public void IsNullOrIn_Should_Throw_ArgumentException_When_Value_IsProvided_And_ListEmpty()
        {
            var act = new Action(() => Ensure.Enum.IsNullOrIn(new TestEnums[] { }, TestEnums.A));
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void IsNullOrIn_Should_Return_Null_When_Value_IsNull_And_ListEmpty()
        {
            var value = Ensure.Enum.IsNullOrIn(new TestEnums[] { }, null);
            value.Should().BeNull();
        }

        [Fact]
        public void IsNullOrIn_Should_Return_TheValue_When_Value_IsInList()
        {
            var value = Ensure.Enum.IsNullOrIn(new[] { TestEnums.A, TestEnums.B },
                TestEnums.B);
            value.Should().Be(TestEnums.B);
        }

        [Fact]
        public void IsNullOrIn_Should_Throw_ArgumentException_When_Value_IsNotInList()
        {
            var act = new Action(() =>
                Ensure.Enum.IsNullOrIn(new[] { TestEnums.A, TestEnums.B },
                    TestEnums.C));
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void IsNullOrIn_Should_Return_Null_When_Value_IsNull_And_ListIsNotEmpty()
        {
            var value = Ensure.Enum.IsNullOrIn(new[] { TestEnums.A }, null);
            value.Should().BeNull();
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

        [Flags]
        private enum TestEnums : byte
        {
            A = 4,
            B = 5,
            C = 8
        }

    }
}
