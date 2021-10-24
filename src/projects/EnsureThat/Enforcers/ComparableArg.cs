using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed partial class ComparableArg
    {
        public T Is<T>(T value, T expected, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (!ValueIsEq(value, expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName);

            return value;
        }

        public T Is<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (!ValueIsEq(value, expected, comparer))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName);

            return value;
        }

        public T IsNot<T>(T value, T expected, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsEq(value, expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName);

            return value;
        }

        public T IsNot<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsEq(value, expected, comparer))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName);

            return value;
        }

        public T IsLt<T>(T value, T limit, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (!ValueIsLt(value, limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value);

            return value;
        }

        public T IsLt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (!ValueIsLt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value);

            return value;
        }

        public T IsLte<T>(T value, T limit, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsGt(value, limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value);

            return value;
        }

        public T IsLte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsGt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value);

            return value;
        }

        public T IsGt<T>(T value, T limit, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (!ValueIsGt(value, limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value);

            return value;
        }

        public T IsGt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (!ValueIsGt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value);

            return value;
        }

        public T IsGte<T>(T value, T limit, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsLt(value, limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value);

            return value;
        }

        public T IsGte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsLt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value);

            return value;
        }

        public T IsInRange<T>(T value, T min, T max, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsLt(value, min))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value);

            if (ValueIsGt(value, max))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value);

            return value;
        }

        public T IsInRange<T>(T value, T min, T max, IComparer<T> comparer, [InvokerParameterName] string paramName = null) where T : IComparable<T>
        {
            if (ValueIsLt(value, min, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value);

            if (ValueIsGt(value, max, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value);

            return value;
        }

        private static bool ValueIsLt<T>(T x, T y) where T : IComparable<T>
            => x.CompareTo(y) < 0;

        private static bool ValueIsEq<T>(T x, T y) where T : IComparable<T>
            => x.CompareTo(y) == 0;

        private static bool ValueIsGt<T>(T x, T y) where T : IComparable<T>
            => x.CompareTo(y) > 0;

        private static bool ValueIsLt<T>(T x, T y, IComparer<T> c) where T : IComparable<T>
            => c.Compare(x, y) < 0;

        private static bool ValueIsEq<T>(T x, T y, IComparer<T> c) where T : IComparable<T>
            => c.Compare(x, y) == 0;

        private static bool ValueIsGt<T>(T x, T y, IComparer<T> c) where T : IComparable<T>
            => c.Compare(x, y) > 0;
    }
}
