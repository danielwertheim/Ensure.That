using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureGuidExtensions
    {
        [DebuggerStepThrough]
        public static Param<Guid> IsNotEmpty(this Param<Guid> param)
        {
            EnsureArg.IsNotEmpty(param.Value, param.Name);

            return param;
        }
    }
}