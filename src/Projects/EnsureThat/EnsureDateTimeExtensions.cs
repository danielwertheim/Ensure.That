using System;
using System.Diagnostics;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureDateTimeExtensions
    {
        [DebuggerStepThrough]
        public static Param<DateTime> IsLt(this Param<DateTime> param, DateTime limit)
        {
            if (param.Value >= limit)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<DateTime> IsLte(this Param<DateTime> param, DateTime limit)
        {
            if (!(param.Value <= limit))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<DateTime> IsGt(this Param<DateTime> param, DateTime limit)
        {
            if (param.Value <= limit)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<DateTime> IsGte(this Param<DateTime> param, DateTime limit)
        {
            if (!(param.Value >= limit))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<DateTime> IsInRange(this Param<DateTime> param, DateTime min, DateTime max)
        {
            if (param.Value < min)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow.Inject(param.Value, min));

            if (param.Value > max)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh.Inject(param.Value, max));

            return param;
        }
    }
}