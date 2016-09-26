using System;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class CustomMessageTests : UnitTestBase
    {
        [Fact]
        public void WithExtraMessageOf_WhenSpecifyingExtraMessage_ItGetsAppendedOnTheEnd()
        {
            object value = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            var ex = Assert.Throws<ArgumentNullException>(() => Ensure.That(value, ParamName)
                .WithExtraMessageOf(p => "Foo bar is some dummy text.")
                .IsNotNull());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsNotNull
                + "\r\nFoo bar is some dummy text.");
        }
    }
}