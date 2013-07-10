using System.Diagnostics;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureDecimalExtensions
    {
        [DebuggerStepThrough]
        public static Param<decimal> IsLt(this Param<decimal> param, decimal limit)
        {
            if (param.Value >= limit)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<decimal> IsLte(this Param<decimal> param, decimal limit)
        {
            if (!(param.Value <= limit))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<decimal> IsGt(this Param<decimal> param, decimal limit)
        {
            if (param.Value <= limit)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<decimal> IsGte(this Param<decimal> param, decimal limit)
        {
            if (!(param.Value >= limit))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<decimal> IsInRange(this Param<decimal> param, decimal min, decimal max)
        {
            if (param.Value < min)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow.Inject(param.Value, min));

            if (param.Value > max)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh.Inject(param.Value, max));

            return param;
        }
    }
}