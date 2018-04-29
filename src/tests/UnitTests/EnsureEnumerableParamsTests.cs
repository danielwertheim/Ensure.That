using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureEnumerableParamsTests : UnitTestBase
    {
        [Fact]
        public void HasItems_WhenNull_ThrowsArgumentNullException()
        {
            var nullArray = null as int[];

            AssertIsNotNull(
                () => Ensure.Enumerable.HasItems(nullArray, ParamName),
                () => EnsureArg.HasItems(nullArray, ParamName),
                () => Ensure.That(nullArray, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmpty_ThrowsArgumentException()
        {
            IReadOnlyCollection<int> emptyCollection = new ReadOnlyCollection<int>(new List<int>());

            AssertIsEmptyCollection(
                () => Ensure.Enumerable.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmpty_ShouldNotThrow()
        {
            IReadOnlyCollection<int> collection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3 });

            ShouldNotThrow(
                () => Ensure.Enumerable.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void SizeIs_When_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> item = null;

            AssertIsNotNull(
                () => Ensure.Enumerable.SizeIs(item, 1, ParamName),
                () => EnsureArg.SizeIs(item, 1, ParamName),
                () => Ensure.That(item, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_matching_length_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Enumerable.SizeIs(values, values.Length, ParamName),
                () => EnsureArg.SizeIs(values, values.Length, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Length));
        }

        [Fact]
        public void SizeIs_When_non_matching_length_It_should_throw_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length + 1;

            AssertSizeIsWrong(
                values.Length,
                expected,
                () => Ensure.Enumerable.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void Any_When_null_It_throws_ArgumentNullException()
        {
            int[] values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Enumerable.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void Any_When_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Enumerable.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void Any_When_predicate_yields_something_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.Enumerable.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        private void AssertIsEmptyCollection(params Action[] actions)
            => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasItemsFailed, actions);

        private void AssertIsNotNull(params Action[] actions)
            => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private void AssertSizeIsWrong(int actualSize, int expectedSize, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIs_Failed, expectedSize, actualSize), actions);

        private void AssertAnyPredicateYieldedNone(params Action[] actions)
            => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_Any_Failed, actions);
    }
}