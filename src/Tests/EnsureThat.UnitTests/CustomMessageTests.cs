using System;
using EnsureThat.Resources;
using Xunit;

namespace EnsureThat.Tests.UnitTests
{
    public class CustomMessageTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Fact]
        public void WithCustomMessageOf_WhenSpecifyingExtraMessage_ItGetsAppendedOnTheEnd()
        {
            object value = null;

            var ex = Assert.Throws<ArgumentNullException>(() => Ensure.That(value, ParamName)
                .WithExtraMessageOf(() => "Foo bar is some dummy text.")
                .IsNotNull());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsNotNull
                            + "\r\nFoo bar is some dummy text."            
                            + "\r\nParameter name: test",
                            ex.Message);
        }
    }
}