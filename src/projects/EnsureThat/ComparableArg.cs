using System;
using System.Collections.Generic;
using System.Diagnostics;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class ComparableArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public T Is<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public T Is<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected, comparer))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsNot<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public T IsNot<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected, comparer))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsLt<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLt.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public T IsLt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsLt(limit, comparer))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLt.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsLte<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLte.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public T IsLte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsGt(limit, comparer))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLte.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsGt<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGt.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public T IsGt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsGt(limit, comparer))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGt.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsGte<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGte.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public T IsGte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(limit, comparer))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGte.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsInRange<T>([NotNull] T value, T min, T max, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(min))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(value, min));

            if (value.IsGt(max))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(value, max));

            return value;
        }

        [DebuggerStepThrough]
        public T IsInRange<T>(T value, T min, T max, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(min, comparer))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(value, min));

            if (value.IsGt(max, comparer))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(value, max));

            return value;
        }
    }
}
