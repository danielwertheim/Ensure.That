using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureComparableExtensions
    {
        [DebuggerStepThrough]
        public static Param<T> Is<T>(this Param<T> param, T expected, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (!param.Value.IsEq(expected))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_Is_Failed.Inject(param.Value, expected));
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> IsNot<T>(this Param<T> param, T expected, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value.IsEq(expected))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNot_Failed.Inject(param.Value, expected));
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> IsLt<T>(this Param<T> param, T limit, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (!param.Value.IsLt(limit))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLt.Inject(param.Value, limit));
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> IsLte<T>(this Param<T> param, T limit, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value.IsGt(limit))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLte.Inject(param.Value, limit));
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> IsGt<T>(this Param<T> param, T limit, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (!param.Value.IsGt(limit))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGt.Inject(param.Value, limit));
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> IsGte<T>(this Param<T> param, T limit, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value.IsLt(limit))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGte.Inject(param.Value, limit));
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<T> IsInRange<T>(this Param<T> param, T min, T max, Throws<T>.ExceptionFnConfig exceptionFn = null) where T : struct, IComparable<T>
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value.IsLt(min))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow.Inject(param.Value, min));
            }

            if (param.Value.IsGt(max))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<T>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh.Inject(param.Value, max));
            }

            return param;
        }
    }
}