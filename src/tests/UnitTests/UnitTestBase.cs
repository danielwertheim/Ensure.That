using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public abstract class UnitTestBase
    {
        protected const string ParamName = "test";

        protected static void AssertThrowedAsExpected(ArgumentException ex, string expectedMessage, params object[] formattingArgs)
        {
            if (formattingArgs != null && formattingArgs.Any())
                expectedMessage = string.Format(expectedMessage, formattingArgs);

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Contains(expectedMessage + "\r\nParameter name: test", ex.Message);
        }

        protected static void ShouldThrow<TEx>(string expectedMessage, params Action[] actions) where TEx : ArgumentException
        {
            foreach (var action in actions)
            {
                var ex = Assert.Throws<TEx>(action);
                AssertThrowedAsExpected(ex, expectedMessage);
            }
        }

        protected static void ShouldNotThrow(params Action[] actions)
        {
            foreach (var action in actions)
                action.ShouldNotThrow();
        }
    }
}