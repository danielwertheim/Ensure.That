using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsNotEmpty(Guid value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Guid.IsNotEmpty(value, paramName);
    }
}