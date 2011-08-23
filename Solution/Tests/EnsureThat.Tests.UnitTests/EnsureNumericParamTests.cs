using System;
using EnsureThat.Core;
using EnsureThat.Resources;
using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class EnsureNumericParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Test]
        public void IsLt_WhenIntIsGtLimit_ThrowsArgumentException()
        {
            var limit = 42;
            var value = 43;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsLt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsLt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsLt_WhenIntIsEqualToLimit_ThrowsArgumentException()
        {
            const int limit = 42;
            const int value = 42;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsLt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsLt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsLt_WhenIntIsLtLimit_ReturnsPassedValues()
        {
            const int limit = 42;
            const int value = 41;

            var returnedValue = Ensure.That(value, ParamName).IsLt(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsGt_WhenIntIsEqualToLimit_ThrowsArgumentException()
        {
            var limit = 42;
            var value = 42;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsGt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsGt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsGt_WhenIntIsLtLimit_ThrowsArgumentException()
        {
            var limit = 43;
            var value = 42;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsGt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsGt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsGt_WhenIntIsGtLimit_ReturnsPassedValue()
        {
            const int limit = 41;
            const int value = 42;

            var returnedValue = Ensure.That(value, ParamName).IsGt(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsLte_WhenIntIsEqualToLimit_ReturnsPassedValue()
        {
            const int limit = 42;
            const int value = 42;

            var returnedValue = Ensure.That(value, ParamName).IsLte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsLte_WhenIntIsGtLimit_ThrowsArgumentException()
        {
            var limit = 42;
            var value = 43;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsLte(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsLte.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsLte_WhenIntIsLtLimit_ReturnsPassedValue()
        {
            const int limit = 42;
            const int value = 41;

            var returnedValue = Ensure.That(value, ParamName).IsLte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsGte_WhenIntIsEqualToLimit_ReturnsPassedValue()
        {
            const int limit = 42;
            const int value = 42;

            var returnedValue = Ensure.That(value, ParamName).IsGte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsGte_WhenIntIsLtLimit_ThrowsArgumentException()
        {
            var limit = 42;
            var value = 41;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsGte(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsGte.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsGte_WhenIntIsGtLimit_ReturnsPassedValue()
        {
            const int limit = 41;
            const int value = 42;

            var returnedValue = Ensure.That(value, ParamName).IsGte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsInRange_WhenIntIsOnLowerLimit_ReturnsPassedValue()
        {
            const int lowerLimit = 42;
            const int upperLimit = 50;
            const int value = lowerLimit;

            var returnedValue = Ensure.That(value, ParamName).IsInRange(lowerLimit, upperLimit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsInRange_WhenIntIsOnUpperLimit_ReturnsPassedValue()
        {
            const int lowerLimit = 42;
            const int upperLimit = 50;
            const int value = upperLimit;

            var returnedValue = Ensure.That(value, ParamName).IsInRange(lowerLimit, upperLimit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsInRange_WhenIntIsBetweenLimits_ReturnsPassedValue()
        {
            const int lowerLimit = 40;
            const int upperLimit = 50;
            const int value = 45;

            var returnedValue = Ensure.That(value, ParamName).IsInRange(lowerLimit, upperLimit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void IsInRange_WhenIntIsLowerThanLowerLimit_ThrowsArgumentException()
        {
            const int lowerLimit = 40;
            const int upperLimit = 50;
            const int value = lowerLimit - 1;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsInRange(lowerLimit, upperLimit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsInRange_ToLow.Inject(value, lowerLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void IsInRange_WhenIntIsGreaterThanUpperLimit_ThrowsArgumentException()
        {
            const int lowerLimit = 40;
            const int upperLimit = 50;
            const int value = upperLimit + 1;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.That(value, ParamName).IsInRange(lowerLimit, upperLimit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsInRange_ToHigh.Inject(value, upperLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }
    }
}