using System;
using System.Linq;
using EnsureThat.Internals;
using FluentAssertions;

namespace UnitTests
{
    public abstract class UnitTestBase
    {
        protected const string ParamName = "test";

        private static void AssertThrowedAsExpected(ArgumentException ex, string expectedMessage, params object[] formattingArgs)
        {
            if (formattingArgs != null && formattingArgs.Length != 0)
                expectedMessage = string.Format(DefaultFormatProvider.Strings, expectedMessage, formattingArgs);

            ex.ParamName.Should().Be(ParamName);
#if NET462
            var x = $"{expectedMessage}{Environment.NewLine}Parameter name: test";
#else
            var x = $"{expectedMessage} (Parameter 'test')";
#endif
            ex.Message.Should().Contain(x);
        }

        protected static void ShouldThrow<TEx>(string expectedMessage, params Action[] actions) where TEx : ArgumentException
        {
            foreach (var action in actions)
            {
                var ex = action.Should().ThrowExactly<TEx>().Which;

                AssertThrowedAsExpected(ex, expectedMessage);
            }
        }

        protected static void ShouldNotThrow(params Action[] actions)
        {
            foreach (var action in actions)
                action.Should().NotThrow();
        }

        protected static void ShouldThrowButNot<TEx>(params Action[] actions) where TEx : ArgumentException
        {
            foreach (var action in actions)
            {
                var ex = action.Should().Throw<ArgumentException>().Which;
                ex.Should().NotBeOfType<TEx>();
            }
        }

        protected static void ShouldReturn<T>(T expectedResult, params Func<T>[] actions)
        {
            foreach (var action in actions)
                action().Should().Be(expectedResult);
        }
    }
}
