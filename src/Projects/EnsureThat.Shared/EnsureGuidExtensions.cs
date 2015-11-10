using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureGuidExtensions
    {
        [DebuggerStepThrough]
        public static Param<Guid> IsNotEmpty(this Param<Guid> param)
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value.Equals(Guid.Empty))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsEmptyGuid);

            return param;
        }
    }
}