using System;
using EnsureThat.Core;
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
        public void IsTypeOf_WhenNotTypeOf_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(NonBogusType));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsOfType.Inject(BogusType.FullName)
                            + "\r\nParameter name: test",
                            ex.Message);
        }

        [Test]
        public void IsOfType_WhenIsCorrectType_Expect()
        {
            var returnedValue = Ensure.ThatTypeFor(new Bogus(), ParamName).IsOfType(BogusType);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(BogusType, returnedValue.Type);
        }
    }
}