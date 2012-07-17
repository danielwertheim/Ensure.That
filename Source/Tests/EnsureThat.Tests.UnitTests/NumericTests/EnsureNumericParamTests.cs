using System;
using EnsureThat.Resources;
using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests.NumericTests
{
    public abstract class EnsureNumericParamTests<T> : UnitTestBase where T : struct
    {
        protected const string ParamName = "test";

        protected abstract Param<T> Test_for_IsLt(NumericParamTestSpec<T> spec);

        [Test]
        public void IsLt_WhenValueIsGtLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsLt_WhenValueIsGtLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsLt(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotLt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsLt_WhenValueIsGtLimit();

        [Test]
        public void IsLt_WhenValueIsEqualToLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsLt_WhenValueIsEqualToLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsLt(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotLt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsLt_WhenValueIsEqualToLimit();

        [Test]
        public void IsLt_WhenValueIsLtLimit_ReturnsPassedValues()
        {
            var spec = Spec_for_IsLt_WhenValueIsLtLimit();

            var returnedValue = Test_for_IsLt(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsLt_WhenValueIsLtLimit();

        protected abstract Param<T> Test_for_IsGt(NumericParamTestSpec<T> spec);

        [Test]
        public void IsGt_WhenValueIsEqualToLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsGt_WhenValueIsEqualToLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsGt(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotGt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsGt_WhenValueIsEqualToLimit();

        [Test]
        public void IsGt_WhenValueIsLtLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsGt_WhenValueIsLtLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsGt(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotGt, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsGt_WhenValueIsLtLimit();

        [Test]
        public void IsGt_WhenValueIsGtLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsGt_WhenValueIsGtLimit();

            var returnedValue = Test_for_IsGt(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsGt_WhenValueIsGtLimit();

        protected abstract Param<T> Test_for_IsLte(NumericParamTestSpec<T> spec);

        [Test]
        public void IsLte_WhenValueIsEqualToLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsLte_WhenValueIsEqualToLimit();

            var returnedValue = Test_for_IsLte(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsLte_WhenValueIsEqualToLimit();

        [Test]
        public void IsLte_WhenValueIsGtLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsLte_WhenValueIsGtLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsLte(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotLte, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsLte_WhenValueIsGtLimit();

        [Test]
        public void IsLte_WhenValueIsLtLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsLte_WhenValueIsEqualToLimit();

            var returnedValue = Test_for_IsLte(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsLte_WhenValueIsLtLimit();

        protected abstract Param<T> Test_for_IsGte(NumericParamTestSpec<T> spec);

        [Test]
        public void IsGte_WhenValueIsEqualToLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsGte_WhenValueIsEqualToLimit();

            var returnedValue = Test_for_IsGte(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsGte_WhenValueIsEqualToLimit();

        [Test]
        public void IsGte_WhenValueIsLtLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsGte_WhenValueIsLtLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsGte(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotGte, spec.Value, spec.Limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsGte_WhenValueIsLtLimit();

        [Test]
        public void IsGte_WhenValueIsGtLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsGte_WhenValueIsGtLimit();

            var returnedValue = Test_for_IsGte(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsGte_WhenValueIsGtLimit();

        protected abstract Param<T> Test_for_IsInRange(NumericParamTestSpec<T> spec);

        [Test]
        public void IsInRange_WhenValueIsOnLowerLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsInRange_WhenValueIsOnLowerLimit();

            var returnedValue = Test_for_IsInRange(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsInRange_WhenValueIsOnLowerLimit();

        [Test]
        public void IsInRange_WhenValueIsOnUpperLimit_ReturnsPassedValue()
        {
            var spec = Spec_for_IsInRange_WhenValueIsOnUpperLimit();

            var returnedValue = Test_for_IsInRange(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsInRange_WhenValueIsOnUpperLimit();

        [Test]
        public void IsInRange_WhenValueIsBetweenLimits_ReturnsPassedValue()
        {
            var spec = Spec_for_IsInRange_WhenValueIsBetweenLimits();

            var returnedValue = Test_for_IsInRange(spec);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(spec.Value, returnedValue.Value);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsInRange_WhenValueIsBetweenLimits();

        [Test]
        public void IsInRange_WhenValueIsLowerThanLowerLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsInRange_WhenValueIsLowerThanLowerLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsInRange(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow, spec.Value, spec.LowerLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsInRange_WhenValueIsLowerThanLowerLimit();

        [Test]
        public void IsInRange_WhenValueIsGreaterThanUpperLimit_ThrowsArgumentException()
        {
            var spec = Spec_for_IsInRange_WhenValueIsGreaterThanUpperLimit();

            var ex = Assert.Throws<ArgumentException>(
                () => Test_for_IsInRange(spec));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(string.Format(ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh, spec.Value, spec.UpperLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        protected abstract NumericParamTestSpec<T> Spec_for_IsInRange_WhenValueIsGreaterThanUpperLimit();
    }
}