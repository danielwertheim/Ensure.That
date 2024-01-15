using System;
using EnsureThat;
using EnsureThat.Internals;
using Xunit;

namespace UnitTests
{
    public class EnsureTypeParamTests : UnitTestBase
    {
        private sealed class Bogus { }

        private class NonBogus { }

        private sealed class AssignableToNonBogus : NonBogus { }

        private static readonly Type BogusType = typeof(Bogus);

        private static readonly Type NonBogusType = typeof(NonBogus);

        private static readonly Type AssignableToNonBogusType = typeof(AssignableToNonBogus);

        [Fact]
        public void IsOfType_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            NonBogusType, BogusType,
            () => Ensure.Type.IsOfType(typeof(Bogus), NonBogusType, ParamName),
            () => Ensure.Type.IsOfType(new Bogus(), NonBogusType, ParamName),
            () => EnsureArg.IsOfType(typeof(Bogus), NonBogusType, ParamName),
            () => EnsureArg.IsOfType(new Bogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(Bogus), ParamName).IsOfType(NonBogusType),
            () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(NonBogusType));

        [Fact]
        public void IsOfType_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsOfType(BogusType, BogusType, ParamName),
            () => Ensure.Type.IsOfType(new Bogus(), BogusType, ParamName),
            () => EnsureArg.IsOfType(BogusType, BogusType, ParamName),
            () => EnsureArg.IsOfType(new Bogus(), BogusType, ParamName),
            () => Ensure.ThatType(typeof(Bogus), ParamName).IsOfType(BogusType),
            () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(BogusType));

        [Fact]
        public void IsNotOfType_WhenTypeOf_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Types_IsNotOfType_Failed, BogusType),
            () => Ensure.Type.IsNotOfType(typeof(Bogus), BogusType, ParamName),
            () => Ensure.Type.IsNotOfType(new Bogus(), BogusType, ParamName),
            () => EnsureArg.IsNotOfType(typeof(Bogus), BogusType, ParamName),
            () => EnsureArg.IsNotOfType(new Bogus(), BogusType, ParamName),
            () => Ensure.ThatType(typeof(Bogus), ParamName).IsNotOfType(BogusType),
            () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsNotOfType(BogusType));

        [Fact]
        public void IsNotOfType_WhenIsNotTheType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsNotOfType(BogusType, NonBogusType, ParamName),
            () => Ensure.Type.IsNotOfType(new Bogus(), NonBogusType, ParamName),
            () => EnsureArg.IsNotOfType(BogusType, NonBogusType, ParamName),
            () => EnsureArg.IsNotOfType(new Bogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(Bogus), ParamName).IsNotOfType(NonBogusType),
            () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsNotOfType(NonBogusType));

        [Fact]
        public void IsAssignableToType_WhenNotAssignableToType_ThrowsArgumentException() => AssertIsAssignableToTypeScenario(
            NonBogusType, BogusType,
            () => Ensure.Type.IsAssignableToType(typeof(Bogus), NonBogusType, ParamName),
            () => Ensure.Type.IsAssignableToType(new Bogus(), NonBogusType, ParamName),
            () => EnsureArg.IsAssignableToType(typeof(Bogus), NonBogusType, ParamName),
            () => EnsureArg.IsAssignableToType(new Bogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(Bogus), ParamName).IsAssignableToType(NonBogusType),
            () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsAssignableToType(NonBogusType));

        [Fact]
        public void IsAssignableToType_WhenAssignableToType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsAssignableToType(NonBogusType, NonBogusType, ParamName),
            () => Ensure.Type.IsAssignableToType(new NonBogus(), NonBogusType, ParamName),
            () => EnsureArg.IsAssignableToType(NonBogusType, NonBogusType, ParamName),
            () => EnsureArg.IsAssignableToType(new NonBogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(NonBogus), ParamName).IsAssignableToType(NonBogusType),
            () => Ensure.ThatTypeFor(new NonBogus(), ParamName).IsAssignableToType(NonBogusType),
            () => Ensure.Type.IsAssignableToType(AssignableToNonBogusType, NonBogusType, ParamName),
            () => Ensure.Type.IsAssignableToType(new AssignableToNonBogus(), NonBogusType, ParamName),
            () => EnsureArg.IsAssignableToType(AssignableToNonBogusType, NonBogusType, ParamName),
            () => EnsureArg.IsAssignableToType(new AssignableToNonBogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(AssignableToNonBogus), ParamName).IsAssignableToType(NonBogusType),
            () => Ensure.ThatTypeFor(new AssignableToNonBogus(), ParamName).IsAssignableToType(NonBogusType));

        [Fact]
        public void IsNotAssignableToType_WhenAssignableToType_ThrowsArgumentException() => ShouldThrow<ArgumentException>(
            string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Types_IsNotAssignableToType_Failed, NonBogusType),
            () => Ensure.Type.IsNotAssignableToType(typeof(NonBogus), NonBogusType, ParamName),
            () => Ensure.Type.IsNotAssignableToType(new NonBogus(), NonBogusType, ParamName),
            () => EnsureArg.IsNotAssignableToType(typeof(NonBogus), NonBogusType, ParamName),
            () => EnsureArg.IsNotAssignableToType(new NonBogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(NonBogus), ParamName).IsNotAssignableToType(NonBogusType),
            () => Ensure.ThatTypeFor(new NonBogus(), ParamName).IsNotAssignableToType(NonBogusType),
            () => Ensure.Type.IsNotAssignableToType(typeof(AssignableToNonBogus), NonBogusType, ParamName),
            () => Ensure.Type.IsNotAssignableToType(new AssignableToNonBogus(), NonBogusType, ParamName),
            () => EnsureArg.IsNotAssignableToType(typeof(AssignableToNonBogus), NonBogusType, ParamName),
            () => EnsureArg.IsNotAssignableToType(new AssignableToNonBogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(AssignableToNonBogus), ParamName).IsNotAssignableToType(NonBogusType),
            () => Ensure.ThatTypeFor(new AssignableToNonBogus(), ParamName).IsNotAssignableToType(NonBogusType));

        [Fact]
        public void IsNotAssignableToType_WhenNotAssignableToType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsNotAssignableToType(BogusType, NonBogusType, ParamName),
            () => Ensure.Type.IsNotAssignableToType(new Bogus(), NonBogusType, ParamName),
            () => EnsureArg.IsNotAssignableToType(BogusType, NonBogusType, ParamName),
            () => EnsureArg.IsNotAssignableToType(new Bogus(), NonBogusType, ParamName),
            () => Ensure.ThatType(typeof(Bogus), ParamName).IsNotAssignableToType(NonBogusType),
            () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsNotAssignableToType(NonBogusType));

        [Fact]
        public void IsInt_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(int), typeof(decimal),
            () => Ensure.Type.IsInt(typeof(decimal), ParamName),
            () => Ensure.Type.IsInt(42m, ParamName),
            () => EnsureArg.IsInt(typeof(decimal), ParamName),
            () => EnsureArg.IsInt(42m, ParamName),
            () => Ensure.ThatType(typeof(decimal), ParamName).IsInt(),
            () => Ensure.ThatTypeFor(42m, ParamName).IsInt());

        [Fact]
        public void IsInt_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsInt(typeof(int), ParamName),
            () => Ensure.Type.IsInt(42, ParamName),
            () => EnsureArg.IsInt(typeof(int), ParamName),
            () => EnsureArg.IsInt(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsInt(),
            () => Ensure.ThatTypeFor(42, ParamName).IsInt());

        [Fact]
        public void IsShort_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(short), typeof(int),
            () => Ensure.Type.IsShort(typeof(int), ParamName),
            () => Ensure.Type.IsShort(42, ParamName),
            () => EnsureArg.IsShort(typeof(int), ParamName),
            () => EnsureArg.IsShort(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsShort(),
            () => Ensure.ThatTypeFor(42, ParamName).IsShort());

        [Fact]
        public void IsShort_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsShort(typeof(short), ParamName),
            () => Ensure.Type.IsShort((short)42, ParamName),
            () => EnsureArg.IsShort(typeof(short), ParamName),
            () => EnsureArg.IsShort((short)42, ParamName),
            () => Ensure.ThatType(typeof(short), ParamName).IsShort(),
            () => Ensure.ThatTypeFor((short)42, ParamName).IsShort());

        [Fact]
        public void IsDecimal_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(decimal), typeof(int),
            () => Ensure.Type.IsDecimal(typeof(int), ParamName),
            () => Ensure.Type.IsDecimal(42, ParamName),
            () => EnsureArg.IsDecimal(typeof(int), ParamName),
            () => EnsureArg.IsDecimal(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsDecimal(),
            () => Ensure.ThatTypeFor(42, ParamName).IsDecimal());

        [Fact]
        public void IsDecimal_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsDecimal(typeof(decimal), ParamName),
            () => Ensure.Type.IsDecimal(42.33m, ParamName),
            () => EnsureArg.IsDecimal(typeof(decimal), ParamName),
            () => EnsureArg.IsDecimal(42.33m, ParamName),
            () => Ensure.ThatType(typeof(decimal), ParamName).IsDecimal(),
            () => Ensure.ThatTypeFor(42.33m, ParamName).IsDecimal());

        [Fact]
        public void IsDouble_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(double), typeof(int),
            () => Ensure.Type.IsDouble(typeof(int), ParamName),
            () => Ensure.Type.IsDouble(42, ParamName),
            () => EnsureArg.IsDouble(typeof(int), ParamName),
            () => EnsureArg.IsDouble(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsDouble(),
            () => Ensure.ThatTypeFor(42, ParamName).IsDouble());

        [Fact]
        public void IsDouble_WhenIsCorrectType_It_should_not_throw() => ShouldNotThrow(
            () => Ensure.Type.IsDouble(typeof(double), ParamName),
            () => Ensure.Type.IsDouble(42.33, ParamName),
            () => EnsureArg.IsDouble(typeof(double), ParamName),
            () => EnsureArg.IsDouble(42.33, ParamName),
            () => Ensure.ThatType(typeof(double), ParamName).IsDouble(),
            () => Ensure.ThatTypeFor(42.33, ParamName).IsDouble());

        [Fact]
        public void IsFloat_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(float), typeof(int),
            () => Ensure.Type.IsFloat(typeof(int), ParamName),
            () => Ensure.Type.IsFloat(42, ParamName),
            () => EnsureArg.IsFloat(typeof(int), ParamName),
            () => EnsureArg.IsFloat(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsFloat(),
            () => Ensure.ThatTypeFor(42, ParamName).IsFloat());

        [Fact]
        public void IsFloat_WhenIsCorrectType_It_should_not_throw()
        {
            const float value = (float)42.33;

            ShouldNotThrow(
                () => Ensure.Type.IsFloat(typeof(float), ParamName),
                () => Ensure.Type.IsFloat(value, ParamName),
                () => EnsureArg.IsFloat(typeof(float), ParamName),
                () => EnsureArg.IsFloat(value, ParamName),
                () => Ensure.ThatType(typeof(float), ParamName).IsFloat(),
                () => Ensure.ThatTypeFor(value, ParamName).IsFloat());
        }

        [Fact]
        public void IsBool_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(bool), typeof(int),
            () => Ensure.Type.IsBool(typeof(int), ParamName),
            () => Ensure.Type.IsBool(42, ParamName),
            () => EnsureArg.IsBool(typeof(int), ParamName),
            () => EnsureArg.IsBool(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsBool(),
            () => Ensure.ThatTypeFor(42, ParamName).IsBool());

        [Fact]
        public void IsBool_WhenIsCorrectType_It_should_not_throw()
        {
            const bool value = true;

            ShouldNotThrow(
                () => Ensure.Type.IsBool(typeof(bool), ParamName),
                () => Ensure.Type.IsBool(value, ParamName),
                () => EnsureArg.IsBool(typeof(bool), ParamName),
                () => EnsureArg.IsBool(value, ParamName),
                () => Ensure.ThatType(typeof(bool), ParamName).IsBool(),
                () => Ensure.ThatTypeFor(value, ParamName).IsBool());
        }

        [Fact]
        public void IsDateTime_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(DateTime), typeof(int),
            () => Ensure.Type.IsDateTime(typeof(int), ParamName),
            () => Ensure.Type.IsDateTime(42, ParamName),
            () => EnsureArg.IsDateTime(typeof(int), ParamName),
            () => EnsureArg.IsDateTime(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsDateTime(),
            () => Ensure.ThatTypeFor(42, ParamName).IsDateTime());

        [Fact]
        public void IsDateTime_WhenIsCorrectType_It_should_not_throw()
        {
            var value = DateTime.Now;

            ShouldNotThrow(
                () => Ensure.Type.IsDateTime(typeof(DateTime), ParamName),
                () => Ensure.Type.IsDateTime(value, ParamName),
                () => EnsureArg.IsDateTime(typeof(DateTime), ParamName),
                () => EnsureArg.IsDateTime(value, ParamName),
                () => Ensure.ThatType(typeof(DateTime), ParamName).IsDateTime(),
                () => Ensure.ThatTypeFor(value, ParamName).IsDateTime());
        }

        [Fact]
        public void IsString_WhenNotTypeOf_ThrowsArgumentException() => AssertIsOfTypeScenario(
            typeof(string), typeof(int),
            () => Ensure.Type.IsString(typeof(int), ParamName),
            () => Ensure.Type.IsString(42, ParamName),
            () => EnsureArg.IsString(typeof(int), ParamName),
            () => EnsureArg.IsString(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsString(),
            () => Ensure.ThatTypeFor(42, ParamName).IsString());

        [Fact]
        public void IsString_WhenIsCorrectType_It_should_not_throw()
        {
            var value = string.Empty;

            ShouldNotThrow(
                () => Ensure.Type.IsString(typeof(string), ParamName),
                () => Ensure.Type.IsString(value, ParamName),
                () => EnsureArg.IsString(typeof(string), ParamName),
                () => EnsureArg.IsString(value, ParamName),
                () => Ensure.ThatType(typeof(string), ParamName).IsString(),
                () => Ensure.ThatTypeFor(value, ParamName).IsString());
        }

        [Fact]
        public void IsClass_WhenIsNotClass_ThrowsArgumentException() => AssertIsNotClass(
            typeof(int),
            () => Ensure.Type.IsClass(typeof(int), ParamName),
            () => Ensure.Type.IsClass(42, ParamName),
            () => EnsureArg.IsClass(typeof(int), ParamName),
            () => EnsureArg.IsClass(42, ParamName),
            () => Ensure.ThatType(typeof(int), ParamName).IsClass(),
            () => Ensure.ThatTypeFor(42, ParamName).IsClass());

        [Fact]
        public void IsClass_WhenPassingNull_ThrowsArgumentNullException() => ShouldThrow<ArgumentNullException>(
            ExceptionMessages.Types_IsClass_Failed_Null,
            () => Ensure.Type.IsClass(null, ParamName),
            () => EnsureArg.IsClass(null, ParamName),
            () => Ensure.ThatType(null, ParamName).IsClass());

        [Fact]
        public void IsClass_WhenIsClass_It_should_not_throw()
        {
            var value = new MyClass();

            ShouldNotThrow(
                () => Ensure.Type.IsClass(typeof(MyClass), ParamName),
                () => Ensure.Type.IsClass(value, ParamName),
                () => EnsureArg.IsClass(typeof(MyClass), ParamName),
                () => EnsureArg.IsClass(value, ParamName),
                () => Ensure.ThatType(typeof(MyClass), ParamName).IsClass(),
                () => Ensure.ThatTypeFor(value, ParamName).IsClass());
        }

        private static void AssertIsOfTypeScenario(Type expected, Type actual, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Types_IsOfType_Failed, expected.FullName, actual.FullName), actions);

        private static void AssertIsAssignableToTypeScenario(Type expected, Type actual, params Action[] actions)
	        => ShouldThrow<ArgumentException>(string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Types_IsAssignableToType_Failed, expected.FullName, actual.FullName), actions);

        private static void AssertIsNotClass(Type type, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Types_IsClass_Failed, type.FullName), actions);

        private sealed class MyClass { }
    }
}
