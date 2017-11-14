using System;
using System.Diagnostics;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class ComparableArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public T Is<T>([NotNull] T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsNot<T>([NotNull] T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsLt<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLt.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsLte<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLte.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsGt<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGt.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsGte<T>([NotNull] T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGte.Inject(value, limit));

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsInRange<T>([NotNull] T value, T min, T max, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(min))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(value, min));

            if (value.IsGt(max))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(value, max));

            return value;
        }
    }
}