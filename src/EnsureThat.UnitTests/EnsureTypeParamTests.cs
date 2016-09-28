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
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(NonBogusType));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, BogusType.FullName);
        }

        [Fact]
        public void IsOfType_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(BogusType);

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(BogusType, returnedValue.Type);
        }

        [Fact]
        public void IsInt_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42m, ParamName).IsInt());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(decimal).FullName);
        }

        [Fact]
        public void IsInt_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(42, ParamName).IsInt();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(int), returnedValue.Type);
        }

        [Fact]
        public void IsShort_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsShort());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsShort_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor((short)42, ParamName).IsShort();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(short), returnedValue.Type);
        }

        [Fact]
        public void IsDecimal_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsDecimal());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsDecimal_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(42.33m, ParamName).IsDecimal();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(decimal), returnedValue.Type);
        }

        [Fact]
        public void IsDouble_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsDouble());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsDouble_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(42.33, ParamName).IsDouble();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(double), returnedValue.Type);
        }

        [Fact]
        public void IsFloat_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsFloat());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsFloat_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor((float)42.33, ParamName).IsFloat();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(float), returnedValue.Type);
        }

        [Fact]
        public void IsBool_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsBool());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsBool_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(true, ParamName).IsBool();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(bool), returnedValue.Type);
        }

        [Fact]
        public void IsDateTime_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsDateTime());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsDateTime_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(DateTime.Now, ParamName).IsDateTime();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(DateTime), returnedValue.Type);
        }

        [Fact]
        public void IsString_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsString());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName);
        }

        [Fact]
        public void IsString_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor("Gone fishing", ParamName).IsString();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(string), returnedValue.Type);
        }

        [Fact]
        public void IsClass_WhenIsNotClass_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(typeof(int), ParamName).IsClass());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotClass, typeof(int).FullName);
        }

        [Fact]
        public void IsClass_WhenPassingNull_ThrowsArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(
                () => Ensure.That(null as Type, ParamName).IsClass());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotClass_WasNull);
        }

        [Fact]
        public void IsClass_WhenIsClass_GivesValidResult()
        {
            var returnedValue = Ensure.That(typeof (MyClass), ParamName).IsClass();

            Assert.Equal(ParamName, returnedValue.Name);
            Assert.Equal(typeof(MyClass), returnedValue.Value);
        }

        private class MyClass
        {
        }
    }
}