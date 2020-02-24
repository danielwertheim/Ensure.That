using System;
using System.Collections.Generic;
using System.Linq;
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
                OptsFn options = o => o.WithException(new KeyNotFoundException());

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, options),
                    () => EnsureArg.IsNotNull(value, ParamName, options),
                    () => Ensure.That(value, ParamName, options).IsNotNull()
                }.ToList();

                actions.ForEach(a => a.Should().Throw<KeyNotFoundException>());
            }
            
            [Fact]
            public void ThrowsCustomExceptionWithTheCustomMessageAppendedWithDefaultMessage()
            {
                object value = null;
                OptsFn options = o => o.WithException(defaultMessage => 
                    new InvalidOperationException($"Foo bar is some dummy text. Inner text: {defaultMessage}."));

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, options),
                    () => EnsureArg.IsNotNull(value, ParamName, options),
                    () => Ensure.That(value, ParamName,options).IsNotNull()
                }.ToList();

                actions.ForEach(a => a.Should().Throw<InvalidOperationException>().And.Message.Should().Be(
                    $"Foo bar is some dummy text. Inner text: {ExceptionMessages.Common_IsNotNull_Failed}."));
            }

            [Fact]
            public void WhenWithMessageIsSpecified_ThrowsTheCustomExceptionButDoesNotUseTheExtraMessage()
            {
                object value = null;
                OptsFn options = o => o.WithMessage("Foo bar").WithException(new KeyNotFoundException());

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, options),
                    () => EnsureArg.IsNotNull(value, ParamName, options),
                    () => Ensure.That(value, ParamName,options).IsNotNull()
                }.ToList();

                actions.ForEach(a => a.Should().Throw<KeyNotFoundException>().And.Message.Should().NotContain("Foo Bar"));
            }
        }

        public class WithMessageTests : UnitTestBase
        {
            [Fact]
            public void ThrowsExceptionWithTheCustomMessage()
            {
                object value = null;
                OptsFn options = o => o.WithMessage("Foo bar is some dummy text.");

                ShouldThrow<ArgumentNullException>("Foo bar is some dummy text.",
                    () => Ensure.Any.IsNotNull(value, ParamName, options),
                    () => EnsureArg.IsNotNull(value, ParamName, options),
                    () => Ensure.That(value, ParamName, options).IsNotNull());
            }
        }
    }
}