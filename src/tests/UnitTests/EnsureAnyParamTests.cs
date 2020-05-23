using System;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    
    public class EnsureAnyParamTests : UnitTestBase
    {
        [Fact]
        public void HasValue_WhenNull_ThrowsArgumentNullException()
        {
            static void Verify<T>(T value) =>
                ShouldThrow<ArgumentNullException>(
                    ExceptionMessages.Common_IsNotNull_Failed,
                    () => Ensure.Any.HasValue(value, ParamName),
                    () => EnsureArg.HasValue(value, ParamName),
                    () => Ensure.That(value, ParamName).HasValue());

            Verify((int?)null);
            Verify((string)null);
            Verify((Foo?)null);
            Verify((Type)null);
        }

        [Fact]
        public void HasValue_WhenNotNull_ShouldNotThrow()
        {
            static void Verify<T>(T value) =>
                ShouldNotThrow(
                    () => Ensure.Any.HasValue(value, ParamName),
                    () => EnsureArg.HasValue(value, ParamName),
                    () => Ensure.That(value, ParamName).HasValue());

            Verify((int?)1);
            Verify("");
            Verify(Foo.Bar);
            Verify(typeof(int));
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNull_ThrowsArgumentNullException()
        {
            object value = null;

            ShouldThrow<ArgumentNullException>(
                ExceptionMessages.Common_IsNotNull_Failed,
                () => Ensure.Any.IsNotNull(value, ParamName),
                () => EnsureArg.IsNotNull(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotNull_WhenRefTypeIsNotNull_ShouldNotThrow()
        {
            var item = new { Value = 42 };

            ShouldNotThrow(
                () => Ensure.Any.IsNotNull(item, ParamName),
                () => EnsureArg.IsNotNull(item, ParamName),
                () => Ensure.That(item, ParamName).IsNotNull());
        }

        [Fact]
        public void IsNotDefault_WhenIsDefault_ThrowsException()
        {
            int value = default(int);

            ShouldThrow<ArgumentException>(
                ExceptionMessages.ValueTypes_IsNotDefault_Failed,
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotDefault());
        }

        [Fact]
        public void IsNotDefault_WhenIsNotDefault_ShouldNotThrow()
        {
            var value = 42;

            ShouldNotThrow(
                () => Ensure.Any.IsNotDefault(value, ParamName),
                () => EnsureArg.IsNotDefault(value, ParamName),
                () => Ensure.That(value, ParamName).IsNotDefault());
        }
        
        private enum Foo
        {
            Bar
        }
    }
}