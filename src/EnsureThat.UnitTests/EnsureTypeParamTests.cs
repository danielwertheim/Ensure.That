using FluentAssertions;
using System;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureTypeParamTests : UnitTestBase
    {
        private class Bogus { }

        private class NonBogus { }

        private static readonly Type BogusType = typeof(Bogus);

        private static readonly Type NonBogusType = typeof(NonBogus);

        [Fact]
        public void IsOfType_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                NonBogusType, BogusType,
                () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(NonBogusType),
                () => EnsureArg.IsOfType(typeof(Bogus), NonBogusType, ParamName),
                () => EnsureArg.IsOfType(new Bogus(), NonBogusType, ParamName));
        }

        [Fact]
        public void IsOfType_WhenIsCorrectType_It_should_not_throw()
        {
            var returnedValue = Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(BogusType);
            AssertReturnedAsExpected(returnedValue, BogusType);

            Action a = () => EnsureArg.IsOfType(BogusType, BogusType, ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsOfType(new Bogus(), BogusType, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsNotOfType_WhenTypeOf_ThrowsArgumentException()
        {
            AssertAll<ArgumentException>(
                string.Format(ExceptionMessages.Types_IsNotOfType_Failed, BogusType),
                () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsNotOfType(BogusType),
                () => EnsureArg.IsNotOfType(typeof(Bogus), BogusType, ParamName),
                () => EnsureArg.IsNotOfType(new Bogus(), BogusType, ParamName));
        }

        [Fact]
        public void IsNotOfType_WhenIsNotTheType_It_should_not_throw()
        {
            var returnedValue = Ensure.ThatTypeFor(new Bogus(), ParamName).IsNotOfType(NonBogusType);
            AssertReturnedAsExpected(returnedValue, BogusType);

            Action a = () => EnsureArg.IsNotOfType(BogusType, NonBogusType, ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsNotOfType(new Bogus(), NonBogusType, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsInt_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(int), typeof(decimal),
                () => Ensure.ThatTypeFor(42m, ParamName).IsInt(),
                () => EnsureArg.IsInt(typeof(decimal), ParamName),
                () => EnsureArg.IsInt(42m, ParamName));
        }

        [Fact]
        public void IsInt_WhenIsCorrectType_It_should_not_throw()
        {
            var returnedValue = Ensure.ThatTypeFor(42, ParamName).IsInt();
            AssertReturnedAsExpected(returnedValue, typeof(int));

            Action a = () => EnsureArg.IsInt(typeof(int), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsInt(42, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsShort_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(short), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsShort(),
                () => EnsureArg.IsShort(typeof(int), ParamName),
                () => EnsureArg.IsShort(42, ParamName));
        }

        [Fact]
        public void IsShort_WhenIsCorrectType_It_should_not_throw()
        {
            var returnedValue = Ensure.ThatTypeFor((short)42, ParamName).IsShort();
            AssertReturnedAsExpected(returnedValue, typeof(short));

            Action a = () => EnsureArg.IsShort(typeof(short), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsShort((short)42, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsDecimal_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(decimal), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsDecimal(),
                () => EnsureArg.IsDecimal(typeof(int), ParamName),
                () => EnsureArg.IsDecimal(42, ParamName));
        }

        [Fact]
        public void IsDecimal_WhenIsCorrectType_It_should_not_throw()
        {
            var returnedValue = Ensure.ThatTypeFor(42.33m, ParamName).IsDecimal();
            AssertReturnedAsExpected(returnedValue, typeof(decimal));

            Action a = () => EnsureArg.IsDecimal(typeof(decimal), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsDecimal(42.33m, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsDouble_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(double), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsDouble(),
                () => EnsureArg.IsDouble(typeof(int), ParamName),
                () => EnsureArg.IsDouble(42, ParamName));
        }

        [Fact]
        public void IsDouble_WhenIsCorrectType_It_should_not_throw()
        {
            var returnedValue = Ensure.ThatTypeFor(42.33, ParamName).IsDouble();
            AssertReturnedAsExpected(returnedValue, typeof(double));

            Action a = () => EnsureArg.IsDouble(typeof(double), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsDouble(42.33, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsFloat_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(float), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsFloat(),
                () => EnsureArg.IsFloat(typeof(int), ParamName),
                () => EnsureArg.IsFloat(42, ParamName));
        }

        [Fact]
        public void IsFloat_WhenIsCorrectType_It_should_not_throw()
        {
            const float value = (float) 42.33;

            var returnedValue = Ensure.ThatTypeFor(value, ParamName).IsFloat();
            AssertReturnedAsExpected(returnedValue, typeof(float));

            Action a = () => EnsureArg.IsFloat(typeof(float), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsFloat(value, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsBool_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(bool), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsBool(),
                () => EnsureArg.IsBool(typeof(int), ParamName),
                () => EnsureArg.IsBool(42, ParamName));
        }

        [Fact]
        public void IsBool_WhenIsCorrectType_It_should_not_throw()
        {
            const bool value = true;

            var returnedValue = Ensure.ThatTypeFor(value, ParamName).IsBool();
            AssertReturnedAsExpected(returnedValue, typeof(bool));

            Action a = () => EnsureArg.IsBool(typeof(bool), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsBool(value, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsDateTime_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(DateTime), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsDateTime(),
                () => EnsureArg.IsDateTime(typeof(int), ParamName),
                () => EnsureArg.IsDateTime(42, ParamName));
        }

        [Fact]
        public void IsDateTime_WhenIsCorrectType_It_should_not_throw()
        {
            var value = DateTime.Now;

            var returnedValue = Ensure.ThatTypeFor(value, ParamName).IsDateTime();
            AssertReturnedAsExpected(returnedValue, typeof(DateTime));

            Action a = () => EnsureArg.IsDateTime(typeof(DateTime), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsDateTime(value, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsString_WhenNotTypeOf_ThrowsArgumentException()
        {
            AssertIsOfTypeScenario(
                typeof(string), typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsString(),
                () => EnsureArg.IsString(typeof(int), ParamName),
                () => EnsureArg.IsString(42, ParamName));
        }

        [Fact]
        public void IsString_WhenIsCorrectType_It_should_not_throw()
        {
            var value = string.Empty;

            var returnedValue = Ensure.ThatTypeFor(value, ParamName).IsString();
            AssertReturnedAsExpected(returnedValue, typeof(string));

            Action a = () => EnsureArg.IsString(typeof(string), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsString(value, ParamName);
            b.ShouldNotThrow();
        }

        [Fact]
        public void IsClass_WhenIsNotClass_ThrowsArgumentException()
        {
            AssertIsNotClass(
                typeof(int),
                () => Ensure.ThatTypeFor(42, ParamName).IsClass(),
                () => Ensure.That(typeof(int), ParamName).IsClass(),
                () => EnsureArg.IsClass(typeof(int), ParamName),
                () => EnsureArg.IsClass(42, ParamName));
        }

        [Fact]
        public void IsClass_WhenPassingNull_ThrowsArgumentNullException()
        {
            AssertAll<ArgumentNullException>(
                ExceptionMessages.Types_IsClass_Failed_Null,
                () => Ensure.That(null as Type, ParamName).IsClass(),
                () => EnsureArg.IsClass(null, ParamName),
                () => EnsureArg.IsClass((Type)null, ParamName));
        }

        [Fact]
        public void IsClass_WhenIsClass_It_should_not_throw()
        {
            var value = new MyClass();

            var returnedValue = Ensure.ThatTypeFor(value, ParamName).IsClass();
            AssertReturnedAsExpected(returnedValue, typeof(MyClass));

            Action a = () => EnsureArg.IsClass(typeof(MyClass), ParamName);
            a.ShouldNotThrow();

            Action b = () => EnsureArg.IsClass(value, ParamName);
            b.ShouldNotThrow();
        }

        private static void AssertIsOfTypeScenario(Type expected, Type actual, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.Types_IsOfType_Failed, expected.FullName, actual.FullName), actions);

        private static void AssertIsNotClass(Type type, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.Types_IsClass_Failed, type.FullName), actions);

        private class MyClass { }
    }
}