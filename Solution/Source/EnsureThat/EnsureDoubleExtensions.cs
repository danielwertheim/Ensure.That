using System.Diagnostics;
using EnsureThat.Core;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureDoubleExtensions
    {
        [DebuggerStepThrough]
        public static Param<double> IsLt(this Param<double> param, double limit)
        {
            if (param.Value >= limit)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsLt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<double> IsLte(this Param<double> param, double limit)
        {
            if (!(param.Value <= limit))
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsLte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<double> IsGt(this Param<double> param, double limit)
        {
            if (param.Value <= limit)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsGt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<double> IsGte(this Param<double> param, double limit)
        {
            if (!(param.Value >= limit))
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsGte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<double> IsInRange(this Param<double> param, double min, double max)
        {
            if (param.Value < min)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsInRange_ToLow.Inject(param.Value, min));

            if (param.Value > max)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsInRange_ToHigh.Inject(param.Value, max));

            return param;
        }
    }
}