using System;
using System.Collections.Generic;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public class ComparableArg : IComparableArg
    {
        private readonly IExceptionFactory _exceptionFactory;

        public ComparableArg(IExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
        }

        [NotNull]
        public T Is<T>(T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!value.IsEq(expected))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        public T Is<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value.IsEq(expected, comparer))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public T IsNot<T>(T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsEq(expected))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        public T IsNot<T>(T value, T expected, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsEq(expected, comparer))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public T IsLt<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!value.IsLt(limit))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotLt.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsLt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value.IsLt(limit, comparer))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotLt.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsLte<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsGt(limit))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotLte.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsLte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsGt(limit, comparer))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotLte.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsGt<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (!value.IsGt(limit))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotGt.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsGt<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value.IsGt(limit, comparer))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotGt.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsGte<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsLt(limit))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotGte.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        public T IsGte<T>(T value, T limit, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsLt(limit, comparer))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotGte.Inject(value, limit), paramName, value, optsFn);

            return value;
        }

        [NotNull]
        public T IsInRange<T>(T value, T min, T max, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
        {
            if (value.IsLt(min))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(value, min), paramName, value, optsFn);

            if (value.IsGt(max))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(value, max), paramName, value, optsFn);

            return value;
        }

        public T IsInRange<T>(T value, T min, T max, IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.IsLt(min, comparer))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(value, min), paramName, value, optsFn);

            if (value.IsGt(max, comparer))
                throw _exceptionFactory.ArgumentOutOfRangeException(ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(value, max), paramName, value, optsFn);

            return value;
        }
    }
}
