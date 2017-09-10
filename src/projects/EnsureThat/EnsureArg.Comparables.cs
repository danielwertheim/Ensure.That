using System;
using System.Diagnostics;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void Is<T>(T param, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(param, expected), paramName);
        }

        [DebuggerStepThrough]
        public static void IsNot<T>(T param, T expected, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(param, expected), paramName);
        }

        [DebuggerStepThrough]
        public static void IsLt<T>(T param, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, param, ExceptionMessages.Comp_IsNotLt.Inject(param, limit));
        }

        [DebuggerStepThrough]
        public static void IsLte<T>(T param, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, param, ExceptionMessages.Comp_IsNotLte.Inject(param, limit));
        }

        [DebuggerStepThrough]
        public static void IsGt<T>(T param, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.IsGt(limit))
                throw new ArgumentOutOfRangeException(paramName, param, ExceptionMessages.Comp_IsNotGt.Inject(param, limit));
        }

        [DebuggerStepThrough]
        public static void IsGte<T>(T param, T limit, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.IsLt(limit))
                throw new ArgumentOutOfRangeException(paramName, param, ExceptionMessages.Comp_IsNotGte.Inject(param, limit));
        }

        [DebuggerStepThrough]
        public static void IsInRange<T>(T param, T min, T max, string paramName = Param.DefaultName) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.IsLt(min))
                throw new ArgumentOutOfRangeException(paramName, param, ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(param, min));

            if (param.IsGt(max))
                throw new ArgumentOutOfRangeException(paramName, param, ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(param, max));
        }
    }
}
