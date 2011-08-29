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
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyCollection, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNonEmptyCollection
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
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyArray, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNonEmptyCollection
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
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyArray = new List<int>();

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(emptyArray, ParamName).HasItems());

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsNonEmptyCollection
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void HasItems_WhenNonEmptyList_ReturnsPassedValues()
        {
            var array = new List<int> { 1, 2, 3 };

            var returnedArray = Ensure.That(array, ParamName).HasItems();

            Assert.AreEqual(ParamName, returnedArray.Name);
            CollectionAssert.AreEqual(array, returnedArray.Value);
        }
    }
}