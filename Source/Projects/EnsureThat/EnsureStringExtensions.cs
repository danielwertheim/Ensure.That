using System.Diagnostics;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureStringExtensions
    {
        [DebuggerStepThrough]
        public static Param<string> IsNotNullOrWhiteSpace(this Param<string> param)
        {
            if (string.IsNullOrWhiteSpace(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsNotNullOrEmpty(this Param<string> param)
        {
            if (string.IsNullOrEmpty(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);

            return param;
        }
    }
}