using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureBoolExtensions
    {
        public static void IsTrue(this Param<bool> param)
        {
            if (!Ensure.IsActive)
                return;

            if (!param.Value)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Booleans_IsTrueFailed);
        }

        public static void IsFalse(this Param<bool> param)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Booleans_IsFalseFailed);
        }
    }
}