using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EnsureThat.Resources;
using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Test]
        public void HasItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<int> emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyICollection_ReturnsPassedValues()
        {
            ICollection<int> collection = new Collection<int> { 1, 2, 3 };

            var returnedCollection = Ensure.That(collection, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedCollection.Name);
            CollectionAssert.AreEqual(collection, returnedCollection.Value);
        }

        [Test]
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyCollection_ReturnsPassedValues()
        {
            var collection = new Collection<int> { 1, 2, 3 };

            var returnedCollection = Ensure.That(collection, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedCollection.Name);
            CollectionAssert.AreEqual(collection, returnedCollection.Value);
        }

        [Test]
        public void HasItems_WhenNullArray_ThrowsArgumentException()
        {
            var nullArray = null as int[];

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(nullArray, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyArray, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyArray_ReturnsPassedValues()
        {
            var array = new[] { 1, 2, 3 };

            var returnedArray = Ensure.That(array, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedArray.Name);
            CollectionAssert.AreEqual(array, returnedArray.Value);
        }

        [Test]
        public void HasItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<int> emptyList = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyList, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyIList_ReturnsPassedValues()
        {
            IList<int> list = new List<int> { 1, 2, 3 };

            var returnedArray = Ensure.That(list, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedArray.Name);
            CollectionAssert.AreEqual(list, returnedArray.Value);
        }

        [Test]
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyList = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyList, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyList_ReturnsPassedValues()
        {
            var list = new List<int> { 1, 2, 3 };

            var returnedArray = Ensure.That(list, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedArray.Name);
            CollectionAssert.AreEqual(list, returnedArray.Value);
        }

        [Test]
        public void HasItems_WhenEmptyIDictionary_ThrowsArgumentException()
        {
            IDictionary<string, int> emptyDict = new Dictionary<string, int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyDict, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyIDictionary_ReturnsPassedValues()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returnedArray = Ensure.That(dict, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedArray.Name);
            CollectionAssert.AreEqual(dict, returnedArray.Value);
        }

        [Test]
        public void HasItems_WhenEmptyDictionary_ThrowsArgumentException()
        {
            var emptyDict = new Dictionary<string, int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyDict, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyDictionary_ReturnsPassedValues()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            var returnedArray = Ensure.That(dict, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedArray.Name);
            CollectionAssert.AreEqual(dict, returnedArray.Value);
        }
    }
}