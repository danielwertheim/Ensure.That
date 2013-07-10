using System;
using EnsureThat.Resources;
using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class CustomMessageTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Test]
        public void WithCustomMessageOf_WhenSpecifyingExtraMessage_ItGetsAppendedOnTheEnd()
        {
            object value = null;

            var ex = Assert.Throws<ArgumentNullException>(() => Ensure.That(value, ParamName)
                .WithExtraMessageOf(() => "Foo bar is some dummy text.")
                .IsNotNull());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNotNull
                            + "\r\nFoo bar is some dummy text."            
                            + "\r\nParameter name: test",
                            ex.Message);
        }
    }
}