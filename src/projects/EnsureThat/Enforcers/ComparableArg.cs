using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class ComparableArg
    {
        [NotNull]
        public T Is<T>(T value, T expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!ValueIsEq(value, expected, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public T Is<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (!ValueIsEq(value, expected, comparer))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public T IsNot<T>(T value, T expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (ValueIsEq(value, expected, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public T IsNot<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (ValueIsEq(value, expected, comparer))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public T IsLt<T>(T value, T limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!ValueIsLt(value, limit, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsLt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (!ValueIsLt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsLte<T>(T value, T limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (ValueIsGt(value, limit, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsLte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (ValueIsGt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsGt<T>(T value, T limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!ValueIsGt(value, limit, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsGt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (!ValueIsGt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsGte<T>(T value, T limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (ValueIsLt(value, limit, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsGte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (ValueIsLt(value, limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsInRange<T>(T value, T min, T max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (ValueIsLt(value, min, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (ValueIsGt(value, max, DefaultComparerFor<T>.C))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        public T IsInRange<T>(T value, T min, T max, IComparer<T> comparer, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (ValueIsLt(value, min, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (ValueIsGt(value, max, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        private static class DefaultComparerFor<T> where T : IComparable<T>
        {
            public static readonly Comparer<T> C = Comparer<T>.Create((x, y) => x.CompareTo(y));
        }

        private static bool ValueIsLt<T>(T x, T y, Comparer<T> c)
            => c.Compare(x, y) < 0;

        private static bool ValueIsEq<T>(T x, T y, Comparer<T> c)
            => c.Compare(x, y) == 0;

        private static bool ValueIsGt<T>(T x, T y, Comparer<T> c)
            => c.Compare(x, y) > 0;

        private static bool ValueIsLt<T>(T x, T y, IComparer<T> c)
            => c.Compare(x, y) < 0;

        private static bool ValueIsEq<T>(T x, T y, IComparer<T> c)
            => c.Compare(x, y) == 0;

        private static bool ValueIsGt<T>(T x, T y, IComparer<T> c)
            => c.Compare(x, y) > 0;
    }
}
