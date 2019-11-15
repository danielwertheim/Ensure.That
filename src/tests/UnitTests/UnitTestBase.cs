using System;
using System.Linq;
using FluentAssertions;

namespace UnitTests
{
    public abstract class UnitTestBase
    {
        protected const string ParamName = "test";

        private static void AssertThrowedAsExpected(ArgumentException ex, string expectedMessage, params object[] formattingArgs)
        {
            if (formattingArgs != null && formattingArgs.Any())
                expectedMessage = string.Format(expectedMessage, formattingArgs);

            ex.ParamName.Should().Be(ParamName);
#if NETCOREAPP3_0
            var x = $"{expectedMessage} (Parameter 'test')";
#else
            var x = $"{expectedMessage}{Environment.NewLine}Parameter name: test";
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
    }
}