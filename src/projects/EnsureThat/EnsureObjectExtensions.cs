using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureObjectExtensions
    {
        [DebuggerStepThrough]
        public static void IsNotNull<T>(this Param<T> param)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param, ExceptionMessages.Common_IsNotNull_Failed);
        }
    }
}