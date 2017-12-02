using System;
using System.Collections.Generic;
using System.Diagnostics;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public static class EnsureEquatableExtensions
    {
        [DebuggerStepThrough]
        public static void Equals<T>(this Param<T> param, T expected) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsEq(expected))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_Is_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void Equals<T>(this Param<T> param, T expected, IEqualityComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value.IsEq(expected, comparer))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_Is_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void DoesNotEqual<T>(this Param<T> param, T expected) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsEq(expected))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_IsNot_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void DoesNotEqual<T>(this Param<T> param, T expected, IEqualityComparer<T> comparer)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.IsEq(expected, comparer))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Comp_IsNot_Failed.Inject(param.Value, expected));
        }
    }
}