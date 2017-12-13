using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureGuidExtensions
    {
        public static void IsNotEmpty(this Param<Guid> param)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value.Equals(Guid.Empty))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Guids_IsNotEmpty_Failed);
        }
    }
}