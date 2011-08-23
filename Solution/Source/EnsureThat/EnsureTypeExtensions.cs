using System;
using System.Diagnostics;
using EnsureThat.Core;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureTypeExtensions
    {
        [DebuggerStepThrough]
        public static TypeParam IsOfType(this TypeParam param, Type type)
        {
            if (!param.Type.Equals(type))
                throw ExceptionFactory.CreateForParamValidation(
                    param.Name,
                    ExceptionMessages.EnsureExtensions_IsOfType.Inject(param.Type.FullName));

            return param;
        }
    }
}