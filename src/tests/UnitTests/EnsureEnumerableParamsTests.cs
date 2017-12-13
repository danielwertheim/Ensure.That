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
                () => Ensure.Enumerable.HasItems(nullArray, ParamName));
        }

        [Fact]
        public void HasItems_WhenEmpty_ThrowsArgumentException()
        {
            IReadOnlyCollection<int> emptyCollection = new ReadOnlyCollection<int>(new List<int>());

            AssertIsEmptyCollection(
                () => Ensure.Enumerable.HasItems(emptyCollection, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmpty_ShouldNotThrow()
        {
            IReadOnlyCollection<int> collection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3 });

            ShouldNotThrow(
                () => Ensure.Enumerable.HasItems(collection, ParamName));
        }

        [Fact]
        public void SizeIs_When_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> item = null;

            AssertIsNotNull(
                () => Ensure.Enumerable.SizeIs(item, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_length_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Enumerable.SizeIs(values, values.Length, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_length_It_should_throw_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length + 1;

            AssertSizeIsWrong(
                values.Length,
                expected,
                () => Ensure.Enumerable.SizeIs(values, expected, ParamName));
        }

        [Fact]
        public void Any_When_null_It_throws_ArgumentNullException()
        {
            int[] values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Enumerable.HasAny(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Enumerable.HasAny(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_predicate_yields_something_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.Enumerable.HasItems(values, ParamName));
        }

        private void AssertIsEmptyCollection(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasItemsFailed, actions);

        private void AssertIsNotNull(params Action[] actions) => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private void AssertSizeIsWrong(int actualSize, int expectedSize, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIs_Failed, expectedSize, actualSize), actions);

        private void AssertAnyPredicateYieldedNone(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_Any_Failed, actions);
    }
}