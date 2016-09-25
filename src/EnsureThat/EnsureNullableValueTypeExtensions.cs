using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureNullableValueTypeExtensions
    {
        [DebuggerStepThrough]
        public static Param<T?> IsNotNull<T>(this Param<T?> param) where T : struct
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value == null || !param.Value.HasValue)
                throw ExceptionFactory.CreateForParamNullValidation(param, ExceptionMessages.EnsureExtensions_IsNotNull);

            return param;
        }
    }
}