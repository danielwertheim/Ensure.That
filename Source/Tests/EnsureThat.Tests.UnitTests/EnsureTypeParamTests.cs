using System;
using EnsureThat.Resources;
using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class EnsureTypeParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        private class Bogus { }

        private class NonBogus { }

        private static readonly Type BogusType = typeof(Bogus);

        private static readonly Type NonBogusType = typeof(NonBogus);

        [Test]
        public void IsOfType_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(NonBogusType));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, BogusType.FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsOfType_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(BogusType);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(BogusType, returnedValue.Type);
        }

        [Test]
        public void IsInt_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42m, ParamName).IsInt());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(decimal).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsInt_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(42, ParamName).IsInt();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(int), returnedValue.Type);
        }

        [Test]
        public void IsShort_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsShort());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsShort_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor((short)42, ParamName).IsShort();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(short), returnedValue.Type);
        }

        [Test]
        public void IsDecimal_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsDecimal());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsDecimal_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(42.33m, ParamName).IsDecimal();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(decimal), returnedValue.Type);
        }

        [Test]
        public void IsDouble_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsDouble());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsDouble_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(42.33, ParamName).IsDouble();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(double), returnedValue.Type);
        }

        [Test]
        public void IsFloat_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsFloat());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsFloat_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor((float)42.33, ParamName).IsFloat();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(float), returnedValue.Type);
        }

        [Test]
        public void IsBool_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsBool());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsBool_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(true, ParamName).IsBool();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(bool), returnedValue.Type);
        }

        [Test]
        public void IsDateTime_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsDateTime());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsDateTime_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor(DateTime.Now, ParamName).IsDateTime();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(DateTime), returnedValue.Type);
        }

        [Test]
        public void IsString_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(42, ParamName).IsString());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotOfType, typeof(int).FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsString_WhenIsCorrectType_GivesValidResult()
        {
            var returnedValue = Ensure.ThatTypeFor("Gone fishing", ParamName).IsString();

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(typeof(string), returnedValue.Type);
        }
    }
}