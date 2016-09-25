using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class ThrowsTests : UnitTestBase
    {
        [Fact]
        public void CustomFn_ReturnsCreatedException()
        {
            var exception = new KeyNotFoundException("Foo");

            var ex = Throws<string>.Instance.Custom(p => exception)(new Param<string>(ParamName, "some fake key"));

            Assert.Equal("Foo", ex.Message);
        }

        [Fact]
        public void Object_IsNotNull_When_null_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(null as object, ParamName).IsNotNull(throws => throws.InvalidOperationException));
        }
        [Fact]
        public void Object_IsNotNull_When_not_null_Does_not_throw()
        {
            Action a = () => Ensure.That(new object(), ParamName).IsNotNull(throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void String_IsNotNullOrEmpty_When_empty_string_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(string.Empty, ParamName).IsNotNullOrEmpty(throws => throws.InvalidOperationException));
        }

        [Fact]
        public void String_IsNotNullOrEmpty_When_non_empty_string_Does_not_throw()
        {
            Action a = () => Ensure.That("test value", ParamName).IsNotNullOrEmpty(throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void String_IsNotNullOrWhiteSpace_When_empty_string_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(string.Empty, ParamName).IsNotNullOrWhiteSpace(throws => throws.InvalidOperationException));
        }

        [Fact]
        public void String_IsNotNullOrWhiteSpace_When_non_empty_string_Does_not_throw()
        {
            Action a = () => Ensure.That("test value", ParamName).IsNotNullOrWhiteSpace(throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_Is_When_non_matching_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(42, ParamName).Is(41, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_Is_When_matching_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).Is(42, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_IsNot_When_matching_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(42, ParamName).IsNot(42, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_IsNot_When_non_matching_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).IsNot(41, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_IsLt_When_not_lt_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(42, ParamName).IsLt(42, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_IsLt_When_lt_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).IsLt(43, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_IsLte_When_not_lte_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(42, ParamName).IsLte(41, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_IsLte_When_lte_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).IsLte(42, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_IsLt_When_not_gt_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(42, ParamName).IsGt(42, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_IsLt_When_gt_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).IsGt(41, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_IsGte_When_not_gte_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(42, ParamName).IsGte(43, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_IsGte_When_gte_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).IsGte(42, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        [Fact]
        public void Comparable_IsInRange_When_not_in_range_Throws_specified_exception()
        {
            AssertInvalidOperationExceptionIsThrown(() => Ensure.That(39, ParamName).IsInRange(40, 45, throws => throws.InvalidOperationException));
        }

        [Fact]
        public void Comparable_IsInRange_When_in_range_Does_not_throw()
        {
            Action a = () => Ensure.That(42, ParamName).IsInRange(40, 45, throws => throws.InvalidOperationException);

            a.ShouldNotThrow();
        }

        private static void AssertInvalidOperationExceptionIsThrown(Action action)
        {
            var ex = Assert.Throws<InvalidOperationException>(action);

            Assert.Equal(
                ExceptionMessages.EnsureExtensions_InvalidOperationException.Inject(ParamName),
                ex.Message);
        }
    }
}