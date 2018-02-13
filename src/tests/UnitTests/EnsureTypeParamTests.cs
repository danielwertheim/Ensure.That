using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureTypeParamTests : UnitTestBase
    {
        private class Bogus { }

        private class NonBogus { }

        private static readonly Type BogusType = typeof(Bogus);

        private static readonly Type NonBogusType = typeof(NonBogus);

        [Fact]
        public void IsOfType_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            NonBogusType, BogusType,
            () => Ensure.Type.IsOfType(typeof(Bogus), NonBogusType, ParamName),
            () => Ensure.Type.IsOfType(new Bogus(), NonBogusType, ParamName),
            () => EnsureArg.IsOfType(typeof(Bogus), NonBogusType, ParamName),
            () => EnsureArg.IsOfType(new Bogus(), NonBogusType, ParamName));

        [Fact]
        public void IsOfType_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsOfType(BogusType, BogusType, ParamName),
            () => Ensure.Type.IsOfType(new Bogus(), BogusType, ParamName),
            () => EnsureArg.IsOfType(BogusType, BogusType, ParamName),
            () => EnsureArg.IsOfType(new Bogus(), BogusType, ParamName));

        [Fact]
        public void IsNotOfType_WhenTypeOf_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            string.Format(ExceptionMessages.Types_IsNotOfType_Failed, BogusType),
            () => Ensure.Type.IsNotOfType(typeof(Bogus), BogusType, ParamName),
            () => Ensure.Type.IsNotOfType(new Bogus(), BogusType, ParamName),
            () => EnsureArg.IsNotOfType(typeof(Bogus), BogusType, ParamName),
            () => EnsureArg.IsNotOfType(new Bogus(), BogusType, ParamName));

        [Fact]
        public void IsNotOfType_WhenIsNotTheType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsNotOfType(BogusType, NonBogusType, ParamName),
            () => Ensure.Type.IsNotOfType(new Bogus(), NonBogusType, ParamName),
            () => EnsureArg.IsNotOfType(BogusType, NonBogusType, ParamName),
            () => EnsureArg.IsNotOfType(new Bogus(), NonBogusType, ParamName));

        [Fact]
        public void IsInt_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(int), typeof(decimal),
            () => Ensure.Type.IsInt(typeof(decimal), ParamName),
            () => Ensure.Type.IsInt(42m, ParamName),
            () => EnsureArg.IsInt(typeof(decimal), ParamName),
            () => EnsureArg.IsInt(42m, ParamName));

        [Fact]
        public void IsInt_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsInt(typeof(int), ParamName),
            () => Ensure.Type.IsInt(42, ParamName),
            () => EnsureArg.IsInt(typeof(int), ParamName),
            () => EnsureArg.IsInt(42, ParamName));

        [Fact]
        public void IsShort_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(short), typeof(int),
            () => Ensure.Type.IsShort(typeof(int), ParamName),
            () => Ensure.Type.IsShort(42, ParamName),
            () => EnsureArg.IsShort(typeof(int), ParamName),
            () => EnsureArg.IsShort(42, ParamName));

        [Fact]
        public void IsShort_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsShort(typeof(short), ParamName),
            () => Ensure.Type.IsShort((short)42, ParamName),
            () => EnsureArg.IsShort(typeof(short), ParamName),
            () => EnsureArg.IsShort((short)42, ParamName));

        [Fact]
        public void IsDecimal_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(decimal), typeof(int),
            () => Ensure.Type.IsDecimal(typeof(int), ParamName),
            () => Ensure.Type.IsDecimal(42, ParamName),
            () => EnsureArg.IsDecimal(typeof(int), ParamName),
            () => EnsureArg.IsDecimal(42, ParamName));

        [Fact]
        public void IsDecimal_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsDecimal(typeof(decimal), ParamName),
            () => Ensure.Type.IsDecimal(42.33m, ParamName),
            () => EnsureArg.IsDecimal(typeof(decimal), ParamName),
            () => EnsureArg.IsDecimal(42.33m, ParamName));

        [Fact]
        public void IsDouble_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(double), typeof(int),
            () => Ensure.Type.IsDouble(typeof(int), ParamName),
            () => Ensure.Type.IsDouble(42, ParamName),
            () => EnsureArg.IsDouble(typeof(int), ParamName),
            () => EnsureArg.IsDouble(42, ParamName));

        [Fact]
        public void IsDouble_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsDouble(typeof(double), ParamName),
            () => Ensure.Type.IsDouble(42.33, ParamName),
            () => EnsureArg.IsDouble(typeof(double), ParamName),
            () => EnsureArg.IsDouble(42.33, ParamName));

        [Fact]
        public void IsFloat_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(float), typeof(int),
            () => Ensure.Type.IsFloat(typeof(int), ParamName),
            () => Ensure.Type.IsFloat(42, ParamName),
            () => EnsureArg.IsFloat(typeof(int), ParamName),
            () => EnsureArg.IsFloat(42, ParamName));

        [Fact]
        public void IsFloat_WhenIsCorrectType_It_should_not_throw()
        {
            const float value = (float)42.33;

            ShouldNotThrow(
                () => Ensure.Type.IsFloat(typeof(float), ParamName),
                () => Ensure.Type.IsFloat(value, ParamName),
                () => EnsureArg.IsFloat(typeof(float), ParamName),
                () => EnsureArg.IsFloat(value, ParamName));
        }

        [Fact]
        public void IsBool_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(bool), typeof(int),
            () => Ensure.Type.IsBool(typeof(int), ParamName),
            () => Ensure.Type.IsBool(42, ParamName),
            () => EnsureArg.IsBool(typeof(int), ParamName),
            () => EnsureArg.IsBool(42, ParamName));

        [Fact]
        public void IsBool_WhenIsCorrectType_It_should_not_throw()
        {
            const bool value = true;

            ShouldNotThrow(
                () => Ensure.Type.IsBool(typeof(bool), ParamName),
                () => Ensure.Type.IsBool(value, ParamName),
                () => EnsureArg.IsBool(typeof(bool), ParamName),
                () => EnsureArg.IsBool(value, ParamName));
        }

        [Fact]
        public void IsDateTime_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(DateTime), typeof(int),
            () => Ensure.Type.IsDateTime(typeof(int), ParamName),
            () => Ensure.Type.IsDateTime(42, ParamName),
            () => EnsureArg.IsDateTime(typeof(int), ParamName),
            () => EnsureArg.IsDateTime(42, ParamName));

        [Fact]
        public void IsDateTime_WhenIsCorrectType_It_should_not_throw()
        {
            var value = DateTime.Now;

            ShouldNotThrow(
                () => Ensure.Type.IsDateTime(typeof(DateTime), ParamName),
                () => Ensure.Type.IsDateTime(value, ParamName),
                () => EnsureArg.IsDateTime(typeof(DateTime), ParamName),
                () => EnsureArg.IsDateTime(value, ParamName));
        }

        [Fact]
        public void IsString_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(string), typeof(int),
            () => Ensure.Type.IsString(typeof(int), ParamName),
            () => Ensure.Type.IsString(42, ParamName),
            () => EnsureArg.IsString(typeof(int), ParamName),
            () => EnsureArg.IsString(42, ParamName));

        [Fact]
        public void IsString_WhenIsCorrectType_It_should_not_throw()
        {
            var value = string.Empty;

            ShouldNotThrow(
                () => Ensure.Type.IsString(typeof(string), ParamName),
                () => Ensure.Type.IsString(value, ParamName),
                () => EnsureArg.IsString(typeof(string), ParamName),
                () => EnsureArg.IsString(value, ParamName));
        }

        [Fact]
        public void IsClass_WhenIsNotClass_ThrowsArgumentException() => AssertIsNotClass(
            typeof(int),
            () => Ensure.Type.IsClass(typeof(int), ParamName),
            () => Ensure.Type.IsClass(42, ParamName),
            () => EnsureArg.IsClass(typeof(int), ParamName),
            () => EnsureArg.IsClass(42, ParamName));

        [Fact]
        public void IsClass_WhenPassingNull_ThrowsArgumentNullException() => ShouldThrow<ArgumentNullException>(
            ExceptionMessages.Types_IsClass_Failed_Null,
            () => Ensure.Type.IsClass(null, ParamName),
            () => EnsureArg.IsClass(null, ParamName));

        [Fact]
        public void IsClass_WhenIsClass_It_should_not_throw()
        {
            var value = new MyClass();

            ShouldNotThrow(
                () => Ensure.Type.IsClass(typeof(MyClass), ParamName),
                () => Ensure.Type.IsClass(value, ParamName),
                () => EnsureArg.IsClass(typeof(MyClass), ParamName),
                () => EnsureArg.IsClass(value, ParamName));
        }

        private static void AssertIsOfTypeScenario(Type expected, Type actual, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Types_IsOfType_Failed, expected.FullName, actual.FullName), actions);

        private static void AssertIsNotClass(Type type, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Types_IsClass_Failed, type.FullName), actions);

        private class MyClass { }
    }
}