using System;
using System.Diagnostics;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T Is<T>(T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T IsNot<T>(T value, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static T IsLt<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLt.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public static T IsLte<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotLte.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public static T IsGt<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGt.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public static T IsGte<T>(T value, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionMessages.Comp_IsNotGte.Inject(value, limit));

            return value;
        }

        [DebuggerStepThrough]
        public static T IsInRange<T>(T value, T min, T max, string paramName = Param.DefaultName) where T : IComparable<T>
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
