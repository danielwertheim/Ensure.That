using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        [Fact]
        public void HasItems_WhenEmptyIReadonlyCollection_ThrowsArgumentException()
        {
            IReadOnlyCollection<int> emptyCollection = new ReadOnlyCollection<int>(new List<int>());

            AssertIsEmptyCollection(
                () => Ensure.That(emptyCollection, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyCollection, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyIReadOnlyCollection_ShouldNotThrow()
        {
            IReadOnlyCollection<int> collection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3 });

            ShouldNotThrow(
                () => Ensure.That(collection, ParamName).HasItems(),
                () => EnsureArg.HasItems(collection, ParamName));
        }

        [Fact]
        public void HasItems_WhenEmptyIReadOnlyList_ThrowsArgumentException()
        {
            IReadOnlyList<int> emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.That(emptyList, ParamName).HasItems(),
                () => EnsureArg.HasItems(emptyList, ParamName));
        }

        [Fact]
        public void HasItems_WhenNonEmptyIReadOnlyList_ShouldNotThrow()
        {
            IReadOnlyList<int> collection = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.That(collection, ParamName).HasItems(),
                () => EnsureArg.HasItems(collection, ParamName));
        }

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

            ShouldNotThrow(
                () => Ensure.That(collection, ParamName).HasItems(),
                () => EnsureArg.HasItems(collection, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(collection, ParamName).HasItems(),
                () => EnsureArg.HasItems(collection, ParamName));
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
        public void HasItems_WhenNullCollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as Collection<int>;

            AssertIsNotNull(
                () => Ensure.That(nullCollection, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullCollection, ParamName));
        }

        [Fact]
        public void HasItems_WhenNullICollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as ICollection<int>;

            AssertIsNotNull(
                () => Ensure.That(nullCollection, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullCollection, ParamName));
        }

        [Fact]
        public void HasItems_WhenNullList_ThrowsArgumentNullException()
        {
            var nullList = null as List<int>;

            AssertIsNotNull(
                () => Ensure.That(nullList, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullList, ParamName));
        }

        [Fact]
        public void HasItems_WhenNullIList_ThrowsArgumentNullException()
        {
            var nullList = null as IList<int>;

            AssertIsNotNull(
                () => Ensure.That(nullList, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullList, ParamName));
        }

        [Fact]
        public void HasItems_WhenNullDictionary_ThrowsArgumentNullException()
        {
            var nullDictionary = null as Dictionary<int, string>;

            AssertIsNotNull(
                () => Ensure.That(nullDictionary, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullDictionary, ParamName));
        }

        [Fact]
        public void HasItems_WhenNullIDictionary_ThrowsArgumentNullException()
        {
            var nullDictionary = null as IDictionary<int, string>;

            AssertIsNotNull(
                () => Ensure.That(nullDictionary, ParamName).HasItems(),
                () => EnsureArg.HasItems(nullDictionary, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).HasItems(),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).HasItems(),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).HasItems(),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(dict, ParamName).HasItems(),
                () => EnsureArg.HasItems(dict, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(dict, ParamName).HasItems(),
                () => EnsureArg.HasItems(dict, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).SizeIs(values.Length),
                () => EnsureArg.SizeIs(values, values.Length, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).SizeIs(values.Count),
                () => EnsureArg.SizeIs(values, values.Count, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_List_It_throws_ArgumentException()
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
        public void SizeIs_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).SizeIs(values.Count),
                () => EnsureArg.SizeIs(values, values.Count, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.That(values, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(values, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).SizeIs(values.Count),
                () => EnsureArg.SizeIs(values, values.Count, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.That(values, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(values, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).SizeIs(values.Count),
                () => EnsureArg.SizeIs(values, values.Count, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.That(values, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(values, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.That(dict, ParamName).SizeIs(dict.Count),
                () => EnsureArg.SizeIs(dict, dict.Count, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count + 1;

            AssertSizeIsWrong(
                dict.Count,
                expected,
                () => Ensure.That(dict, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(dict, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.That(dict, ParamName).SizeIs(dict.Count),
                () => EnsureArg.SizeIs(dict, dict.Count, ParamName));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count + 1;

            AssertSizeIsWrong(
                dict.Count,
                expected,
                () => Ensure.That(dict, ParamName).SizeIs(expected),
                () => EnsureArg.SizeIs(dict, expected, ParamName));
        }

        [Fact]
        public void SizeIs_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(values, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> item = null;

            AssertIsNotNull(
                () => Ensure.That(item, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(item, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> item = null;

            AssertIsNotNull(
                () => Ensure.That(item, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(item, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> item = null;

            AssertIsNotNull(
                () => Ensure.That(item, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(item, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> item = null;

            AssertIsNotNull(
                () => Ensure.That(item, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(item, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> item = null;

            AssertIsNotNull(
                () => Ensure.That(item, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(item, 1, ParamName));
        }

        [Fact]
        public void SizeIs_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> item = null;

            AssertIsNotNull(
                () => Ensure.That(item, ParamName).SizeIs(1),
                () => EnsureArg.SizeIs(item, 1, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(dict, ParamName).ContainsKey("B"),
                () => EnsureArg.ContainsKey(dict, "B", ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(dict, ParamName).ContainsKey("B"),
                () => EnsureArg.ContainsKey(dict, "B", ParamName));
        }

        [Fact]
        public void ContainsKey_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> dict = null;

            AssertIsNotNull(
                () => Ensure.That(dict, ParamName).ContainsKey("B"),
                () => EnsureArg.ContainsKey(dict, "B", ParamName));
        }

        [Fact]
        public void ContainsKey_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> dict = null;

            AssertIsNotNull(
                () => Ensure.That(dict, ParamName).ContainsKey("B"),
                () => EnsureArg.ContainsKey(dict, "B", ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Any(i => i == 1),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Any(i => i == 1),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Any(i => i == 1),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Any(i => i == 1),
                () => EnsureArg.HasItems(values, ParamName));
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

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Any(i => i == 1),
                () => EnsureArg.HasItems(values, ParamName));
        }

        [Fact]
        public void Any_When_Array_is_null_It_throws_ArgumentNullException()
        {
            int[] values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_Collection_is_null_It_throws_ArgumentNullException()
        {
            Collection<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_ICollection_is_null_It_throws_ArgumentNullException()
        {
            ICollection<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_List_is_null_It_throws_ArgumentNullException()
        {
            List<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_IList_is_null_It_throws_ArgumentNullException()
        {
            IList<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_Dictionary_is_null_It_throws_ArgumentNullException()
        {
            Dictionary<int, int> values = null;
            Func<KeyValuePair<int, int>, bool> predicate = i => i.Value == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Any_When_IDictionary_is_null_It_throws_ArgumentNullException()
        {
            IDictionary<int, int> values = null;
            Func<KeyValuePair<int, int>, bool> predicate = i => i.Value == 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Any(predicate),
                () => EnsureArg.Any(values, predicate, ParamName));
        }

        [Fact]
        public void Contains_When_IList_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            int item = 0;

            AssertContainsPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_IList_predicate_yields_something_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Contains(1),
                () => EnsureArg.HasItems(values, ParamName));
        }

        [Fact]
        public void Contains_When_List_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            int item = 0;

            AssertContainsPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_List_predicate_yields_something_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Contains(1),
                () => EnsureArg.HasItems(values, ParamName));
        }

        [Fact]
        public void Contains_When_ICollection_predicate_yields_none_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };
            int item = 0;

            AssertContainsPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_ICollection_predicate_yields_something_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Contains(1),
                () => EnsureArg.HasItems(values, ParamName));
        }

        [Fact]
        public void Contains_When_Collection_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };
            int item = 0;

            AssertContainsPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_Collection_predicate_yields_something_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Contains(1),
                () => EnsureArg.HasItems(values, ParamName));
        }

        [Fact]
        public void Contains_When_Array_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3, 4 };
            int item = 0;

            AssertContainsPredicateYieldedNone(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_Array_predicate_yields_something_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3, 4 };

            ShouldNotThrow(
                () => Ensure.That(values, ParamName).Contains(1),
                () => EnsureArg.HasItems(values, ParamName));
        }

        [Fact]
        public void Contains_When_Array_is_null_It_throws_ArgumentNullException()
        {
            int[] values = null;
            int item = 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_Collection_is_null_It_throws_ArgumentNullException()
        {
            Collection<int> values = null;
            int item = 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_ICollection_is_null_It_throws_ArgumentNullException()
        {
            ICollection<int> values = null;
            int item = 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_List_is_null_It_throws_ArgumentNullException()
        {
            List<int> values = null;
            int item = 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_IList_is_null_It_throws_ArgumentNullException()
        {
            IList<int> values = null;
            int item = 0;

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_Dictionary_is_null_It_throws_ArgumentNullException()
        {
            Dictionary<int, int> values = null;
            KeyValuePair<int, int> item = new KeyValuePair<int, int>(0, 0);

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        [Fact]
        public void Contains_When_IDictionary_is_null_It_throws_ArgumentNullException()
        {
            IDictionary<int, int> values = null;
            KeyValuePair<int, int> item = new KeyValuePair<int, int>(0, 0);

            AssertIsNotNull(
                () => Ensure.That(values, ParamName).Contains(item),
                () => EnsureArg.Contains(values, item, ParamName));
        }

        private void AssertIsEmptyCollection(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasItemsFailed, actions);

        private void AssertIsNotNull(params Action[] actions) => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private void AssertSizeIsWrong(int actualSize, int expectedSize, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIs_Failed, expectedSize, actualSize), actions);

        private void AssertContainsKey(string expectedKey, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_ContainsKey_Failed, expectedKey), actions);

        private void AssertAnyPredicateYieldedNone(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_Any_Failed, actions);

        private void AssertContainsPredicateYieldedNone(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_Contains_Failed, actions);
    }
}