using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureBoolExtensions
    {
        [DebuggerStepThrough]
        public static Param<bool> IsTrue(this Param<bool> param)
        {
            if (!Ensure.IsActive)
                return param;

            if (!param.Value)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Booleans_IsTrueFailed);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<bool> IsFalse(this Param<bool> param)
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Booleans_IsFalseFailed);

            return param;
        }
    }
}