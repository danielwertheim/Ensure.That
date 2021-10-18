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
        public class WithCustomExceptionFactoryTests : UnitTestBase
        {
            [Fact]
            public void ThrowsTheCustomExceptionFromTheFactory()
            {
                object value = null;
                EnsureOptions CreateOptions(in EnsureOptions o) => o.WithExceptionFactory((_, __) => new KeyNotFoundException());

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, CreateOptions),
                    () => EnsureArg.IsNotNull(value, ParamName, CreateOptions),
                    () => Ensure.That(value, ParamName, CreateOptions).IsNotNull()
                }.ToList();

                actions.ForEach(a => a.Should().Throw<KeyNotFoundException>());
            }

            [Fact]
            public void WhenWithMessageAndCustomExceptionAreSpecified_ThrowsTheCustomExceptionFromTheFactory()
            {
                object value = null;

                EnsureOptions CreateOptions(in EnsureOptions o) => o
                    .WithMessage("Foo bar")
                    .WithException(new KeyNotFoundException())
                    .WithExceptionFactory((_, __) => new InvalidTimeZoneException());

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, CreateOptions),
                    () => EnsureArg.IsNotNull(value, ParamName, CreateOptions),
                    () => Ensure.That(value, ParamName,CreateOptions).IsNotNull()
                }.ToList();

                actions.ForEach(a => a.Should().Throw<InvalidTimeZoneException>().And.Message.Should().NotContain("Foo Bar"));
            }
        }

        public class WithExceptionTests : UnitTestBase
        {
            [Fact]
            public void ThrowsTheCustomException()
            {
                object value = null;
                EnsureOptions CreateOptions(in EnsureOptions o) => o.WithException(new KeyNotFoundException());

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, CreateOptions),
                    () => EnsureArg.IsNotNull(value, ParamName, CreateOptions),
                    () => Ensure.That(value, ParamName, CreateOptions).IsNotNull()
                }.ToList();

                actions.ForEach(a => a.Should().Throw<KeyNotFoundException>());
            }

            [Fact]
            public void WhenWithMessageIsSpecified_ThrowsTheCustomExceptionButDoesNotUseTheExtraMessage()
            {
                object value = null;
                EnsureOptions CreateOptions(in EnsureOptions o) => o.WithMessage("Foo bar").WithException(new KeyNotFoundException());

                var actions = new Action[]
                {
                    () => Ensure.Any.IsNotNull(value, ParamName, CreateOptions),
                    () => EnsureArg.IsNotNull(value, ParamName, CreateOptions),
                    () => Ensure.That(value, ParamName, CreateOptions).IsNotNull()
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
                EnsureOptions CreateOptions(in EnsureOptions o) => o.WithMessage("Foo bar is some dummy text.");

                ShouldThrow<ArgumentNullException>("Foo bar is some dummy text.",
                    () => Ensure.Any.IsNotNull(value, ParamName, CreateOptions),
                    () => EnsureArg.IsNotNull(value, ParamName, CreateOptions),
                    () => Ensure.That(value, ParamName, CreateOptions).IsNotNull());
            }
        }
    }
}
