using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class WithExtraMessageOfTests : UnitTestBase
    {
        [Fact]
        public void WithExtraMessageOf_WhenSpecifyingExtraMessage_ItGetsAppendedOnTheEnd()
        {
            object value = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            var ex = Assert.Throws<ArgumentNullException>(() => Ensure.That(value, ParamName)
                .WithExtraMessageOf(p => "Foo bar is some dummy text.")
                .IsNotNull());

            AssertThrowedAsExpected(ex, ExceptionMessages.Common_IsNotNull_Failed
                + "\r\nFoo bar is some dummy text.");
        }

        [Fact]
        public void WithExtraMessageOf_WhenSpecifyingExtraMessageAsSimpleString_ItGetsAppendedOnTheEnd()
        {
            object value = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            var ex = Assert.Throws<ArgumentNullException>(() => Ensure.That(value, ParamName)
                .WithExtraMessageOf("Foo bar is some dummy text.")
                .IsNotNull());

            AssertThrowedAsExpected(ex, ExceptionMessages.Common_IsNotNull_Failed
                                        + "\r\nFoo bar is some dummy text.");
        }
    }
}