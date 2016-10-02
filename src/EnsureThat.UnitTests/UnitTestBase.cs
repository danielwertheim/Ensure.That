using System;
using System.Linq;
using Xunit;

namespace EnsureThat.UnitTests
{
    public abstract class UnitTestBase
    {
        protected const string ParamName = "test";

        protected static void AssertThrowedAsExpected(ArgumentException ex, string expectedMessage, params object[] formattingArgs)
        {
            if (formattingArgs != null && formattingArgs.Any())
                expectedMessage = string.Format(expectedMessage, formattingArgs);

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(expectedMessage + "\r\nParameter name: test", ex.Message);
        }

        protected static void AssertReturnedAsExpected<T>(Param<T> returned, T expected)
        {
            Assert.Equal(ParamName, returned.Name);
            Assert.Equal(expected, returned.Value);
        }

        protected static void AssertReturnedAsExpected(TypeParam returned, Type expected)
        {
            Assert.Equal(ParamName, returned.Name);
            Assert.Equal(expected, returned.Type);
        }

        protected static void AssertAll<TEx>(string expectedMessage, params Action[] actions) where TEx : ArgumentException
        {
            foreach (var action in actions)
            {
                var ex = Assert.Throws<TEx>(action);
                AssertThrowedAsExpected(ex, expectedMessage);
            }
        }
    }
}