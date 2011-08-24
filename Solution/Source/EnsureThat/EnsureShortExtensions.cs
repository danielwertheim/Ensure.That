using System.Diagnostics;
using EnsureThat.Core;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureShortExtensions
    {
        [DebuggerStepThrough]
        public static Param<short> IsLt(this Param<short> param, short limit)
        {
            if (param.Value >= limit)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsLt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<short> IsLte(this Param<short> param, short limit)
        {
            if (!(param.Value <= limit))
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsLte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<short> IsGt(this Param<short> param, short limit)
        {
            if (param.Value <= limit)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsGt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<short> IsGte(this Param<short> param, short limit)
        {
            if (!(param.Value >= limit))
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsGte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<short> IsInRange(this Param<short> param, short min, short max)
        {
            if (param.Value < min)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsInRange_ToLow.Inject(param.Value, min));

            if (param.Value > max)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsInRange_ToHigh.Inject(param.Value, max));

            return param;
        }
    }
}