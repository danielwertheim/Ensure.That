using System;
using System.Collections.Generic;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class ComparableArg
    {
        [NotNull]
        public T Is<T>(T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!value.IsEq(expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public T Is<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value.IsEq(expected, comparer))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public T IsNot<T>(T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsEq(expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public T IsNot<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsEq(expected, comparer))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public T IsLt<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!value.IsLt(limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsLt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value.IsLt(limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsLte<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsGt(limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsLte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsGt(limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsGt<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!value.IsGt(limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsGt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value.IsGt(limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsGte<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsLt(limit))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsGte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsLt(limit, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsInRange<T>(T value, T min, T max, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsLt(min))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (value.IsGt(max))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        public T IsInRange<T>(T value, T min, T max, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsLt(min, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (value.IsGt(max, comparer))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }
    }
}
