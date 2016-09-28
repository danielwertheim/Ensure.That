using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FluentAssertions;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        [Fact]
        public void HasItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<int> emptyCollection = new Collection<int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyCollection, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyCollection, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyICollection_ShouldNotThrow()
        {
            ICollection<int> collection = new Collection<int> { 1, 2, 3 };

            var returned = Ensure.That(collection, ParamName).HasItems();
            AssertReturnedAsExpected(returned, collection);

            Action a = () => EnsureArg.HasItems(collection, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyCollection, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyCollection, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyCollection_ShouldNotThrow()
        {
            var collection = new Collection<int> { 1, 2, 3 };

            var returned = Ensure.That(collection, ParamName).HasItems();
            AssertReturnedAsExpected(returned, collection);

            Action a = () => EnsureArg.HasItems(collection, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasItems_WhenNullArray_ThrowsArgumentNullException()
        {
            var nullArray = null as int[];

            AssertIsNotNull(
                () => Ensure.That(nullArray, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullArray, ParamName));
        }

        [Fact]
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            AssertIsEmptyCollection(
                () => Ensure.That(emptyArray, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyArray, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyArray_ShouldNotThrow()
        {
            var values = new[] { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).HasItems();
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<int> emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyList, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyList, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyIList_ShouldNotThrow()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).HasItems();
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyList, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyList, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyList_ShouldNotThrow()
        {
            var values = new List<int> { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).HasItems();
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasItems_WhenEmptyIDictionary_ThrowsArgumentException()
        {
            IDictionary<string, int> emptyDict = new Dictionary<string, int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyDict, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyDict, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyIDictionary_ShouldNotThrow()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).HasItems();
            AssertReturnedAsExpected(returned, dict);

            Action a = () => EnsureArg.HasItems(dict, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void HasItems_WhenEmptyDictionary_ThrowsArgumentException()
        {
            var emptyDict = new Dictionary<string, int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyDict, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyDict, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyDictionary_ShouldNotThrow()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).HasItems();
            AssertReturnedAsExpected(returned, dict);

            Action a = () => EnsureArg.HasItems(dict, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void SizeIs_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).SizeIs(values.Length);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.SizeIs(values, values.Length, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length + 1;

            AssertSizeIsWrong(
                values.Length,
                expected,
                () => Ensure.That(values, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(values, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).SizeIs(values.Count);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.SizeIs(values, values.Count, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_collection_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.That(values, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(values, expected, ParamName));
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            const string expectedKey = "Foo";

            AssertContainsKey(
                expectedKey,
                () => Ensure.That(dict, ParamName).ContainsKey(expectedKey),
                () => EnsureArg.ContainsKey(dict, expectedKey, ParamName));
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).ContainsKey("B");
            AssertReturnedAsExpected(returned, dict);

            Action a = () => EnsureArg.HasItems(dict, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            const string expectedKey = "Foo";

            AssertContainsKey(
                expectedKey,
                () => Ensure.That(dict, ParamName).ContainsKey(expectedKey),
                () => EnsureArg.ContainsKey(dict, expectedKey, ParamName));
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).ContainsKey("B");
            AssertReturnedAsExpected(returned, dict);

            Action a = () => EnsureArg.HasItems(dict, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Any_When_IList_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_IList_predicate_yields_something_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Any_When_List_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_List_predicate_yields_something_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Any_When_ICollection_predicate_yields_none_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_ICollection_predicate_yields_something_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Any_When_Collection_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_Collection_predicate_yields_something_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        [Fact]
        public void Any_When_Array_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_Array_predicate_yields_something_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);
            AssertReturnedAsExpected(returned, values);

            Action a = () => EnsureArg.HasItems(values, ParamName);
            a.ShouldNotThrow();
        }

        private void AssertIsEmptyCollection(params Action[] actions) => AssertAll<ArgumentException>(ExceptionMessages.EnsureExtensions_IsEmptyCollection, actions);

        private void AssertIsNotNull(params Action[] actions) => AssertAll<ArgumentNullException>(ExceptionMessages.EnsureExtensions_IsNotNull, actions);

        private void AssertSizeIsWrong(int actualSize, int expectedSize, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_SizeIs_Wrong, expectedSize, actualSize), actions);

        private void AssertContainsKey(string expectedKey, params Action[] actions)
            => AssertAll<ArgumentException>(string.Format(ExceptionMessages.EnsureExtensions_ContainsKey, expectedKey), actions);

        private void AssertAnyPredicateYieldedNone(params Action[] actions) => AssertAll<ArgumentException>(ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone, actions);

        private void AssertAll<TEx>(string expectedMessage, params Action[] actions) where TEx : ArgumentException
        {
            foreach (var action in actions)
            {
                var ex = Assert.Throws<TEx>(action);
                AssertThrowedAsExpected(ex, expectedMessage);
            }
        }
    }
}