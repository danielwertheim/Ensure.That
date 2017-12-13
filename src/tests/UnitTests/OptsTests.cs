using System;
using System.Collections.Generic;
using EnsureThat;
using FluentAssertions;
using Xunit;
// ReSharper disable ExpressionIsAlwaysNull

namespace UnitTests
{
    public class OptsTests
    {
        public class WithExceptionTests : UnitTestBase
        {
            [Fact]
            public void ThrowsTheCustomException()
            {
                object value = null;

                Action a = () => EnsureArg.IsNotNull(value, ParamName, opts => opts.WithException(new KeyNotFoundException()));

                a.ShouldThrow<KeyNotFoundException>();
            }

            [Fact]
            public void WhenWithMessageIsSpecified_ThrowsTheCustomExceptionButDoesNotUseTheExtraMessage()
            {
                object value = null;

                Action a = () => EnsureArg.IsNotNull(value, ParamName, opts => opts.WithMessage("Foo bar").WithException(new KeyNotFoundException()));

                a.ShouldThrow<KeyNotFoundException>().And.Message.Should().NotContain("Foo Bar");
            }
        }

        public class WithMessageTests : UnitTestBase
        {
            [Fact]
            public void ThrowsExceptionWithTheCustomMessage()
            {
                object value = null;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    EnsureArg.IsNotNull(value, ParamName, opts => opts.WithMessage("Foo bar is some dummy text.")));

                AssertThrowedAsExpected(ex, "Foo bar is some dummy text.");
            }
        }
    }
}