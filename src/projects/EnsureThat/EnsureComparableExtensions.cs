using System;
using System.Collections.Generic;
using System.Diagnostics;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public static class EnsureComparableExtensions
    {
        [DebuggerStepThrough]
        public static void Is<T>(this Param<T> param, T expected) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsEq(expected))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_Is_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void Is<T>(this Param<T> param, T expected, IEqualityComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsEq(expected, comparer))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_Is_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void IsNot<T>(this Param<T> param, T expected) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsEq(expected))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_IsNot_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void IsNot<T>(this Param<T> param, T expected, IEqualityComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsEq(expected, comparer))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_IsNot_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void IsLt<T>(this Param<T> param, T limit) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsLt(limit))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotLt.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsLt<T>(this Param<T> param, T limit, IComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsLt(limit, comparer))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotLt.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsLte<T>(this Param<T> param, T limit) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsGt(limit))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotLte.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsLte<T>(this Param<T> param, T limit, IComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsGt(limit, comparer))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotLte.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsGt<T>(this Param<T> param, T limit) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsGt(limit))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotGt.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsGt<T>(this Param<T> param, T limit, IComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsGt(limit, comparer))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotGt.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsGte<T>(this Param<T> param, T limit) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsLt(limit))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotGte.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsGte<T>(this Param<T> param, T limit, IComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsLt(limit, comparer))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotGte.Inject(param.Value, limit));
        }

        [DebuggerStepThrough]
        public static void IsInRange<T>(this Param<T> param, T min, T max) where T : IComparable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsLt(min))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(param.Value, min));

            if (param.Value.IsGt(max))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(param.Value, max));
        }

        [DebuggerStepThrough]
        public static void IsInRange<T>(this Param<T> param, T min, T max, IComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsLt(min, comparer))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotInRange_ToLow.Inject(param.Value, min));

            if (param.Value.IsGt(max, comparer))
                throw ExceptionFactory.CreateForComparableParamValidation(param, ExceptionMessages.Comp_IsNotInRange_ToHigh.Inject(param.Value, max));
        }
    }
}