using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        [Fact]
        public void HasItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<int> emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyICollection_ReturnsPassedValues()
        {
            ICollection<int> collection = new Collection<int> { 1, 2, 3 };

            var returned = Ensure.That(collection, ParamName).HasItems();

            AssertReturnedAsExpected(returned, collection);
        }

        [Fact]
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyCollection_ReturnsPassedValues()
        {
            var collection = new Collection<int> { 1, 2, 3 };

            var returned = Ensure.That(collection, ParamName).HasItems();

            AssertReturnedAsExpected(returned, collection);
        }

        [Fact]
        public void HasItems_WhenNullArray_ThrowsArgumentException()
        {
            var nullArray = null as int[];

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(nullArray, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyArray, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyArray_ReturnsPassedValues()
        {
            var values = new[] { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).HasItems();

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void HasItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<int> emptyList = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyList, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyIList_ReturnsPassedValues()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).HasItems();

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyList = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyList, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyList_ReturnsPassedValues()
        {
            var values = new List<int> { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).HasItems();

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void HasItems_WhenEmptyIDictionary_ThrowsArgumentException()
        {
            IDictionary<string, int> emptyDict = new Dictionary<string, int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyDict, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyIDictionary_ReturnsPassedValues()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).HasItems();

            AssertReturnedAsExpected(returned, dict);
        }

        [Fact]
        public void HasItems_WhenEmptyDictionary_ThrowsArgumentException()
        {
            var emptyDict = new Dictionary<string, int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyDict, ParamName).HasItems());

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_IsEmptyCollection);
        }

        [Fact]
        public void HasItems_WhenNonEmptyDictionary_ReturnsPassedValues()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).HasItems();

            Assert.Equal(ParamName, returned.Name);
            Assert.Equal(dict, returned.Value);
        }

        [Fact]
        public void SizeIs_When_matching_length_of_array_It_returns_passed_values()
        {
            var values = new[] { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).SizeIs(values.Length);

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var array = new[] { 1, 2, 3 };
            var expected = array.Length + 1;

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(array, ParamName).SizeIs(expected));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_SizeIs_Wrong, expected, array.Length);
        }

        [Fact]
        public void SizeIs_When_matching_count_of_collection_It_returns_passed_values()
        {
            var values = new List<int> { 1, 2, 3 };

            var returned = Ensure.That(values, ParamName).SizeIs(values.Count);

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_collection_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            var ex = Assert.Throws<ArgumentException>(() => Ensure.That(values, ParamName).SizeIs(expected));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_SizeIs_Wrong, expected, values.Count);
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(dict, ParamName).ContainsKey("Foo"));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_ContainsKey, "Foo");
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_Dictionary_It_returns_passed_values()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).ContainsKey("B");

            AssertReturnedAsExpected(returned, dict);
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(dict, ParamName).ContainsKey("Foo"));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_ContainsKey, "Foo");
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_IDictionary_It_returns_passed_values()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returned = Ensure.That(dict, ParamName).ContainsKey("B");

            AssertReturnedAsExpected(returned, dict);
        }

        [Fact]
        public void Any_When_IList_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(values, ParamName).Any(i => i == 0));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone);
        }

        [Fact]
        public void Any_When_IList_predicate_yields_something_It_returns_passed_values()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void Any_When_List_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3, 4 };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(values, ParamName).Any(i => i == 0));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone);
        }

        [Fact]
        public void Any_When_List_predicate_yields_something_It_returns_passed_values()
        {
            var values = new List<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void Any_When_ICollection_predicate_yields_none_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(values, ParamName).Any(i => i == 0));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone);
        }

        [Fact]
        public void Any_When_ICollection_predicate_yields_something_It_returns_passed_values()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void Any_When_Collection_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(values, ParamName).Any(i => i == 0));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone);
        }

        [Fact]
        public void Any_When_Collection_predicate_yields_something_It_returns_passed_values()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);

            AssertReturnedAsExpected(returned, values);
        }

        [Fact]
        public void Any_When_Array_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3, 4 };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(values, ParamName).Any(i => i == 0));

            AssertThrowedAsExpected(ex, ExceptionMessages.EnsureExtensions_AnyPredicateYieldedNone);
        }

        [Fact]
        public void Any_When_Array_predicate_yields_something_It_returns_passed_values()
        {
            var values = new [] { 1, 2, 3, 4 };

            var returned = Ensure.That(values, ParamName).Any(i => i == 1);

            AssertReturnedAsExpected(returned, values);
        }
    }
}