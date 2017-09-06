using System;
using System.Collections.Generic;
using EnsureThat;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class WithExceptionTests : UnitTestBase
    {
        [Fact]
        public void WithException_ThrowsTheCustomMessage()
        {
            object value = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            Action a = () => Ensure.That(value, ParamName)
                .WithException(p => new KeyNotFoundException())
                .IsNotNull();

            a.ShouldThrow<KeyNotFoundException>();
        }

        [Fact]
        public void WithException_WhenWithExtraMessageOfIsSpecified_ThrowsTheCustomMessageButDoesNotUseTheExtraMessage()
        {
            object value = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            Action a = () => Ensure.That(value, ParamName)
                .WithExtraMessageOf(p => "Foo Bar")
                .WithException(p => new KeyNotFoundException())
                .IsNotNull();

            a.ShouldThrow<KeyNotFoundException>().And.Message.Should().NotContain("Foo Bar");
        }
    }
}