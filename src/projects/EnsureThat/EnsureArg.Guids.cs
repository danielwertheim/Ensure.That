using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static Guid IsNotEmpty(Guid value, string paramName = Param.DefaultName)
            => Ensure.Guid.IsNotEmpty(value, paramName);
    }
}