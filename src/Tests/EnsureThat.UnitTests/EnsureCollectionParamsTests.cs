using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EnsureThat.Resources;
using Xunit;

namespace EnsureThat.UnitTests
{
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Fact]
        public void HasItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<int> emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyICollection_ReturnsPassedValues()
        {
            ICollection<int> collection = new Collection<int> { 1, 2, 3 };

            var returnedCollection = Ensure.That(collection, ParamName).HasItems();

            Assert.Equal(ParamName, returnedCollection.Name);
            Assert.Equal(collection, returnedCollection.Value);
        }

        [Fact]
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyCollection_ReturnsPassedValues()
        {
            var collection = new Collection<int> { 1, 2, 3 };

            var returnedCollection = Ensure.That(collection, ParamName).HasItems();

            Assert.Equal(ParamName, returnedCollection.Name);
            Assert.Equal(collection, returnedCollection.Value);
        }

        [Fact]
        public void HasItems_WhenNullArray_ThrowsArgumentException()
        {
            var nullArray = null as int[];

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(nullArray, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyArray, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyArray_ReturnsPassedValues()
        {
            var array = new[] { 1, 2, 3 };

            var returnedArray = Ensure.That(array, ParamName).HasItems();

            Assert.Equal(ParamName, returnedArray.Name);
            Assert.Equal(array, returnedArray.Value);
        }

        [Fact]
        public void HasItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<int> emptyList = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyList, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyIList_ReturnsPassedValues()
        {
            IList<int> list = new List<int> { 1, 2, 3 };

            var returnedArray = Ensure.That(list, ParamName).HasItems();

            Assert.Equal(ParamName, returnedArray.Name);
            Assert.Equal(list, returnedArray.Value);
        }

        [Fact]
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyList = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyList, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyList_ReturnsPassedValues()
        {
            var list = new List<int> { 1, 2, 3 };

            var returnedArray = Ensure.That(list, ParamName).HasItems();

            Assert.Equal(ParamName, returnedArray.Name);
            Assert.Equal(list, returnedArray.Value);
        }

        [Fact]
        public void HasItems_WhenEmptyIDictionary_ThrowsArgumentException()
        {
            IDictionary<string, int> emptyDict = new Dictionary<string, int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyDict, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyIDictionary_ReturnsPassedValues()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returnedArray = Ensure.That(dict, ParamName).HasItems();

            Assert.Equal(ParamName, returnedArray.Name);
            Assert.Equal(dict, returnedArray.Value);
        }

        [Fact]
        public void HasItems_WhenEmptyDictionary_ThrowsArgumentException()
        {
            var emptyDict = new Dictionary<string, int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyDict, ParamName).HasItems());

            Assert.Equal(ParamName, ex.ParamName);
            Assert.Equal(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Fact]
        public void HasItems_WhenNonEmptyDictionary_ReturnsPassedValues()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returnedArray = Ensure.That(dict, ParamName).HasItems();

            Assert.Equal(ParamName, returnedArray.Name);
            Assert.Equal(dict, returnedArray.Value);
        }
    }
}